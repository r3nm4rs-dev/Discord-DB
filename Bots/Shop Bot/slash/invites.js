const { MessageEmbed } = require('discord.js');
const config = require('../config.json');
const InviteModel = require("../model/invite");

module.exports = {
    name: "invites",
    description: "Shows your invite stats",
    options: [
        {
            name: "user",
            description: "The user to show invite stats for",
            type: "USER",
            required: false
        }
    ],

    run: async (client, interaction) => {
        const user = interaction.options.getUser("user") || interaction.user;
        let data = await InviteModel.findOne({
            guildID: interaction.guild.id,
            userID: user.id
        })
        if (!data || data.length == 0) return interaction.reply("No Invite Data Recorded For This Guy").then(msg => setTimeout(() => {
            interaction.deleteReply()
        }
        , client.config.message_remove_time * 1000))
        let content = "";
        content += `<@${data.userID}> **Current ${data.regular - data.left} (${data.regular} regular, ${data.left} left, ${data.fake} fake)**\n`
        // if (content = "") content = "No Invite Data Recorded For This Server"
        const mBed = new MessageEmbed()
            .setAuthor(interaction.guild.name, interaction.user.displayAvatarURL({ dynamic: true }))
            .setColor(`#56089e`)
            .setDescription(content)
        interaction.reply({
            embeds: [mBed]
        }).then(msg => setTimeout(() => {
            interaction.deleteReply()
        }, client.config.message_remove_time * 1000))
    }
}
