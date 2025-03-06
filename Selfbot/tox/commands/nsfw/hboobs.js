const fs = require('fs')

module.exports = {
  name: "hboobs",
  descriptionfr: "Envoie une image d'hboobs",
  descriptionen: "Send an hboobs picture",
  nsfw: true,
  run: async (client, message, args) => {
    const { body } = await client.superagent.get(`https://nekobot.xyz/api/image?type=hboobs`)
    message.edit(body.message)
  }
}