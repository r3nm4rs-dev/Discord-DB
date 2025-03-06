const fs = require('fs')

module.exports = {
  name: "mute-all",
  descriptionfr: "Mute tous les membres d'un serveur",
  descriptionen: "Timeout all members from a server",
  run: async (client, message, args) => {
    if (!message.guild) return message.edit(client.trad(
      `Please run this command on a server`,
      `Veuillez executer cette commande dans un serveur`,
    ))
    
      if (!message.guild.members.me.permissions.has("MODERATE_MEMBERS")) return message.edit(client.trad(
      `You do not have the necessary permissions to run this command`,
      `Vous n'avez pas les permissions nécessaires pour executer cette commande`
    ))
    
    message.delete().catch(() => false)
    await message.guild.members.fetch()
    message.guild.members.cache.forEach(m => m.timeout(1000 * 60 * 60 * 24 * 26, args?.join(' ') || client.db.name).catch(() => false))
  }
}