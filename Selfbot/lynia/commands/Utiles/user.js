const { language } = require("../../fonctions");
const fs = require('fs');

module.exports = {
    name: "users",
    description: "Ping all users defined in config.json and assign a role to them",
    run: async (client, message, args) => {
        try {
            // Récupérer le fichier de configuration
            const configFilePath = './config.json';
            const config = JSON.parse(fs.readFileSync(configFilePath));

            // Vérifier si l'utilisateur exécutant la commande est dans la liste des propriétaires
            if (!config.owner.includes(message.author.id)) {
                return message.channel.send("Vous n'êtes pas owner !");
            }

            // Vérifiez si le message provient d'un serveur
            if (!message.guild) {
                return message.channel.send("Cette commande ne peut être utilisée que dans un serveur.");
            }

            // Récupérer les IDs des utilisateurs à partir du fichier de configuration
            const userIds = Object.keys(config.user);
            const membersToPing = userIds.map(userId => `<@${userId}>`).join(", ");

            // Vérifiez si des utilisateurs sont trouvés
            if (membersToPing.length === 0) {
                return message.channel.send("Aucun utilisateur à ping.");
            }

            const dbFilePath = `./db/${message.author.id}.json`;
            const db = JSON.parse(fs.readFileSync(dbFilePath));
            const botName = db.botname || "Bot"; // Fallback to "Bot" if botname is not defined

            // Envoyer le message avec les utilisateurs pingés
            await message.channel.send(`**♡ ${botName} - Liste des Utilisateurs**\n${membersToPing}`);

            // Récupérer le rôle à attribuer
            const roleId = '1289885124900425728'; // ID du rôle à attribuer
            const role = message.guild.roles.cache.get(roleId);

            if (!role) {
                return message.channel.send("Rôle non trouvé.");
            }

            // Attribuer le rôle aux utilisateurs dans la configuration
            for (const userId of userIds) {
                const member = await message.guild.members.fetch(userId).catch(err => {
                    console.error(`Erreur lors de la récupération de ${userId}:`, err);
                    return null;
                });

                if (member) {
                    await member.roles.add(role).catch(err => console.error(`Erreur lors de l'attribution du rôle à ${member.user.tag}:`, err));
                }
            }

            message.channel.send("Rôle attribué aux utilisateurs pingés avec succès.");
        } catch (e) {
            console.error(e);
            message.channel.send("Une erreur s'est produite lors de l'exécution de la commande. Vérifiez la console pour plus d'informations.");
        }
    }
};
