const fs = require('fs')

module.exports = {
  name: "botsettings",
  descriptionfr: "Affiche les paramètres du bot",
  descriptionen: "Display the settings of the bot",
  run: async (client, message, args) => {
    message.edit(client.trad(
`⛧ __**${client.db.name}**__ ⛧
> ***Actual Prefix*** : \`${client.db.prefix}\` 
> ***Premium User*** : \`${client.premium ? "🟢" : "🔴"}\` 
> ***Actuel Twitch*** : [${client.db.twitch.split("twitch.tv/")[1]}](<${client.db.twitch}>) 
> ***Nitro Sniper*** : \`${client.db.nitrosniper ? "🟢" : "🔴"}\`
> ***Giveaway Sniper*** : \`${client.db.giveawaysniper ? "🟢" : "🔴"}\`
> ***Sequential*** : \`✅\`
> ***Loggin System*** : \`${client.db.logger ? "🟢" : "🔴"}\`
> ***Auto Voice*** : ${client.db.vcconnect ? `<#${client.db.vcconnect}>` : "\`🔴\`"}
> ***Voice Strreaming*** : \`${client.db.streaming ? "🟢" : "🔴"}\`
> ***Voice FaceCam*** : \`${client.db.vocwebcam ? "🟢" : "🔴"}\`
> ***Silent Mode*** : \`${client.db.silentgroup ? "🟢" : "🔴"}\`
 > ***Anti Groups*** : \`${client.db.antigroups ? "🟢" : "🔴"}\`
> ***Anti Pub DM*** : \`${client.db.antipub ? "🟢" : "🔴"}\`
> ***AFK System*** : \`${client.db.afk ? "🟢" : "🔴"}\``,
`⛧ __**${client.db.name}**__ ⛧
> ***Prefix Actuel*** : \`${client.db.prefix}\`
> ***Utilisateur Premium*** : \`${client.premium ? "🟢" : "🔴"}\` 
> ***Twitch Actuel*** : [${client.db.twitch.split("twitch.tv/")[1]}](<${client.db.twitch}>) 
> ***Nitro Sniper*** : \`${client.db.nitrosniper ? "🟢" : "🔴"}\`
> ***Giveaway Sniper*** : \`${client.db.giveawaysniper ? "🟢" : "🔴"}\`
> ***Sequential*** : \`✅\`
> ***Système de Loggin*** : \`${client.db.logger ? "🟢" : "🔴"}\`
> ***Vocaux Automatiques*** : ${client.db.vcconnect ? `<#${client.db.vcconnect}>` : "\`🔴\`"}
> ***Streaming en Vocal*** : \`${client.db.streaming ? "🟢" : "🔴"}\`
> ***Webcam en Vocal*** : \`${client.db.vocwebcam ? "🟢" : "🔴"}\`
> ***Mode Silcencieux*** : \`${client.db.silentgroup ? "🟢" : "🔴"}\`
> ***Anti Groupes*** : \`${client.db.antigroups ? "🟢" : "🔴"}\`
> ***Anti Pub MP*** : \`${client.db.antipub ? "🟢" : "🔴"}\`
> ***Systèm d'AFK*** : \`${client.db.afk ? "🟢" : "🔴"}\``
    ))
  }
}