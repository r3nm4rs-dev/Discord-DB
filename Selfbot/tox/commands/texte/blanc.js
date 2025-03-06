const fs = require('fs')

module.exports = {
  name: "blanc",
  descriptionfr: "Colore ton texte en blanc",
  descriptionen: "Color your text to white",
  usage: "<text>",
  run: async (client, message, args) => {
    if (!args[0]) return message.edit(client.trad("Please provide a text", "Veuillez envoyer un texte"))
    message.delete().catch(() => false)
    message.channel.send(`\`\`\`ansi\n[2;37m${args.join(' ')}\`\`\``)
  }
}