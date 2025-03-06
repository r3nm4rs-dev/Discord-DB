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
          await data.save()
        }
        let words = data.words
        let wordesc = ""
        words = words.forEach(word => {
          wordesc+=`${word}\n`
        })
        const listWords = new Discord.MessageEmbed()
          .setAuthor(`Ban Word List`, message.author.displayAvatarURL({dynamic:true})) 
          .setDescription(wordesc)
          .setColor(`#56089e`)

        return message.channel.send({embeds:[listWords]}).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))
    }