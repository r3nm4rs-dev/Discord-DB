require('dotenv').config();
const { REST, Routes } = require('discord.js');
const { readdirSync } = require('fs');
const { join } = require('path');

async function deleteCommands(rest, clientId) {
    try {
        const existingCommands = await rest.get(Routes.applicationCommands(clientId));
        
        console.log('🗑️ Suppression des commandes existantes...');
        for (const command of existingCommands) {
            await rest.delete(Routes.applicationCommand(clientId, command.id));
            console.log(`Commande supprimée: ${command.name}`);
        }
        console.log('✅ Toutes les commandes ont été supprimées');
    } catch (error) {
        console.error('Erreur lors de la suppression des commandes:', error);
        throw error;
    }
}

async function deployCommands() {
    try {
        if (!process.env.DISCORD_TOKEN) {
            throw new Error('DISCORD_TOKEN manquant dans le fichier .env');
        }

        if (!process.env.CLIENT_ID) {
            throw new Error('CLIENT_ID manquant dans le fichier .env');
        }

        const rest = new REST({ version: '10' }).setToken(process.env.DISCORD_TOKEN);

        await deleteCommands(rest, process.env.CLIENT_ID);

        const commands = [];
        const commandsPath = join(__dirname, 'commands', 'slashcommands');
        const commandFiles = readdirSync(commandsPath).filter(file => file.endsWith('.js'));

        for (const file of commandFiles) {
            const filePath = join(commandsPath, file);
            delete require.cache[require.resolve(filePath)];
            const command = require(filePath);
            
            if ('data' in command && 'execute' in command) {
                commands.push(command.data.toJSON());
                console.log(`📦 Commande chargée: ${command.data.name}`);
            } else {
                console.warn(`⚠️ La commande ${file} est invalide et sera ignorée.`);
            }
        }

        console.log('🚀 Début du déploiement des commandes...');
        
        const data = await rest.put(
            Routes.applicationCommands(process.env.CLIENT_ID),
            { body: commands }
        );

        console.log(`✅ ${data.length} commandes déployées avec succès!`);
        console.log('📋 Liste des commandes:');
        commands.forEach(cmd => console.log(` - /${cmd.name}`));

    } catch (error) {
        console.error('❌ Erreur lors du déploiement des commandes:', error);
        process.exit(1);
    }
}

deployCommands();