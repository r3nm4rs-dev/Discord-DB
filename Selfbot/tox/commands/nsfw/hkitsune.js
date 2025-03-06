const fs = require('fs')

module.exports = {
  name: "hkitsune",
  descriptionfr: "Envoie une image d'un hkitsune",
  descriptionen: "Send a hkitsune picture",
  nsfw: true,
  run: async (client, message, args) => {
    const { body } = await client.superagent.get(`https://nekobot.xyz/api/image?type=hkitsune`)
    message.edit(body.message)
  }
}