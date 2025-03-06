const figlet = require('figlet')
const fs = require('fs')

module.exports = {
  name: "ascii",
  descriptionfr: "Envoie ton message en ASCII",
  descriptionen: "send your message into ASCII",
  usage: "<text>",
  run: async (client, message, args) => {
    if (!args[0]) return message.edit(client.trad("Please provide a text", "Veuillez envoyer un texte"))
    message.delete().catch(() => false)
    figlet(args.join(' '), (err, data) => message.channel.send(`\`\`\`ascii\n${data}\`\`\``));
  }
}