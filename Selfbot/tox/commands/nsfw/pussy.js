const fs = require('fs')

module.exports = {
  name: "pussy",
  descriptionfr: "bref",
  descriptionen: "bref",
  nsfw: true,
  run: async (client, message, args) => {
    const { body } = await client.superagent.get(`https://nekobot.xyz/api/image?type=pussy`)
    message.edit(body.message)
  }
}