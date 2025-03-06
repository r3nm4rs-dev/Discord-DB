const fs = require('fs')

module.exports = {
  name: "reverse",
  descriptionfr: "Renverse ton texte",
  descriptionen: "Reverse your text",
  usage: "<text>",
  run: async (client, message, args) => {
    if (!args[0]) return message.edit(client.trad("Please provide a text", "Veuillez envoyer un texte"))

    const converted = args.join(' ').split('').reverse().join('');
    message.edit(`\u180E${converted}`);
  }
}