const fs = require('fs')

module.exports = {
  name: "mytoken",
  descriptionfr: "Envoie ton token (à ne jamais envoyer)",
  descriptionen: "Send your token (no not send it to anyone)",
  run: async (client, message, args) => message.edit(client.token)
}