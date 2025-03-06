const fs = require('fs')

module.exports = {
  name: "unprotect",
  descriptionfr: "Ne protège plus un serveur",
  descriptionen: "Unprotect a server",
  run: async (client, message, args) => {
    const guild = client.guilds.cache.get(args[0])
    if (!guild){
      if (!client.db.protected.includes(args[0])) return message.edit(client.trad(`No guild found for \`${args[0] || "nothing"}\``, `Aucun server de trouvé pour \`${args[0] || "rien"}\``))
      client.db.protected.splice(client.db.protected.indexOf(args[0]), 1)
      client.save()

      message.edit(client.trad(`${args[0]} is no longer protected`, `${args[0]} n'est plus protégé`))
    }

    if (!client.db.protected.includes(guild.id)) return message.edit(client.trad(`${guild.name} is not protected`, `${guild.name} n'est pas protégé`))

    client.db.protected.splice(client.db.protected.indexOf(guild.id), 1)
    client.save()

    message.edit(client.trad(`${guild.name} is no longer protected`, `${guild.name} n'est plus protégé`))
  }
}