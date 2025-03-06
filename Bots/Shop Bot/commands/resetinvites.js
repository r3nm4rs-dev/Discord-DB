const { MessageEmbed } = require('discord.js');
const config = require('../config.json');
const InviteModel = require("../model/invite");

module.exports.run = async (client, message, args) => {
  if (!message.member.permissions.has('ADMINISTRATOR')) return message.channel.send({ embeds: [new MessageEmbed()
    .setAuthor(`You dont have permission`, message.author.displayAvatarURL({dynamic:true})) 
    .setDescription(`You Want Administrator permissions to use this Command`)
    .setColor(`#56089e`)] }).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))
  if (!args[0]) {
    let data = await InviteModel.find({
      guildID: message.guild.id
    })
    data.forEach(async (d) => {
      let a = await InviteModel.findByIdAndDelete(d._id)
    })
    const mBed = new MessageEmbed()
      .setAuthor(message.guild.name, message.author.displayAvatarURL({dynamic:true})) 
      .setColor(`#56089e`)
      .setDescription("Server Invites Are Cleared.")
    message.channel.send({
      embeds: [mBed]
    }).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))
  } else {
    if (message.mentions.users.size === 0) return
    const user = message.mentions.users.first()
    let data = await InviteModel.findOneAndDelete({
        guildID: message.guild.id,
        userID: user.id
    });
    const mBed = new MessageEmbed()
      .setAuthor(user.username, message.author.displayAvatarURL({dynamic:true})) 
      .setColor(`#56089e`)
      .setDescription("User Invites Are Cleared.")
    message.channel.send({
      embeds: [mBed]
    }).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))
  }
}
