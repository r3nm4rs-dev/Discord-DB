const fs = require("fs");
const Discord = require("discord.js-selfbot-v13");

module.exports = {
    name: "load",
    description: "Charge une sauvegarde pour restaurer les données du serveur.",
    run: async (client, message, args) => {
        if (!message.member.permissions.has(Discord.Permissions.FLAGS.ADMINISTRATOR)) {
            return message.edit(`\`❌\` Vous n'avez pas la permission d'administrateur pour charger une sauvegarde.`);
        }

        if (args.length < 1) {
            return message.edit(`Veuillez spécifier le nom du fichier de sauvegarde à charger après la commande.`);
        }

        let fileName = args[0];
        let filePath = `./backups/${fileName}`;

        if (!fs.existsSync(filePath)) {
            return message.edit(`\`❌\` Le fichier de sauvegarde spécifié n'existe pas.`);
        }

        // Demander une confirmation
        const confirmationMessage = await message.channel.send(`Êtes-vous sûr de vouloir charger la sauvegarde "${fileName}" ? (répondez par "oui" ou "non")`);

        const filter = response => {
            return response.author.id === message.author.id && (response.content.toLowerCase() === "oui" || response.content.toLowerCase() === "non");
        };

        // Attendre la réponse
        message.channel.awaitMessages({ filter, max: 1, time: 60000, errors: ['time'] })
            .then(async collected => {
                const response = collected.first();

                if (response.content.toLowerCase() === "oui") {
                    // Charger la sauvegarde
                    let data = fs.readFileSync(filePath);
                    let guildData = JSON.parse(data);

                    // Restaurer les rôles
                    for (let roleData of guildData.roles) {
                        await message.guild.roles.create({
                            data: {
                                name: roleData.name,
                                color: roleData.color,
                                permissions: roleData.permissions,
                                hoist: roleData.hoist,
                                mentionable: roleData.mentionable
                            }
                        });
                    }

                    // Restaurer les salons
                    for (let channelData of guildData.channels) {
                        await message.guild.channels.create(channelData.name, {
                            type: channelData.type,
                            topic: channelData.topic,
                            nsfw: channelData.nsfw,
                            parent: channelData.parent,
                            permissionOverwrites: channelData.permissionOverwrites
                        });
                    }

                    message.edit(`\`✅\` Sauvegarde chargée avec succès : ${fileName}.`);
                } else {
                    message.edit(`\`❌\` Chargement de la sauvegarde annulé.`);
                }

                confirmationMessage.delete();
                response.delete();
            })
            .catch(() => {
                message.edit(`\`❌\` Temps écoulé. Chargement de la sauvegarde annulé.`);
                confirmationMessage.delete();
            });
    }
};
