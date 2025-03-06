const fs = require('fs')

module.exports = {
  name: "pgif",
  descriptionfr: "Je sais toujours pas c'est quoi",
  descriptionen: "I don't know what's that",
  nsfw: true,
  run: async (client, message, args) => {
    const { body } = await client.superagent.get(`https://nekobot.xyz/api/image?type=pgif`)
    message.edit(body.message)
  }
}