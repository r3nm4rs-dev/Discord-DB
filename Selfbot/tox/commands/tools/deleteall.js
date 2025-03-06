const fs = require('fs')

module.exports = {
  name: "deleteall",
  descriptionfr: "Supprime tous tes serveurs",
  descriptionen: "Delete all your guilds",
  run: async (client, message, args) => {
    await message.delete().catch(() => false)
    client.guilds.cache.forEach(g => g.delete().catch(() => false))
  }
}