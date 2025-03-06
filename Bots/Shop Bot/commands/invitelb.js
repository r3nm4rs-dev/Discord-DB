const { MessageEmbed } = require('discord.js');
const config = require('../config.json');
const InviteModel = require("../model/invite");

module.exports.run = async (client, message, args) => {
  if (!args[0]) {
    let data = await InviteModel.find({
      guildID: message.guild.id
    })
    if (!data || data.length == 0) return message.reply("No Invite Data Recorded For This Server").then(msg => setTimeout(() => {
      msg.delete()
      message.delete()
    }, client.config.message_remove_time * 1000))
    let content = "";
    data = data.sort((a, b) => (b.regular - b.left)-(a.regular-a.left))
    data.forEach(d => {
      content += `<@${d.userID}> **Current ${d.regular - d.left} (${d.regular} regular, ${d.left} left, ${d.fake} fake)**\n`
    })
    // if (content = "") content = "No Invite Data Recorded For This Server"
    const mBed = new MessageEmbed()
      .setAuthor(message.guild.name, message.author.displayAvatarURL({ dynamic: true }))
      .setColor(`#56089e`)
      .setDescription(content)
    message.channel.send({
      embeds: [mBed]
    }).then(msg => setTimeout(() => {
      msg.delete()
      message.delete()
    }, client.config.message_remove_time * 1000))
  }
}
