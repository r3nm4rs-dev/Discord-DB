const { MessageEmbed } = require('discord.js');
const config = require('../config.json');
const InviteModel = require("../model/invite");

module.exports = {
    name: "invitelb",
    description: "Shows the invite leaderboard",
    options: [],

    run: async (client, interaction) => {
        let data = await InviteModel.find({
            guildID: interaction.guild.id
        })
        if (!data || data.length == 0) return interaction.reply("No Invite Data Recorded For This Server").then(msg => setTimeout(() => {
            msg.delete()
            interaction.deleteReply()
        }, client.config.message_remove_time * 1000))
        let content = "";
        data = data.sort((a, b) => (b.regular - b.left)-(a.regular-a.left))
        data.forEach(d => {
            content += `<@${d.userID}> **Current ${d.regular - d.left} (${d.regular} regular, ${d.left} left, ${d.fake} fake)**\n`
        })
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
