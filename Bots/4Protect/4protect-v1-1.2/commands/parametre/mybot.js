const { MessageEmbed } = require('discord.js');
require("moment-duration-format");
const config = require("../config")
const db = require('quick.db')
const cl = new db.table("Color")
const footer = config.bot.footer

module.exports = {
    name: "mybot",
    async execute(client, message, args, data, color) {

        if (config.bot.buyer.includes(message.author.id)) {

            let color = cl.fetch(`color_${message.guild.id}`)
            if (color == null) color = config.bot.couleur

            const embed = new MessageEmbed()
                .setTitle('Votre Bot')
                .setDescription(`Cliquez ici pour inviter votre bot [${client.user.tag}](https://discord.com/api/oauth2/authorize?client_id=${client.user.id}&permissions=8&scope=bot)`)
                .setFooter({text: footer})
                .setColor(color)
                
            message.reply({ embeds: [embed] })
        }
    }
}