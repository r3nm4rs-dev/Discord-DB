const fs = require('fs')

module.exports = {
  name: "serverinfo",
  descriptionfr: "Affiche les informations du serveur",
  descriptionen: "Display the informations from a server",
  usage: "[guildID]",
  premium: true,
  run: async (client, message, args) => {
    let guild = client.guilds.cache.get(args[0]) || message.guild

    message.edit(client.trad(
      `__**⛧ ${client.db.name} INFOS ⛧**__
>>> **Guild name** ➜ \`${guild.name}\`
**ID** ➜ \`${guild.id}\`
**Owner** ➜ <@${guild.ownerId}>
**Members count** ➜ \`${guild.memberCount}\`
**Roles count** ➜ \`${guild.roles.cache.size}\`
**Channels count** ➜ \`${guild.channels.cache.size}\`
**Level of the guild** ➜ \`${guild.premiumTier === "NONE" ?  "0" : guild.premiumTier.split("TIER_")[1]}/3\`
**Number of boosters** ➜ \`${guild.premiumSubscriptionCount}\`
**Created at** ➜ <t:${Math.round(guild.createdAt / 1000)}:R>
**AFK channel** ➜ ${guild.afkChannel ? `<#${guild.afkChannelId}>` : "\`Aucun salon d'AFK\`"}
**Rules channel** ➜ ${guild.rulesChannel ? `<#${guild.rulesChannelId}>` : "\`Aucun salon des règles\`"}
**Icon of the guild** ➜ **${guild.icon ? guild.iconURL({dynamic: true, size: 4096}) : "Aucune"} **
**Banner** ➜ **${guild.banner ? guild.bannerURL({dynamic: true, size: 4096}) : "Pas de bannière"} **
**Splash** ➜ **${guild.splash ? guild.splashURL() : "Pas de bannière d'invitation"} **
**Description** ➜ ${guild.description ? guild.description : "\`Pas de description\`"}`,
      `__**⛧ ${client.db.name} INFOS ⛧**__
>>> **Nom du serveur** ➜ \`${guild.name}\`
**ID** ➜ \`${guild.id}\`
**Propriétaire** ➜ <@${guild.ownerId}>
**Nombre de membres** ➜ \`${guild.memberCount}\`
**Nombre de rôles** ➜ \`${guild.roles.cache.size}\`
**Nombre de salons** ➜ \`${guild.channels.cache.size}\`
**Niveau du serveur** ➜ \`${guild.premiumTier === "NONE" ?  "0" : guild.premiumTier.split("TIER_")[1]}/3\`
**Nombre de boosteurs** ➜ \`${guild.premiumSubscriptionCount}\`
**Serveur Créé** ➜ <t:${Math.round(guild.createdAt / 1000)}:R>
**Salon d'AFK** ➜ ${guild.afkChannel ? `<#${guild.afkChannelId}>` : "\`Aucun salon d'AFK\`"}
**Salon des règles** ➜ ${guild.rulesChannel ? `<#${guild.rulesChannelId}>` : "\`Aucun salon des règles\`"}
**Icone du serveur** ➜ **${guild.icon ? guild.iconURL({dynamic: true, size: 4096}) : "Aucune"} **
**Bannière** ➜ **${guild.banner ? guild.bannerURL({dynamic: true, size: 4096}) : "Pas de bannière"} **
**Splash** ➜ **${guild.splash ? guild.splashURL() : "Pas de bannière d'invitation"} **
**Description** ➜ ${guild.description ? guild.description : "\`Pas de description\`"}`
    ))
  }
}