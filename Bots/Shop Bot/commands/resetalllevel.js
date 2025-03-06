const Discord = require('discord.js');

module.exports.run = (client, message, args) => {
  if (!message.member.permissions.has('ADMINISTRATOR')) return message.channel.send({
    embeds: [new Discord.MessageEmbed()
      .setAuthor(`You dont have permission`, message.author.displayAvatarURL({ dynamic: true }))
      .setDescription(`You Want Administrator permissions to use this Command`)
      .setColor(`#56089e`)]
  }).then(msg => setTimeout(() => {
    msg.delete()
    message.delete()
  }, client.config.message_remove_time * 1000))

  let ldata = client.db.all().filter(i => i.ID.startsWith("level_")).sort((a, b) => b.data - a.data);
  let xdata = client.db.all().filter(i => i.ID.startsWith("xp_")).sort((a, b) => b.data - a.data);
  for (let i of ldata) {
    client.db.set(i.ID, 0)
  }
  for (let j of xdata) {
    client.db.set(j.ID, 0)
  }
  return message.channel.send(`Everyones, Levels Were Reset!`).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000));
}