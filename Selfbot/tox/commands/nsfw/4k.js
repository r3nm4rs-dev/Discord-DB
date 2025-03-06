const fs = require('fs')

module.exports = {
  name: "4k",
  descriptionfr: "Envoie une image en 4K",
  descriptionen: "Send a 4K Picturey",
  nsfw: true,
  run: async (client, message, args) => {
    const { body } = await client.superagent.get(`https://nekobot.xyz/api/image?type=4K`)
    message.edit(body.message)
  }
}