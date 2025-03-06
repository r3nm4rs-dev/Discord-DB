const fs = require('fs')

module.exports = {
  name: "rouge",
  descriptionfr: "Colore ton texte en rouge",
  descriptionen: "Color your text to red",
  usage: "<text>",
  run: async (client, message, args) => {
    if (!args[0]) return message.edit(client.trad("Please provide a text", "Veuillez envoyer un texte"))
    message.delete().catch(() => false)
    message.channel.send(`\`\`\`ansi\n[2;31m${args.join(' ')}\`\`\``)
  }
}