const Discord = require("discord.js")

module.exports.run = (client, message, args) => {
        if (!message.member.permissions.has('KICK_MEMBERS')) return message.channel.send({ embeds: [new Discord.MessageEmbed()
            .setAuthor(`You dont have permission`, message.author.displayAvatarURL({dynamic:true})) 
            .setDescription(`You Want Administrator or Kick Members permissions to use this Command`)
            .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))

        if (!message.mentions.users.size) return message.channel.send({ embeds: [new Discord.MessageEmbed()
        .setAuthor(`No Arguments Passed`, message.author.displayAvatarURL({dynamic:true})) 
        .setDescription(`Mention Someone To Kick`)
        .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))
        
        const member = message.guild.members.cache.get(message.mentions.users.first().id)
        if (!member.kickable) return message.channel.send({ embeds: [new Discord.MessageEmbed()
            .setAuthor(`I dont have permission`, message.author.displayAvatarURL({dynamic:true})) 
            .setDescription(`I Want Administrator or Kick Members permissions to use this Command`)
            .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))
        args.shift()
        if (client.guildsettings[message.guild.id].logs) {
          if (client.guildsettings[message.guild.id].logs.kick_logs) {
            const kick_log_id = client.guildsettings[message.guild.id].logs.kick_logs
            message.guild.channels.cache.get(kick_log_id).send(`${member} was Kicked By ${message.member.displayName} for ${args.join(" ")}`)
          }
        } 
        member.kick(args.join(" "))
        const embed = new Discord.MessageEmbed()
            .setTitle("Successfully Kicked!")
            .setDescription(
                `<@${message.mentions.users.first().id}> Was Kicked`
            )
            .setColor("#56089e")
        return message.channel.send({ embeds: [embed]}).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000));
    }