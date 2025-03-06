const { MessageEmbed } = require('discord.js');
const config = require('../config.json');
const InviteModel = require("../model/invite");

module.exports.run = async (client, message, args) => {
  if (message.mentions.users.size !== 0) {
    let data = await InviteModel.findOne({
      guildID: message.guild.id,
      userID: message.mentions.users.first().id
    })
    if (!data || data.length==0 || data.regular === undefined) return message.reply("No Invite Data Recorded For This Guy")
    let content = "";
      content += `<@${data.userID}> **Current ${data.regular-data.left} (${data.regular} regular, ${data.left} left, ${data.fake} fake)**\n`
    const mBed = new MessageEmbed()
      .setAuthor(message.member.displayName, message.author.displayAvatarURL({dynamic:true})) 
      .setColor(`#56089e`)
      .setDescription(content)
    message.channel.send({
      embeds: [mBed]
    }).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))
  } else {
    let data = await InviteModel.findOne({
      guildID: message.guild.id,
      userID: message.author.id
    })
    if (!data || data.length==0) return message.reply("No Invite Data Recorded For You")
    let content = "";
      content += `<@${data.userID}> **Current ${data.regular-data.left} (${data.regular} regular, ${data.left} left, ${data.fake} fake)**\n`
    // if (content = "") content = "No Invite Data Recorded For This Server"
    const mBed = new MessageEmbed()
      .setAuthor(message.member.displayName, message.author.displayAvatarURL({dynamic:true})) 
      .setColor(`#56089e`)
      .setDescription(content)
    message.channel.send({
      embeds: [mBed]
    }).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))
  }
}
