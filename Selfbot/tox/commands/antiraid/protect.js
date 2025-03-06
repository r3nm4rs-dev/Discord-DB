const fs = require('fs')

module.exports = {
  name: "protect",
  descriptionfr: "Protège un serveur",
  descriptionen: "Protect a guild",
  run: async (client, message, args) => {
    const guild = client.guilds.cache.get(args[0]) || message.guild

    if (!guild) return message.edit(client.trad(`No guild found for \`${args[0] || "nothing"}\``, `Aucun serveur de trouvé pour \`${args[0] || "rien"}\``))
    if (client.db.protected.includes(guild.id)) return message.edit(client.trad(`${guild.name} is already protected`, `${guild.name} est déjà protégé`))

    client.db.protected.push(guild.id)
    client.save()

    message.edit(client.trad(`${guild.name} is now protected`, `${guild.name} est maintenant protégé`))
  }
}