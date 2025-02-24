const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");
const fs = require('fs');

module.exports = {
    name: "banner",
    description: "Get a user's banner",
    run: async (client, message, args) => {
        try {
            let user;
            if (args.length > 0) {
                const mention = args[0];
                const userID = mention.replace(/[^0-9]/g, '');

                user = client.users.cache.get(userID);
                if (!user) {
                    user = await client.users.fetch(userID);
                }
            } else {
                user = message.author;
            }

            const dbFilePath = `./db/${message.author.id}.json`;
            const db = JSON.parse(fs.readFileSync(dbFilePath));
            const botName = db.botname || "NEXUS V3"; // Fallback to "Bot" if botname is not defined

            if (!user.banner) {
                return message.edit(await language(client, `♡  **${botName}** ♡\n> L'utilisateur ${user} ne possède pas de bannière.`, `♡  **${botName}** ♡\n> User ${user} has no banner.`));
            }

            const bannerURL = user.bannerURL({ dynamic: true, format: 'png', size: 1024 });

            message.edit(await language(client, `♡  **${botName}** ♡\n> **Bannière de ${user} :** ${bannerURL}`, `♡  **${botName}** ♡\n> **Banner of ${user} :** ${bannerURL}`));
        } catch (e) {
            message.edit(await language(client, `Une erreur s'est produite : ${e.message}`, `An error occurred: ${e.message}`));
        }
    }
};
