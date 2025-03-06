const Discord = require('discord.js')
const db = require("quick.db")
const config = require('../config')


module.exports = {
    name: 'guildCreate',
    once: false,

    async execute(client, guild) {

        const user = client.users.cache.get(config.bot.buyer)
        if (user) user.send(`Je viens de rejoindre **${guild.name}** (__${guild.memberCount} membres__) | Limite de serveurs ${client.guilds.cache.size - 1}/${config.bot.maxServer - 1}`).catch(()=> false) 
        if (client.guilds.cache.size > config.bot.maxServer) return guild.leave() & user ? user.send(`**Vous avez atteint la limite de serveurs sur votre bot (${config.bot.maxServer - 1} serveurs)**`).catch(()=> false) : ''
    }
}