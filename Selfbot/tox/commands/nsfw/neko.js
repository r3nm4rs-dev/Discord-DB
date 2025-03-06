const fs = require('fs')

module.exports = {
  name: "neko",
  descriptionfr: "Envoie une image d'une neko",
  descriptionen: "Send an neko picture",
  nsfw: true,
  run: async (client, message, args) => {
    const { body } = await client.superagent.get(`https://nekobot.xyz/api/image?type=neko`)
    message.edit(body.message)
  }
}