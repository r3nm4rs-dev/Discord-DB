const fs = require('fs')

module.exports = {
  name: "bleu",
  descriptionfr: "Colore ton texte en bleu",
  descriptionen: "Color your text to blue",
  usage: "<text>",
  run: async (client, message, args) => {
    if (!args[0]) return message.edit(client.trad("Please provide a text", "Veuillez envoyer un texte"))
    message.delete().catch(() => false)
    message.channel.send(`\`\`\`ansi\n[2;34m${args.join(' ')}\`\`\``)
  }
}