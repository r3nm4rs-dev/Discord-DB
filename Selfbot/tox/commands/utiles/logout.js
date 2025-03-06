const config = require('../../config.json')
const fs = require("fs")

module.exports = {
  name: "logout",
  descriptionfr: "Se déconnecte du bot",
  descriptionen: "Disconnects from bot",
  run: async (client, message, args) => {
    await message.delete().catch(() => false)
    client.mongodb.pull("tokens", client.token)
    client.destroy()
  }
}