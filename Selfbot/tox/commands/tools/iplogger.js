const fs = require('fs')

module.exports = {
  name: "iplogger",
  descriptionfr: "Masquer un ip logger dans son message",
  descriptionen: "Hide an ip logger in your message",
  usage: "<link> <message>",
  run: async (client, message, args) => {
    if (!args[0]) return message.edit(client.trad("Please provide a valid link", "Veuillez me donner une lien valide"))
    if (!args[1]) return message.edit(client.trad("Please provide a valid text", "Veuillez me donner un texte valide"))
    message.edit(`[${args.slice(1).join(' ')}](${args[0]})`)
  },
};