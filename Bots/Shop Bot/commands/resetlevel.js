const Discord = require('discord.js');

module.exports.run = (client, message, args) => {
  if (!message.member.permissions.has('ADMINISTRATOR')) return message.channel.send({ embeds: [new Discord.MessageEmbed()
    .setAuthor(`You dont have permission`, message.author.displayAvatarURL({dynamic:true})) 
    .setDescription(`You Want Administrator permissions to use this Command`)
    .setColor(`#56089e`)] }).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))
  if (!message.mentions.users.size) return message.channel.send({ embeds: [new Discord.MessageEmbed()
    .setAuthor(`No Arguments Passed`, message.author.displayAvatarURL({dynamic:true})) 
    .setDescription(`Mention Someone To Reset levels`)
    .setColor(`#56089e`)] }).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))
  
  if (client.db.get(`level_${message.mentions.users.first().id}`)) {
    let newLevel = client.db.set(`level_${message.mentions.users.first().id}`, 0);
    client.db.set(`xp_${message.mentions.users.first().id}`, 0)
    message.channel.send(`${message.mentions.users.first()}, Level Was Reset!`).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000));
  }
  else {
    client.db.set(`level_${message.mentions.users.first().id}`, 0)
    client.db.set(`xp_${message.mentions.users.first().id}`, 0)
    let newLevel = client.db.get(`level_${message.mentions.users.first().id}`);
    message.channel.send(`${message.mentions.users.first()}, Level Was Reset!`).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000));
  }
}