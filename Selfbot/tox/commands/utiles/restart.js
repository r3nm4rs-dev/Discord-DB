const fs = require('fs')

module.exports = {
    name: "restart",
    descriptionfr: "Relance le bot",
    descriptionen: "Restart the bot",
    run: async (client, message, args) => {
        const token = client.token
        await message.edit(client.trad("Restarting the bot...", "Relancement du bot..."))
        client.destroy()
        client.login(token)
        message.edit(client.trad("Successfull restarted !", "Relancé avec succès !"))
      }
  }