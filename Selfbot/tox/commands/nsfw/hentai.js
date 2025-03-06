const fs = require('fs')

module.exports = {
  name: "hentai",
  descriptionfr: "Envoie une image d'hentai",
  descriptionen: "Send an hentai picture",
  nsfw: true,
  run: async (client, message, args) => {
    const { body } = await client.superagent.get(`https://nekobot.xyz/api/image?type=hentai`)
    message.edit(body.message)
  }
}