const fs = require('fs')

module.exports = {
  name: "userinfo",
  descriptionfr: "Affiche les informations d'un utilisateur",
  descriptionen: "Display the informations from a user",
  usage: "[user]",
  run: async (client, message, args) => {
    let user = message.mentions.users.first() || client.users.cache.get(args[0])
    if (!user) try{
      user = await client.users.fetch(args[0])
    }
    catch{
      user = message.author
    }

    const nitro = nitrotype => {
      switch(nitrotype){
        case "NONE": return 'Pas de nitro'
        case "UNKNOWN": return '?'
        case "NITRO_BOOST": return "Nitro Boost"
        case "NITRO_BASIC": return "Nitro Basic"
        case "NITRO_CLASSIC": return "Nitro Classic"
      }
    }

    const mutualserveurs = collection => {
      if (collection.size === 0) return "Aucun serveur en commun"
      else return collection.map(guild => guild.name).join(", ")
    }

    const mutualfriends = await user.mutualFriends
    await user.fetch()
    
    message.edit(client.trad(
      `__**⛧ ${client.db.name} INFOS ⛧**__
>>> \`Username\` ➜ **${user.username}**
\`ID\` ➜ **${user.id}**
\`Bot\` ➜ **${user.bot ? "Yes" : "No"}**
\`Nitro\` ➜ **${nitro(user.nitroType).replace("Pas de nitro", "No Nitro")}**
\`Connections\` ➜ **${user.connectedAccounts.length > 0 ? user.connectedAccounts.map(user => user.type).join(', ') : "Pas de connexion trouvée"}**
\`Account Created\` ➜ **<t:${Math.round(user.createdAt / 1000)}:R>**
\`Mutual Friends\` ➜ **${mutualfriends.size > 0 ? mutualfriends.map(u => u.username).join(', ') : "No mutual friend"}**
\`Banner\` ➜ **${user.banner ? user.bannerURL({dynamic: true, size: 4096}) : user.accentColor} **
\`Décoration\` ➜ **${user.avatarDecoration ? user.avatarDecorationURL() : "No Decoration"} **
\`About Me\` ➜ ${user.bio ? user.bio : "**No Bio**"}`,
      `__**⛧ ${client.db.name} INFOS ⛧**__
>>> **Pseudo** ➜ \`${user.username}\`
**ID** ➜ \`${user.id}\`
**Bot** ➜ \`${user.bot ? "Oui" : "Non"}\`
**Nitro** ➜ \`${nitro(user.nitroType)}\`
**Connexions** ➜ \`${user.connectedAccounts.length > 0 ? user.connectedAccounts.map(user => user.type).join(', ') : "Pas de connexion trouvée"}\`
**Compte Créé** ➜ \`<t:${Math.round(user.createdAt / 1000)}:R>\`
**Amis en communs** ➜ \`${mutualfriends.size > 0 ? mutualfriends.map(u => u.username).join(', ') : "Aucun amis en commun"}\`
**Avatar** ➜ \`${user.avatar ? user.avatarURL({dynamic: true, size: 4096}) : user.accentColor} \`
**Bannière** ➜ \`${user.banner ? user.bannerURL({dynamic: true, size: 4096}) : "Pas de bannière"} \`
**Décoration** ➜ \`${user.avatarDecoration ? user.avatarDecorationURL() : "Pas de décoration"} \`
**Bio** ➜ ${user.bio ? user.bio : "\`Pas de bio\`"}`
    ))

  }
}