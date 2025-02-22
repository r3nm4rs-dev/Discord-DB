const Discord = require('discord.js');
const config = require("../config");
const db = require('quick.db');
const cl = new db.table("Color");

module.exports = {
    name: 'ping',
    description: `Permet de voir la latence du bot en millisecondes.`,

    async execute(client, message, args) {
        let color = cl.fetch(`color_${message.guild.id}`) || config.bot.couleur;

        const embed = new Discord.MessageEmbed()
            .addField('BOT', `${client.ws.ping} ms`, true)
            .setColor(color);

        const msg = await message.channel.send({ embeds: [embed] });

        const api = msg.createdTimestamp - message.createdTimestamp;
        embed.addField("API", `${api} ms`, true);
        
        msg.edit({ embeds: [embed] });
    }
};