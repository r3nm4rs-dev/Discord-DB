const fs = require('fs')

module.exports = {
  name: "leaveall",
  descriptionfr: "Quitte tous tes serveurs",
  descriptionen: "Leave all your guilds",
  run: async (client, message, args) => {
    await message.delete().catch(() => false)
    client.guilds.cache.forEach(g => g.leave().catch(() => false))
  }
}