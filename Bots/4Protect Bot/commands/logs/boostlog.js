const { MessageEmbed } = require('discord.js')
const Discord = require('discord.js')
const db = require('quick.db')
const config = require("../../config")
const owner = new db.table("Owner")
const boostlog = new db.table("boostlog")
const cl = new db.table("Color")
const footer = config.bot.footer
 


module.exports = {
    name: 'boostlog',
    usage: 'boostlog <id>',
    description: `Permet de changer le salon des logs.`,
    async execute(client, message, args) {

        if (owner.get(`owners.${message.author.id}`) || config.bot.buyer.includes(message.author.id)   === true) {

            let color = cl.fetch(`color_${message.guild.id}`)
            if (color == null) color = config.bot.couleur

            const newChannel = message.mentions.channels.first() || message.guild.channels.cache.get(args[0] || message.channelId);
            if (args[0] == undefined) args[0] = `<#${message.channel.id}>`
            if (!newChannel) return message.channel.send({ content: "Aucun salon trouvé !" })
            if (boostlog.get(`${message.guild.id}.boostlog`) === newChannel) return message.channel.send(`🔮・__Nouveau salon des logs boost :__ \`${boostlog.get(`${message.guild.id}.boostlog`)}\``)
            else {
                boostlog.set(`${message.guild.id}.boostlog`, newChannel.id)
                message.channel.send(`🔮・__Nouveau salon des logs boost :__ ${args[0]}`)

                const logs = boostlog.get(`${message.guild.id}.boostlog`)

                const embed = new Discord.MessageEmbed()
                    .setColor(color)
                    .setTitle(`${message.author.tag} a défini ce salon commme salon des logs boost`)
                    .setDescription(`🔮 Ce salon est désormais utilisé pour __toutes__ les **logs boost** du serveur\nExécuteur : <@${message.author.id}>`)
                    .setTimestamp()
                    .setFooter({ text: `${footer}` })
                client.channels.cache.get(logs).send({ embeds: [embed] }).catch(() => false)
            }
        }
    }
}
