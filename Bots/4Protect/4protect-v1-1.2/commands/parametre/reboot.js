const Discord = require("discord.js")
const db = require('quick.db')
const config = require("../config")
 

module.exports = {
    name: 'reboot',
    usage: 'reboot',
    description: `Permet de redémarrer le bot.`,
    async execute(client, message, args) {

        if (config.bot.buyer.includes(message.author.id)) {

            message.channel.send(`ℹ️ Reboot en cours ...`).then(async message => {
                message.edit(`ℹ️ Reboot en cours ...`)
                client.destroy();
                await client.login(process.env.token);
                await message.edit(`ℹ️ Reboot en cours ...`)
                message.edit(`ℹ️ Reboot terminé`)

            })
        }
    }
}
