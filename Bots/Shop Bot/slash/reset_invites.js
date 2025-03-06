const { MessageEmbed } = require('discord.js');
const config = require('../config.json');
const InviteModel = require("../model/invite");

module.exports = {
    name: "reset_invites",
    description: "Reset Invites",
    options: [
        {
            name: "user",
            description: "User",
            type: "USER",
            required: false
        }
    ],
    
    run: async (client, interaction) => {
        if (!interaction.member.permissions.has('ADMINISTRATOR')) return interaction.reply({ embeds: [new MessageEmbed()
            .setAuthor(`You dont have permission`, interaction.user.displayAvatarURL({dynamic:true})) 
            .setDescription(`You Want Administrator permissions to use this Command`)
            .setColor(`#56089e`)] }).then(msg => setTimeout(() => {
                  interaction.deleteReply()
                }, client.config.message_remove_time*1000))
        if (!interaction.options.get('user')) {
            let data = await InviteModel.find({
              guildID: interaction.guild.id
            })
            data.forEach(async (d) => {
              let a = await InviteModel.findByIdAndDelete(d._id)
            })
            const mBed = new MessageEmbed()
              .setAuthor(interaction.guild.name, interaction.user.displayAvatarURL({dynamic:true})) 
              .setColor(`#56089e`)
              .setDescription("Server Invites Are Cleared.")
            interaction.reply({
              embeds: [mBed]
            }).then(msg => setTimeout(() => {
                  interaction.deleteReply()
                }, client.config.message_remove_time*1000))
          } else {
            const user = interaction.options.get('user').user
            let data = await InviteModel.findOneAndDelete({
                guildID: interaction.guild.id,
                userID: user.id
            });
            const mBed = new MessageEmbed()
              .setAuthor(user.username, interaction.user.displayAvatarURL({dynamic:true})) 
              .setColor(`#56089e`)
              .setDescription("User Invites Are Cleared.")
            interaction.reply({
              embeds: [mBed]
            }).then(msg => setTimeout(() => {
                  interaction.deleteReply()
                }, client.config.message_remove_time*1000))
          }
    }
}


