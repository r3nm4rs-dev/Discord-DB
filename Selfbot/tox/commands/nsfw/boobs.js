const fs = require('fs')

module.exports = {
  name: "boobs",
  descriptionfr: "Envoie une image de boobs",
  descriptionen: "Send a boobs picture",
  nsfw: true,
  run: async (client, message, args) => {
    const { body } = await client.superagent.get(`https://nekobot.xyz/api/image?type=boobs`)
    message.edit(body.message)
  }
}