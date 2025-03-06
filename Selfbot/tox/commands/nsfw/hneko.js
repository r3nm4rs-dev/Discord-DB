const fs = require('fs')

module.exports = {
  name: "hneko",
  descriptionfr: "Envoie une image hneko",
  descriptionen: "Send an hneko picture",
  nsfw: true,
  run: async (client, message, args) => {
    const { body } = await client.superagent.get(`https://nekobot.xyz/api/image?type=hneko`)
    message.edit(body.message)
  }
}