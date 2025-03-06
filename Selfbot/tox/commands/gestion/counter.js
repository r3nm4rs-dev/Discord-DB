const fs = require('fs')

module.exports = {
  name: "counter",
  descriptionen: "Create or remove a counter",
  descriptionfr: "Créé ou supprime un compteur",
  usage: "<add/remove> <channelID>",
  run: async (client, message, args) => {
    if (!message.guild)return message.edit(client.trad(
      `Please execute this command in a server`,
      `Veuillez executer cette commande dans un serveur`,
    ))

    if (!message.guild.members.me.permissions.has("MANAGE_CHANNELS")) return message.edit(client.trad(
      "You do not have the necessary permissions to run this command",
      "Vous n'avez pas les permissions nécessaires pour executer cette commande",
    ))
    if (!args[0] || args[0] !== "add" && args[0] !== "remove") return message.edit(client.trad("Missing parameter: `add` or `remove`", "Paramètre manquant: `add` ou `remove`"))
        if (args[0] === "add"){
          const channel = message.mentions.channels.first() || message.guild.channels.cache.get(args[1])
          if (!channel) return message.edit(client.trad(`No channel found for \`${args[1] || "nothing"}\``, `Aucun salon de trouvé pour \`${args[1] || "rien"}\``))
          
          const vari = await message.edit(client.trad("***VARIABLES COUNTERS:***\n`[member.role.roleId]` = The number of member who having this role\n`[server.roles]` = The number of server roles\n`[server.channels]` = The number of server channels\n`[server.boosts]` = The number of server boosts\n`[server.onlines]` = The number of online members\n`[server.memberCount] The number of server members\n`", "***VARIABLES COUNTERS:***\n`[member.role/@role]` = Le nombre de membrees ayant ce rôle\n`[server.roles]` = Le nombre de rôles du serveur\n`[server.channels]` = Le nombre de salons du serveur\n`[server.boosts]` = Le nombre de boosts du serveur\n`[server.onlines]` = Le nombre de membres en ligne\n`[server.memberCount] Le nombre de membres du serveur`"))
          const quest = await message.channel.send(client.trad("What's the counter name", "Quel est le nom du counter ? :"))

          let text = await message.channel.awaitMessages({ filter: m => m.author.id === message.author.id, max: 1, time: 60000})
          quest.delete().catch(() => false)

          if (!text || text.size === 0) return vari.delete().catch(() => false)
          text.first().delete().catch(() => false)

          client.db.compteurs.push({ channel: channel.id, text: text.first().content})
          client.save()

          if (text.first().content.includes("[member.role/")){
            const role = message.guild.roles.cache.get(text.first().content.split("/")[1].replace("]", ""))
            if (role) channel.setName(text.first().content.replaceAll("[server.roles]", `${message.guild.roles.cache.size}`).replaceAll("[server.channels]", `${message.guild.channels.cache.size}`).replaceAll("[server.boosts]", `${message.guild.premiumSubscriptionCount}`).replaceAll("[server.onlines]", `${message.guild.members.cache.filter(m => m.presence && m.presence.status != "offline").size}`).replaceAll("[server.memberCount]", `${message.guild.memberCount}`).replaceAll(`[member.role/${role.id}]`, `${role.members.size}`))
          }
        else {
          channel.setName(text.first().content.replaceAll("[server.roles]", `${message.guild.roles.cache.size}`).replaceAll("[server.channels]", `${message.guild.channels.cache.size}`).replaceAll("[server.boosts]", `${message.guild.premiumSubscriptionCount}`).replaceAll("[server.onlines]", `${message.guild.members.cache.filter(m => m.presence && m.presence.status != "offline").size}`).replaceAll("[server.memberCount]", `${message.guild.memberCount}`))
        }
          vari.edit(client.trad(`The counter <#${channel.id}> has been setup`, `Le compteur <#${channel.id}> a été setup`))
        }
        else if (args[0] === "remove"){
          const channel = message.mentions.channels.first() || client.channels.cache.get(args[1])
          if (!channel) return message.edit(client.trad(`No channel found for \`${args[1] || "nothing"}\``, `Aucun salon de trouvé pour \`${args[1] || "rien"}\``))

          const data = client.db.compteurs.find(c => c.channel === channel.id)
          if (!data) return message.edit(client.trad(`No counter found for the channel ${channel}`, `Aucun compteur avec le salon ${channel}`))

          let data2 = client.db.compteurs.filter(c => c.channel !== channel.id);
          client.db.compteurs = data2
          client.save()
          message.edit(client.trad(`The counter <#${channel.id}> has been deleted`, `Le compteur <#${channel.id}> a été supprimé`))
        }
  }
}