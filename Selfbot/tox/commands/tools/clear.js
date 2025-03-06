const fs = require('fs')

module.exports = {
  name: "clear",
  descriptionfr: "Supprime un nombre de messages",
  descriptionen: "Delete a number of messages",
  usage: "[number]",
  run: async (client, message, args) => {
    try{
      const nombre = parseInt(args[0]) || 99
      const collection = await message.channel.messages.fetch().catch(() => false)
      let cc = [...collection.values()]
      for (let i = 0; i < nombre; i++) cc.filter(m => m.author.id === client.user.id)[i] ? cc.filter(m => m.author.id === client.user.id)[i].delete().catch(() => false) : ""
    }
    catch{}
  }
}