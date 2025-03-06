const Discord = require('discord.js');
const {PermissionFlagsBits} = require("discord-api-types/v9")
const WordModel = require("../model/banword");
const config = require('../config.json');

 module.exports = {
    name: 'listbanwords',
    description: 'List all banned words',
    
    run: async (client, Interaction) => {
        if (!Interaction.member.permissions.has(PermissionFlagsBits.Administrator)) return Interaction.reply({embeds:[new Discord.MessageEmbed()
            .setAuthor(`Admin locked`, Interaction.user.displayAvatarURL({dynamic:true})) 
            .setDescription(`You Want Administrator permissions to use this Command`)
            .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          msg.delete()
          Interaction.deleteReply()
        }, client.config.message_remove_time*1000))

        const word = Interaction.options.getString('word')

        let data = await WordModel.findOne({
            guildID: Interaction.guild.id
        });
        if (!data) {
          data = new WordModel({
              words: [],
              servername: Interaction.guild.name,
              guildID: Interaction.guild.id
          })
          await data.save()
        }
        let words = data.words
        let wordesc = ""
        words = words.forEach(word => {
          wordesc+=`${word}\n`
        })
        const listWords = new Discord.MessageEmbed()
          .setAuthor(`Ban Word List`, Interaction.user.displayAvatarURL({dynamic:true})) 
          .setDescription(wordesc)
          .setColor(`#56089e`)

        return Interaction.reply({embeds:[listWords]}).then(msg => setTimeout(() => {
          msg.delete()
          Interaction.deleteReply()
        }, client.config.message_remove_time*1000))
    }
}
