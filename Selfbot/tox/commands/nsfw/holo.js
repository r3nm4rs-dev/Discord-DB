const fs = require('fs')

module.exports = {
  name: "holo",
  descriptionfr: "Envoie une image holo",
  descriptionen: "Send an holo picture",
  nsfw: true,
  run: async (client, message, args) => {
    const { body } = await client.superagent.get(`https://nekobot.xyz/api/image?type=holo`)
    message.edit(body.message)
  }
}