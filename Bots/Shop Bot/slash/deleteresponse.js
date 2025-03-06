const Discord = require('discord.js');
const {PermissionFlagsBits} = require("discord-api-types/v9")
const ResponseModel = require("../model/custom");
const config = require('../config.json');

module.exports = {
    name: "deleteresponse",
    description: "Delete a custom response",
    options: [
        {
            name: "response",
            description: "The response you want to delete",
            type: "STRING",
            required: true
        }
    ],

    run: async (client, interaction) => {
        if(!interaction.member.permissions.has(PermissionFlagsBits.Administrator)) return interaction.reply({embeds:[new Discord.MessageEmbed()
            .setAuthor(`Admin locked`, interaction.user.displayAvatarURL({dynamic:true})) 
            .setDescription(`You Want Administrator permissions to use this Command`)
            .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          interaction.deleteReply()
        }, client.config.message_remove_time*1000))

		const word = interaction.options.getString("response")

		const data = await ResponseModel.findOne({
			message: word
		});

		if (data) {
			data.delete();
			return interaction.reply({embeds:[new Discord.MessageEmbed() 
				.setAuthor(`Response Removed Successful`, interaction.user.displayAvatarURL({dynamic:true}))
				.setDescription(`${word} was removed from auto responder`)
				.setColor(`#56089e`)]}).then(msg => setTimeout(() => {
		  interaction.deleteReply()
		}, client.config.message_remove_time*1000))
		}

		else return interaction.reply("No Matching Keyword Found !").then(msg => setTimeout(() => {
			interaction.deleteReply()
		}, client.config.message_remove_time*1000))
	}
}
