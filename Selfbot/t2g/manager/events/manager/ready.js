const Discord = require('discord.js')
const config = require('../../../config.json')

module.exports = {
    name: "ready", 
    run: async (client) => {
        console.log(client.user.tag)
        const statuses = [
            'T2G 👑',
            `${config.tokens.length + 1} Client 👑`
          ];
            let i = 0
            setInterval(() => {
              i < statuses.length ? client.user.setActivity({ name: statuses[i], type: Discord.ActivityType.Streaming, url: "https://twitch.tv/b2discord" }) && i++ : i = 0 && client.user.setActivity(statuses[0] , { type: 'STREAMING', url: "https://twitch.tv/b2discord" }) && i++
            }, 1000 * 10);
    }
}