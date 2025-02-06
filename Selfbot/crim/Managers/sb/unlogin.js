const Discord = require("discord.js");
const config = require("../../config.json");
const path = require('path');
const fs = require("fs");
const { Client, Collection } = require("discord.js-selfbot-v13");

module.exports = {
    name: "unlogin",
    description: "Déconnecte toi",
    permissions: "Aucune",

    async run(bot, interaction) {
        const userId = interaction.user.id;

        if (!acccess(bot, interaction, userId)) {
            return interaction.reply({ content: "Vous n'êtes pas autorisé à utiliser cette commande.", ephemeral: true });
        }

        if (config.user && config.user[userId]) {
            delete config.user[userId];

            fs.writeFile(path.join(__dirname, '../../config.json'), JSON.stringify(config, null, 2), (err) => {
                if (err) {
                    console.error("Erreur lors de l'écriture dans le fichier config.json:", err);
                    return interaction.reply({ content: "Une erreur est survenue lors de la déconnexion.", ephemeral: true });
                }

           


                interaction.reply({ content: "Vous avez été déconnecté avec succès.", ephemeral: true });
            });
        } else {
            interaction.reply({ content: "Aucun token trouvé pour votre ID utilisateur.", ephemeral: true });
        }
    }
}

function acccess(bot, interaction, userId) {
    const dev = config.owner || [];
    const allowedRoles = config.role || [];

    const user = bot.users.cache.get(userId);
    const member = user ? interaction.guild.members.cache.get(userId) : null;

    return dev.includes(userId) || member?.roles.cache.some(role => allowedRoles.includes(role.id));
}

