const Discord = require('discord.js');
const {PermissionFlagsBits} = require("discord-api-types/v9")
const ResponseModel = require("../model/custom");
const config = require('../config.json');

module.exports.run = async (client, message, args) => {
        if (!message.member.permissions.has(PermissionFlagsBits.Administrator)) return message.channel.send({embeds:[new Discord.MessageEmbed()
            .setAuthor(`Admin locked`, message.author.displayAvatarURL({dynamic:true})) 
            .setDescription(`You Want Administrator permissions to use this Command`)
            .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))

        if (!args[0]) return message.channel.send({embeds:[new Discord.MessageEmbed() 
            .setAuthor(`Wrong Usage`, message.author.displayAvatarURL({dynamic:true}))
            .setDescription(`Arguments required`)
            .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))

        const word = args[0]

        const data = await ResponseModel.findOne({
            message: word
        });

        if (data) {
            data.delete();
            return message.channel.send({embeds:[new Discord.MessageEmbed() 
                .setAuthor(`Response Removed Successful`, message.author.displayAvatarURL({dynamic:true}))
                .setDescription(`${word} was removed from auto responder`)
                .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))
        }
        else return message.channel.send("No Matching Keyword Found !").then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))
    }