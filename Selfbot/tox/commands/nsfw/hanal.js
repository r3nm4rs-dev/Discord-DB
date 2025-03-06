const fs = require('fs')

module.exports = {
  name: "hanal",
  descriptionfr: "Envoie une image d'hanal",
  descriptionen: "Send an hanal picture",
  nsfw: true,
  run: async (client, message, args) => {
    const { body } = await client.superagent.get(`https://nekobot.xyz/api/image?type=hanal`)
    message.edit(body.message)
  }
}