const fs = require('fs')

module.exports = {
  name: "unbl",
  descriptionfr: "Unblacklist un utilisateur",
  descriptionen: "Unblacklist a user",
  run: async (client, message, args) => {
    const user = message.mentions.users.first() || client.users.cache.get(args[0])
    if (!user){
      if (!client.db.blacklist.includes(args[0])) return message.edit(client.trad(`No user found for \`${args[0] || "nothing"}\``, `Aucun utilisateur de trouvé pour \`${args[0] || "rien"}\``))
      client.db.blacklist.splice(client.db.blacklist.indexOf(args[0]), 1)
      client.save()

      message.edit(client.trad(`${args[0]} is no longer blacklist`, `${args[0]} n'est plus blacklist`))
    }

    if (!client.db.blacklist.includes(user.id)) return message.edit(client.trad(`${user.username} is not blacklist`, `${user.username} n'est pas blacklist`))

    client.db.blacklist.splice(client.db.blacklist.indexOf(user.id), 1)
    client.save()

    message.edit(client.trad(`${user.username} is no longer blacklist`, `${user.username} n'est plus blacklist`))
  }
}