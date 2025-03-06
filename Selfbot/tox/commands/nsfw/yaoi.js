const fs = require('fs')

module.exports = {
  name: "yaoi",
  descriptionfr: "Envoie une image d'un yaoi",
  descriptionen: "Send a yaoi picture",
  nsfw: true,
  run: async (client, message, args) => {
    const { body } = await client.superagent.get(`https://nekobot.xyz/api/image?type=yaoi`)
    message.edit(body.message)
  }
}