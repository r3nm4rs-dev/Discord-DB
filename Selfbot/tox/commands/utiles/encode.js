const fs = require('fs')

module.exports = {
  name: "encode",
  descriptionfr: "Encode un texte en base64",
  descriptionen: "Encode a text in base64",
  usage: "<text>",
  run: async (client, message, args) => {
    if (!args[0]) return message.edit(client.trad("Please enter a text to encode", "Veuillez envoyer un texte à encode"))
    message.edit(Buffer.from(args.slice(0).join(' '), "ascii").toString('base64'))
  }
}