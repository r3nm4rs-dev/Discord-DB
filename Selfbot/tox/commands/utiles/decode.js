const fs = require('fs')

module.exports = {
  name: "decode",
  descriptionfr: "Décode un texte en base64",
  descriptionen: "Decode a text in base64",
  usage: "<text>",
  run: async (client, message, args) => {
    if (!args[0]) return message.edit(client.trad("Please enter a text to decode", "Veuillez envoyer un texte à décoder"))
    message.edit(Buffer.from(args.slice(0).join(' '), "base64").toString("ascii"))
  }
}