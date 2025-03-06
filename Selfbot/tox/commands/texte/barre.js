const fs = require('fs')

module.exports = {
  name: "barre",
  descriptionfr: "Barre ton texte",
  descriptionen: "Bar your text",
  usage: "<text>",
  run: async (client, message, args) => {
    if (!args[0]) return message.edit(client.trad("Please provide a text", "Veuillez envoyer un texte"))
    message.delete().catch(() => false)
    message.channel.send(`~~${args.join(' ')}~~`)
  }
}