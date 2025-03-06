const Discord = require('discord.js');
const {PermissionFlagsBits} = require("discord-api-types/v9")
const ResponseModel = require("../model/custom");
const config = require('../config.json');

module.exports = {
    name: "listresponse",
    description: "Shows the list of responses in the server",

    run: async (client, interaction) => {
        if (!interaction.member.permissions.has(PermissionFlagsBits.Administrator)) return interaction.reply({embeds:[new Discord.MessageEmbed()
            .setAuthor(`Admin locked`, interaction.user.displayAvatarURL({dynamic:true})) 
            .setDescription(`You Want Administrator permissions to use this Command`)
            .setColor(`#56089e`)
          ]}).then(msg => setTimeout(() => {
          interaction.deleteReply()
        }, client.config.message_remove_time*1000))

        let data = await ResponseModel.find({
            guildID: interaction.guild.id
        });
        if (!data[0]) return interaction.reply("No Responses Recorded in This Server")
        let content = "";
        data.map(each => {
            content += `${each.message} - ${each.response}\n`
        })
        return interaction.reply({embeds:[new Discord.MessageEmbed()
            .setAuthor(data[0].servername, interaction.user.displayAvatarURL({dynamic:true})) 
            .setDescription(content)
            .setColor(`#56089e`)
          ]}
        ).then(msg => setTimeout(() => {
          interaction.deleteReply()
        }, client.config.message_remove_time*1000))
    }
}

