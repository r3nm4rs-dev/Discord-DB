const fs = require("fs");
const path = require("path");
const Discord = require("discord.js-selfbot-v13");

module.exports = {
    name: "load-emojis",
    description: "Charge des emojis à partir d'un fichier de sauvegarde.",
    run: async (client, message, args) => {
        if (!message.member.permissions.has(Discord.Permissions.FLAGS.ADMINISTRATOR)) {
            return message.edit(`\`❌\` Vous n'avez pas la permission d'administrateur pour charger des emojis.`);
        }

        if (args.length < 1) {
            return message.edit(`Veuillez spécifier l'ID du serveur où charger les emojis.`);
        }

        const serverId = args[0];
        const filePath = path.join(__dirname, 'backups', `emojis-backup-${serverId}.json`);

        if (!fs.existsSync(filePath)) {
            return message.edit(`\`❌\` Le fichier de sauvegarde spécifié n'existe pas.`);
        }

        // Charger la sauvegarde
        let data = fs.readFileSync(filePath);
        let emojis = JSON.parse(data);

        // Demander une confirmation
        const confirmationMessage = await message.channel.send(`Êtes-vous sûr de vouloir charger les emojis pour le serveur ${serverId} ? (répondez par "oui" ou "non")`);

        const filter = response => {
            return response.author.id === message.author.id && (response.content.toLowerCase() === "oui" || response.content.toLowerCase() === "non");
        };

        // Attendre la réponse
        message.channel.awaitMessages({ filter, max: 1, time: 60000, errors: ['time'] })
            .then(async collected => {
                const response = collected.first();

                if (response.content.toLowerCase() === "oui") {
                    // Restaurer les emojis
                    for (let emojiData of emojis) {
                        await message.guild.emojis.create(emojiData.url, emojiData.name, { reason: 'Restaurer les emojis depuis une sauvegarde.' });
                    }

                    message.edit(`\`✅\` Emojis chargés avec succès pour le serveur ${serverId}.`);
                } else {
                    message.edit(`\`❌\` Chargement des emojis annulé.`);
                }

                confirmationMessage.delete();
                response.delete();
            })
            .catch(() => {
                message.edit(`\`❌\` Temps écoulé. Chargement des emojis annulé.`);
                confirmationMessage.delete();
            });
    }
};
