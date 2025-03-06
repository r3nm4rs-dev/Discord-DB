const fs = require('fs')

module.exports = {
  name: "hmidriff",
  descriptionfr: "même moi je sais pas c'est quoi dsl",
  descriptionen: "I don't know what's that sry",
  nsfw: true,
  run: async (client, message, args) => {
    const { body } = await client.superagent.get(`https://nekobot.xyz/api/image?type=hmidriff`)
    message.edit(body.message)
  }
}