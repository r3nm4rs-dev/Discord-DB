const Discord = require("discord.js");
const config = require("../../config.json")

module.exports = {
    name: "users",
    description: "pour voir les membres connecter.",
    permissions: "Aucune",

    async run(bot, interaction) {
        
        let description = "";
        const userIDs = Object.keys(config.user);
        userIDs.forEach((userID) => {
            description += `- **User :** <@${userID}>\n - **ID :** \`${userID}\`\n\n`;
        });

        let embed = new Discord.EmbedBuilder()
            .setTitle(`**User Connecté :** **${userIDs.length}**`)
            .setDescription(description)
            .setColor("2c2d31");

        interaction.reply({ embeds: [embed], ephemeral: true });
    }
};
