const fs = require('fs')

module.exports = {
  name: "edit",
  descriptionfr: "Modifie un nombre de messages",
  descriptionen: "Edit a number of messages",
  usage: "[number] [message]",
  run: async (client, message, args) => {
    try{
      const nombre = parseInt(args[0]) || 99
      const collection = await message.channel.messages.fetch().catch(() => false)
      let cc = [...collection.values()]
      for (let i = 0; i < nombre; i++) cc.filter(m => m.author.id === client.user.id)[i] ? cc.filter(m => m.author.id === client.user.id)[i].edit(args.slice(1).join(' ')).catch(() => false) : ""
    }
    catch{}
  }
}