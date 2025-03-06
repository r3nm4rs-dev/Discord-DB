const fs = require('fs')

module.exports = {
  name: "memberinfo",
  descriptionfr: "Affiche les informations d'un membre",
  descriptionen: "Display the informations from a member",
  usage: "[member]",
  run: async (client, message, args) => {
    if (!message.guild)return message.edit(client.trad(
      `Veuillez executer cette commande dans un serveur`,
      `Please execute this command in a server`
    ));

    let member = message.mentions.members.first() || message.guild.members.cache.get(args[0])
    if (!member) try{
      member = await message.guild.members.fetch(args[0])
    }
    catch{
      member = message.author
    }

    const nitro = nitrot => {
      switch(nitrot){
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

    const mutualfriends = await member.user.mutualFriends
    await member.fetch()
    
    message.edit(client.trad(
      `> __**⛧ ${client.db.name} INFOS ⛧**__
\`Nickname\` ➜ **${member.nickname ? member.nickname : "No nickname"}**
\`Username\` ➜ **${member.user.username}**
\`ID\` ➜ **${member.user.id}**
\`Bot\` ➜ **${member.user.bot ? "Yes" : "No"}**
\`Nitro\` ➜ **${nitro(member.user.nitroType).replace("Pas de nitro", "No Nitro")}**
\`Connections\` ➜ **${member.user.connectedAccounts.length > 0 ? member.user.connectedAccounts.map(user => user.type).join(', ') : "Pas de connexion trouvée"}**
\`Account Created\` ➜ **<t:${Math.round(member.user.createdAt / 1000)}:R>**
\`Member Joined\` ➜ **<t:${Math.round(member.joinedAt / 1000)}:R>**
\`Rôles\` ➜ **${member.roles.cache.length > 0 ? member.roles.cache.map(r => `<@&${r}>`).join(', ') : "No role"}**
\`Mutual Friends\` ➜ **${mutualfriends.size > 0 ? mutualfriends.map(u => u.username).join(', ') : "No mutual friend"}**
\`Banner\` ➜ **${member.banner ? member.bannerURL({dynamic: true, size: 4096}) : user.accentColor} **
\`Décoration\` ➜ **${member.avatarDecoration ? member.avatarDecorationURL() : "No Decoration"} **
\`About Me\` ➜ ${member.bio ? member.bio : "**No Bio**"}`,
      `> __**⛧ ${client.db.name} MEMBERINFOS ⛧**__
\`Surnom\` ➜ **${member.nickname ? member.nickname : "Pas de surnom"}**
\`Pseudo\` ➜ **${member.user.username}**
\`ID\` ➜ **${member.user.id}**
\`Bot\` ➜ **${member.user.bot ? "Oui" : "Non"}**
\`Nitro\` ➜ **${nitro(member.user.nitroType)}**
\`Connexions\` ➜ **${member.user.connectedAccounts.length > 0 ? member.user.connectedAccounts.map(user => user.type).join(', ') : "Pas de connexion trouvée"}**
\`Compte Créé\` ➜ **<t:${Math.round(member.user.createdAt / 1000)}:R>**
\`Rejoint le serveur\` ➜ **<t:${Math.round(member.joinedAt / 1000)}:R>**
\`Rôles\` ➜ **${member.roles.cache.length > 0 ? member.roles.cache.map(r => `<@&${r}>`).join(', ') : "Pas de rôle"}**
\`Amis en communs\` ➜ **${mutualfriends.size > 0 ? mutualfriends.map(u => u.username).join(', ') : "Aucun amis en commun"}**
\`Avatar\` ➜ **${member.avatar ? member.avatarURL({dynamic: true, size: 4096}) : user.accentColor} **
\`Bannière\` ➜ **${member.banner ? member.bannerURL({dynamic: true, size: 4096}) : "Pas de bannière"} **
\`Décoration\` ➜ **${member.avatarDecoration ? member.avatarDecorationURL() : "Pas de décoration"} **
\`Bio\` ➜ ${member.user.bio ? member.user.bio : "**Pas de bio**"}`,
    ))
  }
}