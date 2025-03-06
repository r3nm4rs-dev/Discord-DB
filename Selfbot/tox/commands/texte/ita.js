const fs = require('fs')

module.exports = {
  name: "ita",
  descriptionfr: "Met ton texte en italique",
  descriptionen: "Put your text in italic",
  usage: "<text>",
  run: async (client, message, args) => {
    if (!args[0]) return message.edit(client.trad("Please provide a text", "Veuillez envoyer un texte"))
    message.delete().catch(() => false)
    message.channel.send(`*${args.join(' ')}*`)
  }
}