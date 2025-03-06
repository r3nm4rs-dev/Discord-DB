const Discord = require('discord.js');
const {PermissionFlagsBits} = require("discord-api-types/v9")
const WordModel = require("../model/banword");
const config = require('../config.json');

module.exports = {
    name: 'deletebanword',
    description: 'Delete a word from the banword list',
    options: [
        {
            name: 'word',
            description: "Delete a word from the banword list",
            type: 'STRING',
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

        const word = interaction.options.getString('word')

        let data = await WordModel.findOne({
            guildID: interaction.guild.id
        });
        if (!data) {
          data = new WordModel({
              words: [],
              servername: interaction.guild.name,
              guildID: interaction.guild.id
          })
          return await data.save()
        }
        const words = data.words

        if (!words.includes(word)) return interaction.reply({embeds:[new Discord.MessageEmbed() 
            .setAuthor(`Wrong Usage`, interaction.user.displayAvatarURL({dynamic:true}))
            .setDescription(`Word Not Found In Banlist`)
            .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          interaction.deleteReply()
        }, client.config.message_remove_time*1000))

        data.words.pull((word.toLowerCase()))
        await data.save();
        return interaction.reply({embeds:[new Discord.MessageEmbed() 
        .setAuthor(`Word Unbanned Successful`, interaction.user.displayAvatarURL({dynamic:true}))
        .setDescription(`Now The Word ${word} Was Unbanned`)
        .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          interaction.deleteReply()
        }, client.config.message_remove_time*1000))

    }
}
