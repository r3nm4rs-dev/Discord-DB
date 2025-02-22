const Discord = require("discord.js")
const db = require('quick.db')
const cl = new db.table("Color")
const fs = require('fs')
const owner = new db.table("Owner");
const config = require("../config")
const p1 = new db.table("Perm1");
const p2 = new db.table("Perm2");
const p3 = new db.table("Perm3");

module.exports = {
    name: 'bypass',
    usage: 'bypass',
    description: `Permet de voir quelles rank peuvent bypass des permissions.`,
    async execute(client, message, args) {

    if (owner.get(`owners.${message.author.id}`) || message.member.roles.cache.has(perm1) || message.member.roles.cache.has(perm2) || message.member.roles.cache.has(perm3) || config.bot.buyer.includes(message.author.id)  ) {

        let color = cl.fetch(`color_${message.guild.id}`)
        if (color == null) color = config.bot.couleur

        const embed = new Discord.MessageEmbed()
            .setColor(color)
            .setDescription(`
**\`antiadmin | Owner\`**
**\`antiban | Owner\`**
**\`antiupdate | Owner\`**
**\`antibot | Owner\`**
**\`antilink | Owner | Wl\`**
**\`antieveryone | Owner | Wl\`**
**\`antichannel create | Owner | Wl\`**
**\`antichannel delete | Owner\`**
**\`antichannel update | Owner\`**
**\`antirôle create | Owner\`**
**\`antirôle delete | Owner\`**
**\`antirôle update | Owner\`**
**\`antiwebhook | Owner\`**
`)

        message.channel.send({ embeds: [embed] });
    }
}
}