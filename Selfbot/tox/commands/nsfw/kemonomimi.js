const fs = require('fs')

module.exports = {
  name: "kemonomimi",
  descriptionfr: "je sais pas c'est quoi...",
  descriptionen: "I don't know what's that...",
  nsfw: true,
  run: async (client, message, args) => {
    const { body } = await client.superagent.get(`https://nekobot.xyz/api/image?type=kemonomimi`)
    message.edit(body.message)
  }
}