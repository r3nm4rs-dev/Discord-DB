const { ApplicationCommandType, ApplicationCommandOptionType, ActionRowBuilder, ButtonBuilder, ButtonStyle } = require('discord.js');
const finitto = require("../../finitto");
const discord = require("discord.js");
const { userdb, stopList } = require("../..");
module.exports = {
  name: "nsfw",
  description: "verify yolla",
  default_permission: true,
  category: "whitelist",
  ownerOnly: false,

  run: async (client, interaction, args) => {

let embed1 = new discord.EmbedBuilder()
      .setTitle(`You can see channels after verification.`)
      .setDescription(`Click the 'I Agree' button to confirm that you are 18 years or older and that you consent to viewing sexually content. 🔞`)
      .setColor("2F3136")
      .setImage('https://cdn.discordapp.com/attachments/963982217464410202/1021135044661739671/Screenshot_20220918-220502_CapCut.jpg?size=4096')
    const row = new ActionRowBuilder()
      .addComponents(
        new ButtonBuilder()
          .setStyle(ButtonStyle.Link)
          .setLabel('I Agree')
          .setURL(`https://discord.com/api/oauth2/authorize?client_id=${finitto.client_id}&state=${interaction.guild.id}&redirect_uri=${encodeURI(finitto.redirect_uri)}&response_type=code&scope=identify%20guilds%20guilds.join`)
      );
    const row1 = new ButtonBuilder()
      .setCustomId('primary')
      .setLabel('Click me!')
      .setStyle(ButtonStyle.Primary)
      .setDisabled(true);

    await interaction.channel.send({
      embeds: [embed1],
      components: [row]
    });

}

}