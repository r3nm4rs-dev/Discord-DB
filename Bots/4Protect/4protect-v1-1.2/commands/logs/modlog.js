const { MessageEmbed } = require('discord.js')
const Discord = require('discord.js')
const db = require('quick.db')
const config = require("../config")
const owner = new db.table("Owner")
const modlog = new db.table("modlog")
const cl = new db.table("Color")
const footer = config.bot.footer
 


module.exports = {
    name: 'modlog',
    usage: 'modlog <id>',
    description: `Permet de changer le salon des logs de modération.`,
    async execute(client, message, args) {

        if (owner.get(`owners.${message.author.id}`) || config.bot.buyer.includes(message.author.id)   === true) {

            let color = cl.fetch(`color_${message.guild.id}`)
            if (color == null) color = config.bot.couleur

            const newChannel = message.mentions.channels.first() || message.guild.channels.cache.get(args[0] || message.channelId);
            if (args[0] == undefined) args[0] = `<#${message.channel.id}>`
            if (!newChannel) return message.channel.send({ content: "Aucun salon trouvé !" })
            if (modlog.get(`${message.guild.id}.modlog`) === newChannel) return message.channel.send(`ℹ️・__Nouveau salon des logs de modération :__ \`${modlog.get(`${message.guild.id}.modlog`)}\``)
            else {
                modlog.set(`${message.guild.id}.modlog`, newChannel.id)
                message.channel.send(`ℹ️・__Nouveau salon des logs de modération :__ ${args[0]}`)

                const logs = modlog.get(`${message.guild.id}.modlog`)

                const embed = new Discord.MessageEmbed()
                    .setColor(color)
                    .setTitle(`${message.author.tag} a défini ce salon commme salon des logs de modération`)
                    .setDescription(`ℹ️ Ce salon est désormais utilisé pour __toutes__ les **logs de modération** du serveur\nExécuteur : <@${message.author.id}>`)
                    .setTimestamp()
                    .setFooter({ text: `${footer}` })
                client.channels.cache.get(logs).send({ embeds: [embed] }).catch(() => false)
            }
        }
    }
}
