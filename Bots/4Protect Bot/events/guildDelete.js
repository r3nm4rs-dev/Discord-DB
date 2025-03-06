const Discord = require('discord.js')
const db = require("quick.db")
const owner = new db.table("Owner")
const config = require('../config')


module.exports = {
    name: 'guildDelete',
    once: false,

    async execute(client, guild) {

        const user = client.users.cache.get(config.bot.buyer)
        if (user) user.send(`Je viens de quitter **${guild.name}** (__${guild.memberCount} membres__) | Limite de serveurs ${client.guilds.cache.size - 1}/${config.bot.maxServer}`).catch(() => false)
    }
}