const fs = require('fs')

module.exports = {
  name: "orange",
  descriptionfr: "Colore ton texte en orange",
  descriptionen: "Color your text to orange",
  usage: "<text>",
  run: async (client, message, args) => {
    if (!args[0]) return message.edit(client.trad("Please provide a text", "Veuillez envoyer un texte"))
    message.delete().catch(() => false)
    message.channel.send(`\`\`\`ansi\n[2;33m${args.join(' ')}\`\`\``)
  }
}