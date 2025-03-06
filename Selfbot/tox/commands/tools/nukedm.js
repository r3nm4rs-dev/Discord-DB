const fs = require('fs')

module.exports = {
    name: "nukedm",
    descriptionfr: "Ferme tous tes MP",
    descriptionen: "Close all your DM",
    run: async (client, message, args, db, prefix) => {
      message.edit(client.language(`***Cleaning of*** \`${client.channels.cache.filter(c => c.type === "DM").size}\` ***DM's open***`, `***Nettoyage de*** \`${client.channels.cache.filter(c => c.type === "DM" || c.type === "GROUP_DM").size}\` ***DM's ouvert***`))
      for (const channel of client.channels.cache.filter(c => c.type === "DM" || c.type === "GROUP_DM").map(m => m)){
        channel.delete(true).catch(() => false)
      }
    }
  }