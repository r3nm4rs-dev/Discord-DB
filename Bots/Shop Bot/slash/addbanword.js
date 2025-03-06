const Discord = require('discord.js');
const {PermissionFlagsBits} = require("discord-api-types/v9")
const WordModel = require("../model/banword");
const config = require('../config.json');

module.exports= {
    name: "addbanword",
    description: "Add a word to the banned words list",
    options: [
        {
            name: "word",
            description: "The word to add to the banned words list",
            type: "STRING",
            required: true
        }
    ],

    run: async (client, interaction) => {
        if (!interaction.member.permissions.has(PermissionFlagsBits.Administrator)) return interaction.reply({embeds:[new Discord.MessageEmbed()
            .setAuthor(`Admin locked`, interaction.user.displayAvatarURL({dynamic:true})) 
            .setDescription(`You Want Administrator permissions to use this Command`)
            .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          interaction.deleteReply()
        }, client.config.message_remove_time*1000))

        const word = interaction.options.getString("word")

        let data = await WordModel.findOne({
            guildID: interaction.guild.id
        });
        if (!data) {
          data = new WordModel({
              words: [],
              servername: interaction.guild.name,
              guildID: interaction.guild.id
          })
          await data.save()
        }
        const words = data.words

        if (words.includes(word)) return interaction.reply({embeds:[new Discord.MessageEmbed() 
            .setAuthor(`Wrong Usage`, interaction.user.displayAvatarURL({dynamic:true}))
            .setDescription(`Word Already Banned`)
            .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          interaction.deleteReply()
        }, client.config.message_remove_time*1000))

        data.words.push((word.toLowerCase()))
        await data.save();
        return interaction.reply({embeds:[new Discord.MessageEmbed() 
        .setAuthor(`Word Banned Successful`, interaction.user.displayAvatarURL({dynamic:true}))
        .setDescription(`Now The Word ${word} Was Banned`)
        .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          interaction.deleteReply()
        }, client.config.message_remove_time*1000))

    }
}
