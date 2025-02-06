const Discord = require("discord.js");
const Client = require('../../index');
module.exports = {
    name: "ticket",
    description: "Envoie le panel ticket",
    owner: true,
    /**
    * @param {Client} client
    * @param {Discord.Interaction} interaction
    */
    run: async (client, interaction) => {
       const embed = new Discord.EmbedBuilder()
       .setColor('#000000')
       .setTitle('***Panel Ticket***')
       .setDescription('***Pour être connecté à la machine, faites un ticket "Connexion". Si vous avez une question, faites un ticket "Support"**.*')
       const connexion = new Discord.ButtonBuilder()
                    .setCustomId(`connexion`)
                    .setStyle(Discord.ButtonStyle.Danger)
                    .setEmoji('<a:UC_Black_skull:1275722522444173343>')
                    .setLabel("Connexion");

                const support = new Discord.ButtonBuilder()
                    .setCustomId(`support`)
                    .setStyle(Discord.ButtonStyle.Success)
                    .setEmoji('<:Black_Clover:1275722530266812509>')
                    .setLabel("Support");

                const row = new Discord.ActionRowBuilder()
                    .addComponents(connexion, support);
      interaction.channel.send({embeds: [embed], components: [row], ephemeral: false})
    }
};