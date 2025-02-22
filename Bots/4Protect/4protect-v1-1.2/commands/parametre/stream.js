const Discord = require("discord.js");
const config = require("../config");
const db = require('quick.db');

function sleep(ms) {
    return new Promise((resolve) => {
        setTimeout(resolve, ms);
    });
}

module.exports = {
    name: 'stream',
    usage: 'stream <statut>',
    description: `Permet de changer le statut du bot.`,
    async execute(client, message, args) {

        if (config.bot.buyer.includes(message.author.id)) {

            if (!message.guild) return;

            if (args.length) {
                let str_content = args.join(" ");
                client.user.setPresence({
                    activities: [{
                        name: `${str_content}`,
                        type: "STREAMING",
                        url: "https://twitch.tv/4wipyk"
                    }],
                    status: "online"
                });
            }
        }
    }
};
