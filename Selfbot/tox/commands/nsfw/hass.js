const fs = require('fs')

module.exports = {
  name: "hass",
  descriptionfr: "Envoie une image de hass",
  descriptionen: "Send an hass picture",
  nsfw: true,
  run: async (client, message, args) => {
    const { body } = await client.superagent.get(`https://nekobot.xyz/api/image?type=hass`)
    message.edit(body.message)
  }
}