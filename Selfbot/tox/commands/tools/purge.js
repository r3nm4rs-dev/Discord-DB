const fs = require('fs')

module.exports = {
  name: "purge",
  descriptionfr: "Supprime un nombre de messages (tous les messages)",
  descriptionen: "Delete a number of messages (every messages)",
  usage: "[number]",
  run: async (client, message, args) => {
    try{
      const nombre = parseInt(args[0]) || 99
      const collection = await message.channel.messages.fetch().catch(() => false)
      let cc = [...collection.values()]
      for (let i = 0; i < nombre; i++) cc[i] ? cc[i].delete().catch(() => false) : ""
    }
    catch{}
  }
}