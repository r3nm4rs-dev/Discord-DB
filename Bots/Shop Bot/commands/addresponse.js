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

        if (args.length < 2) return message.channel.send({embeds:[new Discord.MessageEmbed() 
            .setAuthor(`Wrong Usage`, message.author.displayAvatarURL({dynamic:true}))
            .setDescription(`Arguments required`)
            .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))

        const word = args.shift();

        const data = await ResponseModel.findOne({
            message: word
        });

        if (data) return message.channel.send({embeds:[new Discord.MessageEmbed() 
            .setAuthor(`Wrong Usage`, message.author.displayAvatarURL({dynamic:true}))
            .setDescription(`Word Already Assigned`)
            .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))

        let newData = new ResponseModel({
            response: args.join(" "),
            message: word,
            guildID: message.guild.id,
            servername: message.guild.name
        })
        newData.save();
        return message.channel.send({embeds:[new Discord.MessageEmbed() 
        .setAuthor(`Response Added Successful`, message.author.displayAvatarURL({dynamic:true}))
        .setDescription(`Now You Can Trigger ${args.join(" ")} Using ${word}`)
        .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))

    }