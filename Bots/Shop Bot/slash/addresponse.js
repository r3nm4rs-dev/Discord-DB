const Discord = require('discord.js');
const {PermissionFlagsBits} = require("discord-api-types/v9")
const ResponseModel = require("../model/custom");
const config = require('../config.json');

module.exports = {
    name: "addresponse",
    description: "Add a custom response",
    options: [
        {
            name: "word",
            description: "The word you want to trigger the response",
            type: "STRING",
            required: true
        },
        {
            name: "response",
            description: "The response you want to add",
            type: "STRING",
            required: true
        }
    ],

    run: async (client, interaction) => {
        if(!interaction.member.permissions.has(PermissionFlagsBits.Administrator)) return interaction.reply({embeds:[new Discord.MessageEmbed()
            .setAuthor(`Admin locked`, interaction.user.displayAvatarURL({dynamic:true})) 
            .setDescription(`You Want Administrator permissions to use this Command`)
            .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          msg.delete()
          interaction.deleteReply()
        }, client.config.message_remove_time*1000))

        const word = interaction.options.getString("word");
        const response = interaction.options.getString("response");

        const data = await ResponseModel.findOne({
            message: word
        });

        if (data) return interaction.reply({embeds:[new Discord.MessageEmbed()
            .setAuthor(`Wrong Usage`, interaction.user.displayAvatarURL({dynamic:true}))
            .setDescription(`Word Already Assigned`)
            .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
            interaction.deleteReply()
        }, client.config.message_remove_time*1000))

        let newData = new ResponseModel({
            response: response,
            message: word,
            guildID: interaction.guild.id,
            servername: interaction.guild.name
        })
        newData.save();
        return interaction.reply({embeds:[new Discord.MessageEmbed()
            .setAuthor(`Response Added Successful`, interaction.user.displayAvatarURL({dynamic:true}))
            .setDescription(`Now You Can Trigger ${response} Using ${word}`)
            .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
            interaction.deleteReply()
        }, client.config.message_remove_time*1000))
    }
}