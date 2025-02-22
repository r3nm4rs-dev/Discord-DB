//const serverSchema = require(`../../models/guild`);
const discord = require('discord.js')
const finitto = require('../../finitto');
const { admins } = require('../..');
const welcomer = new discord.WebhookClient({
      url: finitto.webhooks.general
})

module.exports = {
  name: 'interactionCreate',

  /**
   * @param {CommandInteraction} interaction 
   * @param {Client} client 
   */
  async execute(interaction, client) {
    if (!interaction.isCommand() || interaction.user.bot) return;
    if (interaction.channel.type === "DM") return;

    const data = await admins.findOne({ userId: interaction.user.id })
    const command = client.slash.get(interaction.commandName);

    if (!command) return;

    if (!finitto.owners.includes(interaction.user.id) && !data) {
      return interaction.reply({ embeds: [new discord.EmbedBuilder().setDescription(`:x: You don't have a whitelist.`).setColor(discord.Colors.Red)] })
    }

    if (command.ownerOnly === true) {
      if (!finitto.owners.includes(interaction.user.id)) {
        return interaction.reply({ embeds: [new discord.EmbedBuilder().setDescription(`:x: You don't own a bot.`).setColor(discord.Colors.Red)] })
      }
    }


    const args = [];

    for (let option of interaction.options.data) {
      if (option.type === 'SUB_COMMAND') {
        if (option.name) args.push(option.name);
        option.options?.forEach(x => {
          if (x.value) args.push(x.value);
        });
      } else if (option.value) args.push(option.value);
    }

    try {
 welcomer.send({embeds:[new discord.EmbedBuilder().setDescription(`Server İD : ${interaction.guild.id}`).addFields({name:`Kullanılan Komut:`, value:interaction.commandName}, {name:`Komutu Kullanan:`, value:`${interaction.user.username}#${interaction.user.discriminator} - (${interaction.user.id}) `}).setColor(discord.Colors.Orange)]})
      command.run(client, interaction, args)
    } catch (e) {
      interaction.reply({ content: e.message });
    }

  }
}