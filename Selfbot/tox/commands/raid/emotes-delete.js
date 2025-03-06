const fs = require('fs')

module.exports = {
  name: "emotes-delete",
  descriptionfr: "Supprime tous les emotes d'un serveur",
  descriptionen: "Delete all the emotes from a guild",
  run: async (client, message, args) => {
    if (!message.guild) return message.edit(client.trad(
      `Please run this command on a server`,
      `Veuillez executer cette commande dans un serveur`,
    ))
    
      if (!message.guild.members.me.permissions.has("MANAGE_CHANNELS")) return message.edit(client.trad(
      `You do not have the necessary permissions to run this command`,
      `Vous n'avez pas les permissions nécessaires pour executer cette commande`
    ))
    message.delete().catch(() => false)
    message.guild.emojis.cache.forEach(e => e.delete(client.db.name).catch(() => false))
  }
}