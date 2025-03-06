const Discord = require('discord.js');
const {PermissionFlagsBits} = require("discord-api-types/v9")
const ResponseModel = require("../model/custom");
const config = require('../config.json');

module.exports.run = async (client, message, args) => {
        if (!message.member.permissions.has(PermissionFlagsBits.Administrator)) return message.channel.send({embeds:[new Discord.MessageEmbed()
            .setAuthor(`Admin locked`, message.author.displayAvatarURL({dynamic:true})) 
            .setDescription(`You Want Administrator permissions to use this Command`)
            .setColor(`#56089e`)
          ]}).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))

        let data = await ResponseModel.find({
            guildID: message.guild.id
        });
        if (!data[0]) return message.reply("No Responses Recorded in This Server")
        let content = "";
        data.map(each => {
            content += `${each.message} - ${each.response}\n`
        })
        return message.channel.send({embeds:[new Discord.MessageEmbed()
            .setAuthor(data[0].servername, message.author.displayAvatarURL({dynamic:true})) 
            .setDescription(content)
            .setColor(`#56089e`)
          ]}
        ).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))
    }