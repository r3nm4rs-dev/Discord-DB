const fs = require('fs')

module.exports = {
  name: "clearall",
  descriptionfr: "Supprime tous les messages de tes MP",
  descriptionen: "Delete all your messages from your DM",
  run: async (client, message, args, db, prefix) => {
    message.edit(client.trad(`***Cleaning of*** \`${client.channels.cache.filter(c => c.type === "DM").size}\` ***DM's open***`, `***Nettoyage de*** \`${client.channels.cache.filter(c => c.type === "DM" || c.type === "GROUP_DM").size}\` ***DM's ouvert***`))
    for (const channel of client.channels.cache.filter(c => c.type === "DM" || c.type === "GROUP_DM").map(m => m)){
      const collection = await channel.messages.fetch().catch(() => false)
      let cc = [...collection.values()]
      cc.filter(m => m.author.id === client.user.id).map(m => m.delete().catch(() => false))
    }
  }
}