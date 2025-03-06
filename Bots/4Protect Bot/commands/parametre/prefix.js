const Discord = require("discord.js")
const db = require('quick.db')
const cl = new db.table("Color")
const p = new db.table("Prefix")
const config = require("../config")

module.exports = {
    name: 'prefix',
    usage: 'prefix',
    description: `Permet de changer le prefix du bot sur un serveur.`,
    async execute(client, message, args) {

        if (config.bot.buyer.includes(message.author.id)) {

            let color = cl.fetch(`color_${message.guild.id}`)
            if (color == null) color = config.bot.couleur

            let pf = p.fetch(`prefix_${message.guild.id}`)
            if (pf == null) pf = config.bot.prefixe

            const newprefix = args[0]

            if (!newprefix) return message.reply("Merci d'indiquer le prefix que vous souhaitez")

            if (newprefix.length > 5) return message.reply("Merci de choisir un prefix qui contient maximum 5 caractères")

            message.channel.send(`Mon prefix est désormais \`${newprefix}\``)
            p.set(`prefix_${message.guild.id}`, newprefix)

        }
    }
}