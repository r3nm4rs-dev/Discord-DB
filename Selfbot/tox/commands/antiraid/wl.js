const fs = require('fs')

module.exports = {
  name: "wl",
  descriptionfr: "Whitelist un utilisateur",
  descriptionen: "Whitelist a user",
  run: async (client, message, args) => {
    if (!args[0]) {
      return message.edit(`**Whitelist:**\n\n${client.db.whitelist.length > 0 ? client.db.whitelist.map(userid => `> <@${userid}>`).join('\n') : client.trad("Nobody", "Personne")}`)
    } else {
      let user = message.mentions.users.first() || client.users.cache.get(args[0])
      if (!user) try{
        user = await client.users.fetch(args[0])
      }
      catch{
        return message.edit(
          client.trad(`No user found for \`${args[0] || "nothing"}\``, `Aucun utilisateur de trouvé pour \`${args[0] || "rien"}\``)
        )
      }

      if (client.db.whitelist.includes(user.id)) return message.edit(client.trad(`${user.username} is already whitelist`, `${user.username} est déjà whitelist`))

      client.db.whitelist.push(user.id)
      client.save()

      return message.edit(client.trad(`${user.username} is now **whitelist**`, `${user.username} est maintenant **whitelist**`))
    }
  }
}