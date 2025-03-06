const Discord = require('discord.js');
const {PermissionFlagsBits} = require("discord-api-types/v9")
const WordModel = require("../model/banword");
const config = require('../config.json');

module.exports.run = async (client, message, args) => {
        if (!message.member.permissions.has(PermissionFlagsBits.Administrator)) return message.channel.send({embeds:[new Discord.MessageEmbed()
            .setAuthor(`Admin locked`, message.author.displayAvatarURL({dynamic:true})) 
            .setDescription(`You Want Administrator permissions to use this Command`)
            .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))

        if (args.length < 1) return message.channel.send({embeds:[new Discord.MessageEmbed() 
            .setAuthor(`Wrong Usage`, message.author.displayAvatarURL({dynamic:true}))
            .setDescription(`Arguments required`)
            .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))

        const word = args.join(" ")

        let data = await WordModel.findOne({
            guildID: message.guild.id
        });
        if (!data) {
          data = new WordModel({
              words: [],
              servername: message.guild.name,
              guildID: message.guild.id
          })
          return await data.save()
        }
        const words = data.words

        if (!words.includes(word)) return message.channel.send({embeds:[new Discord.MessageEmbed() 
            .setAuthor(`Wrong Usage`, message.author.displayAvatarURL({dynamic:true}))
            .setDescription(`Word Not Found In Banlist`)
            .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))

        data.words.pull((word.toLowerCase()))
        await data.save();
        return message.channel.send({embeds:[new Discord.MessageEmbed() 
        .setAuthor(`Word Unbanned Successful`, message.author.displayAvatarURL({dynamic:true}))
        .setDescription(`Now The Word ${args.join(" ")} Was Unbanned`)
        .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))

    }