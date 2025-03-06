const Discord = require('discord.js');

module.exports.run = (client, message, args) => {
  if (!message.member.permissions.has('ADMINISTRATOR')) return message.channel.send({ embeds: [new Discord.MessageEmbed()
    .setAuthor(`You dont have permission`, message.author.displayAvatarURL({dynamic:true})) 
    .setDescription(`You Want Administrator permissions to use this Command`)
    .setColor(`#56089e`)] }).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))
  if (args.length < 2) return message.channel.send({ embeds: [new Discord.MessageEmbed() 
    .setAuthor(`Wrong Usage`, message.author.displayAvatarURL({dynamic:true}))
    .setDescription(`Arguments required`)
    .setColor(`#56089e`)] }).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))
  if (isNaN(args[1])) return message.channel.send({ embeds: [new Discord.MessageEmbed() 
    .setAuthor(`Wrong Usage`, message.author.displayAvatarURL({dynamic:true}))
    .setDescription(`Arguments Must Be A Number`)
    .setColor(`#56089e`)] }).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))
  if (!message.mentions.users.size) return message.channel.send({ embeds: [new Discord.MessageEmbed()
    .setAuthor(`No Arguments Passed`, message.author.displayAvatarURL({dynamic:true})) 
    .setDescription(`Mention Someone To Add levels`)
    .setColor(`#56089e`)] }).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))
  if (client.db.get(`level_${message.mentions.users.first().id}`) > parseInt(args[1], 10)) return message.channel.send({ embeds: [new Discord.MessageEmbed()
    .setAuthor(`The User Level is Higher`, message.author.displayAvatarURL({dynamic:true})) 
    .setDescription(`Given Level Must Be Higher Than Current Level`)
    .setColor(`#56089e`)] }).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))
  if (client.db.get(`level_${message.mentions.users.first().id}`)) {
    let newLevel = client.db.set(`level_${message.mentions.users.first().id}`, parseInt(args[1], 10));
    message.channel.send(`:tada: ${message.mentions.users.first()}, You just advanced to level ${newLevel}!`).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000));
  }
  else {
    client.db.set(`level_${message.mentions.users.first().id}`, parseInt(args[1], 10))
    let newLevel = client.db.get(`level_${message.mentions.users.first().id}`);
    message.channel.send(`:tada: ${message.mentions.users.first()}, You just advanced to level ${newLevel}!`).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000));
  }
}