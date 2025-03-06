const { MessageEmbed } = require('discord.js');
const config = require('../config.json');

module.exports.run = async (client, message, args) => {
  if (client.afks.get(message.author.id)) {
    if (message.member.manageable) { 
      if (message.member.roles.highest.rawPosition !== message.guild.members.cache.get(client.user.id).roles.highest.rawPosition) {
        if ((message.member.roles.highest.rawPosition < message.guild.members.cache.get(client.user.id).roles.highest.rawPosition)) { message.member.setNickname((message.member.displayName).replace("[AFK]", "")) }
      }
    }
    client.afks.delete(message.author.id)
    return message.reply({
      embeds: [new MessageEmbed().setTitle("Your Afk Was Removed").setColor("#56089e").setDescription("Users Pings You Will Not be Notified")]
    }).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))
  }
  else if (message.member.displayName.includes("[AFK]")) {
    function escapeRegex(string) {
        return string.replace(/[-\/\\^$*+?.()|[\]{}]/g, '\\$&');
    }
    function replaceAll(str) {
      return str.replace(new RegExp(escapeRegex("[AFK]"), 'g'), "");
    }
    message.member.setNickname(replaceAll(message.member.displayName))
    return message.reply({
      embeds: [new MessageEmbed().setTitle("Your Afk Was Removed").setColor("#56089e").setDescription("Users Pings You Will Not be Notified")]
    }).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))
  }
  if (!args[0]) {
    client.afks.set(message.author.id, "The User Went Afk.")
    if (message.member.manageable) {
    if (message.member.roles.highest.rawPosition !== message.guild.members.cache.get(client.user.id).roles.highest.rawPosition) {
      if ((message.member.roles.highest.rawPosition < message.guild.members.cache.get(client.user.id).roles.highest.rawPosition)) { message.member.setNickname(`[AFK] ${message.member.displayName}`) }
    }
    }
  
    return message.reply({
      embeds:[new MessageEmbed().setTitle("Your Afk Was Recorded").setColor("#56089e").setDescription("Users Pings You Will be Notified")]
    }).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))
  }
  else {
    if (message.member.manageable) {
    if (message.member.roles.highest.rawPosition !== message.guild.members.cache.get(client.user.id).roles.highest.rawPosition) {
      if ((message.member.roles.highest.rawPosition < message.guild.members.cache.get(client.user.id).roles.highest.rawPosition)) { message.member.setNickname(`[AFK] ${message.member.displayName}`) }
    }
    }
    client.afks.set(message.author.id, args.join(" "))
    return message.reply({
      embeds:[new MessageEmbed().setTitle("Your Afk Was Recorded").setColor("#56089e").setDescription("Users Pings You Will be Notified")]
    }).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))
  }
}
