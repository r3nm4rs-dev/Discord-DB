const Discord = require("discord.js")

module.exports.run = async (client, message, args) => {
  const { MessageEmbed } = Discord;
  const { prefix } = client.config
  if (!message.member.permissions.has('MANAGE_MESSAGES')) return message.channel.send({
    embeds: [new MessageEmbed()
      .setAuthor(`You dont have permission`, message.author.displayAvatarURL({ dynamic: true }))
      .setDescription(`You Want Administrator or Delete Messages permissions to use this Command`)
      .setColor(`#56089e`)]
  })
  let delembed = new MessageEmbed()
    .setColor(`#56089e`)
    .setTitle(`\`\` **PURGE | CLEAR | DELETE | PRUNE** \`\``)
    .setThumbnail(message.client.user.displayAvatarURL({ dynamic: true }))
    .setDescription(
      `> Usage :- \`${prefix}purge <amount>\` - Delete a number of messages.\n\`${prefix}purge <amount> `
    )
    .setFooter({
      text:
        `${prefix}purge, ${prefix}clear, ${prefix}delete, ${prefix}prune`
    });

  if (!args[0]) return message.channel.send({ embeds: [delembed] });
  let amount = Number(args[0], 10) || parseInt(args[0]);
  if (isNaN(amount) || !Number.isInteger(amount))
    return message.channel.send({
      embeds: [
        new MessageEmbed()
          .setColor(`#56089e`)
          .setDescription(`Please Enter A Delete Amount Between 1 - 100`)
          .setFooter({ text: `Command Used By ${message.author.username}` })
      ]
    });
  if (!amount || amount < 1 || amount > 100)
    return message.channel.send({
      embeds: [
        new MessageEmbed()
          .setColor(`#56089e`)
          .setDescription(`Please Enter A Delete Amount Between 1 - 100`)
          .setFooter({ text: `Command Used By ${message.author.username}` })
      ]
    });
  if (!args[1]) {
    try {
      await message.delete();
      await message.channel.bulkDelete(amount).then(async (m) => {
        let embed = new MessageEmbed()
          .setColor(`#56089e`)
          .setDescription(
            `<:trash:1123244265477251083>  Cleared **${m.size}**/**${amount}** messages!`
          )
          .setFooter({ text: `Command Used By ${message.author.username}` });

        message.channel
          .send({ embeds: [embed] })
          .then(msg => setTimeout(() => {
            msg.delete()
            message.delete()
          }, client.config.message_remove_time * 1000))
      });
    } catch (e) {
      return null;
    }
  }
}