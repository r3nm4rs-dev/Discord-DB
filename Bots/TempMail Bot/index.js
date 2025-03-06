require('dotenv').config();
const { Client, GatewayIntentBits, Collection, Partials } = require('discord.js');
const fs = require('fs');
const path = require('path');
const Database = require('./utils/database');
const WebhookHandler = require('./utils/webhook');
const EmailService = require('./utils/email');

const requiredEnvVars = ['DISCORD_TOKEN', 'TEMPMAIL_API_KEY', 'CATEGORY_ID'];
for (const envVar of requiredEnvVars) {
    if (!process.env[envVar]) {
        console.error(`❌ La variable d'environnement ${envVar} est manquante`);
        process.exit(1);
    }
}

const client = new Client({
    intents: [
        GatewayIntentBits.Guilds,
        GatewayIntentBits.GuildMessages,
        GatewayIntentBits.MessageContent,
        GatewayIntentBits.GuildMembers,
        GatewayIntentBits.GuildIntegrations,
        GatewayIntentBits.GuildMessageReactions
    ],
    partials: [
        Partials.Message,
        Partials.Channel,
        Partials.Reaction
    ]
});

client.commands = new Collection();
client.buttons = new Collection();

client.emailService = new EmailService(client);

const eventsPath = path.join(__dirname, 'events');
const eventFiles = fs.readdirSync(eventsPath).filter(file => file.endsWith('.js'));

for (const file of eventFiles) {
    const filePath = path.join(eventsPath, file);
    const event = require(filePath);
    if (event.once) {
        client.once(event.name, (...args) => event.execute(...args));
    } else {
        client.on(event.name, (...args) => event.execute(...args));
    }
}

const commandsPath = path.join(__dirname, 'commands', 'slashcommands');
const commandFiles = fs.readdirSync(commandsPath).filter(file => file.endsWith('.js'));

for (const file of commandFiles) {
    const filePath = path.join(commandsPath, file);
    const command = require(filePath);
    if ('data' in command && 'execute' in command) {
        client.commands.set(command.data.name, command);
        console.log(`📦 Commande chargée: ${command.data.name}`);
    } else {
        console.warn(`⚠️ La commande ${file} est invalide et sera ignorée.`);
    }
}

const buttonsPath = path.join(__dirname, 'buttons');
const buttonFiles = fs.readdirSync(buttonsPath).filter(file => file.endsWith('.js'));

for (const file of buttonFiles) {
    const filePath = path.join(buttonsPath, file);
    const button = require(filePath);
    if ('id' in button && 'execute' in button) {
        client.buttons.set(button.id, button);
        console.log(`🔘 Bouton chargé: ${button.id}`);
    } else {
        console.warn(`⚠️ Le bouton ${file} est invalide et sera ignoré.`);
    }
}

Database.init().catch(console.error);

setInterval(async () => {
    try {
        const cleaned = await Database.cleanupExpiredEmails();
        if (cleaned > 0) {
            console.log(`🧹 ${cleaned} email(s) expiré(s) supprimé(s)`);
        }
    } catch (error) {
        console.error('❌ Erreur lors du nettoyage des emails expirés:', error);
    }
}, 60 * 1000);

if (process.env.WEBHOOK_PORT) {
    const webhookHandler = new WebhookHandler(client);
    webhookHandler.start();
}

client.login(process.env.DISCORD_TOKEN);