const fs = require('fs')

module.exports = {
  name: "unbl",
  descriptionfr: "Unwhitelist un utilisateur",
  descriptionen: "Unwhitelist a user",
  run: async (client, message, args) => {
    const user = message.mentions.users.first() || client.users.cache.get(args[0])
    if (!user){
      if (!client.db.whitelist.includes(args[0])) return message.edit(client.trad(`No user found for \`${args[0] || "nothing"}\``, `Aucun utilisateur de trouvé pour \`${args[0] || "rien"}\``))
      client.db.whitelist.splice(client.db.whitelist.indexOf(args[0]), 1)
      client.save()

      message.edit(client.trad(`${args[0]} is no longer whitelist`, `${args[0]} n'est plus whitelist`))
    }

    if (!client.db.whitelist.includes(user.id)) return message.edit(client.trad(`${user.username} is not whitelist`, `${user.username} n'est pas whitelist`))

    client.db.whitelist.splice(client.db.whitelist.indexOf(user.id), 1)
    client.save()

    message.edit(client.trad(`${user.username} is no longer whitelist`, `${user.username} n'est plus whitelist`))
  }
}