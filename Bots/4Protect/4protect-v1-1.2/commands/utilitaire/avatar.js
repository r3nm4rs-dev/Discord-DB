const Discord = require("discord.js");
const db = require('quick.db');
const cl = new db.table("Color");
const config = require("../../config");

module.exports = {
    name: 'pic',
    aliases: ['avatar'],
    usage: 'pic [membre/ID]',
    description: `Permet d'afficher l'avatar d'un utilisateur.`,
    async execute(client, message, args) {
        let color = cl.fetch(`color_${message.guild.id}`) || config.bot.couleur;

        let member = message.mentions.users.first() || (args[0] ? await client.users.fetch(args[0]).catch(() => null) : null) || message.author;

        if (!member) {
            return message.channel.send("Veuillez mentionner un utilisateur ou fournir un ID valide.");
        }

        let avatar = member.displayAvatarURL({ format: 'png', dynamic: true, size: 1024 });
        let username = member.username;

        const embed = new Discord.MessageEmbed()
            .setTitle(`${username}`)
            .setImage(avatar)
            .setColor(color);

        message.channel.send({ embeds: [embed] });
    }
};