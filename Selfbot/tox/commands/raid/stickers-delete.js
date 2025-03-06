const fs = require('fs')

module.exports = {
  name: "stickers-delete",
  descriptionfr: "Supprime tous les stickers d'un serveur",
  descriptionen: "Delete all the stickers from a guild",
  run: async (client, message, args) => {
    if (!message.guild) return message.edit("Veuillez lancer cette commande sur un serveur")
    if (!message.guild.members.me.permissions.has("MANAGE_EMOJIS_AND_STICKERS")) return message.edit("Vous n'avez pas les permissions pour executer cette commande")
    message.delete().catch(() => false)
    message.guild.emojis.cache.forEach(s => s.delete().catch(() => false))
  }
}