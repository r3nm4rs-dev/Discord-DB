const Discord = require("discord.js")
const db = require('quick.db')
const owner = new db.table("Owner")
const cl = new db.table("Color")
const ml = new db.table("modlog")
const config = require("../config")
const fs = require('fs')
const moment = require('moment')
const p3 = new db.table("Perm3")

module.exports = {
    name: 'hide',
    usage: 'hide',
    description: `Permet de cacher un salon`,
    async execute(client, message, args, color) {

        const perm3 = p3.fetch(`perm3_${message.guild.id}`)

            let ecolor = cl.fetch(`color_${message.guild.id}`)
            if (ecolor == null) color = config.bot.couleur


            if (owner.get(`owners.${message.author.id}`) || message.member.roles.cache.has(perm3) || config.bot.buyer.includes(message.author.id)   === true) {
                let channel = message.mentions.channels.first() || message.guild.channels.cache.get(args[0]) || message.channel

                        channel.permissionOverwrites.edit(message.guild.id, {
                            VIEW_CHANNEL: false,
                        });
                message.channel.send(`Les membres ne peuvent plus voir le salon <#${channel.id}>`);
                message.delete();
            }

            const embed = new Discord.MessageEmbed()
                .setColor(ecolor)
                .setDescription(`<@${message.author.id}> a utilisé la commande \`hide\` le salon <#${message.channel.id}>`)
                .setTimestamp()
                .setFooter({ text: `📚` })
            const modlog = client.channels.cache.get(ml.get(`${message.guild.id}.modlog`))
            if (modlog) modlog.send({ embeds: [embed] }).catch(() => false)
    }
}