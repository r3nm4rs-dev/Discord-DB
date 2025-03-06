const fs = require('fs')

module.exports = {
  name: "rose",
  descriptionfr: "Colore ton texte en rose",
  descriptionen: "Color your text to pink",
  usage: "<text>",
  run: async (client, message, args) => {
    if (!args[0]) return message.edit(client.trad("Please provide a text", "Veuillez envoyer un texte"))
    message.delete().catch(() => false)
    message.channel.send(`\`\`\`ansi\n[2;35m${args.join(' ')}\`\`\``)
  }
}