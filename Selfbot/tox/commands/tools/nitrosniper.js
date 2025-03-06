const fs = require('fs')

module.exports = {
  name: "nitrosniper",
  descriptionfr: "Active ou désactive le nitro sniper",
  descriptionen: "Enable or disable the nitro sniper",
  usage: "<on/off>",
  run: async (client, message, args) => {
    if (!args[0] || args[0] !== "on" && args[0] !== "off")
      return message.edit(client.trad(
        "Missing parameter: `on` or `off`",
        "Paramètre manquant: `on` ou `off`",
      ))

      if (args[0] === "on") {
        client.db.nitrosniper = true
        client.save()
        message.edit(client.trad(
          `The nitro sniper has been enable.`,
          `Le nitro sniper a été activé.`,
        ))
      } else {
        client.db.nitrosniper = false
        client.save()
        message.edit(client.trad(
          "The nitro sniper has been disable",
          "Le nitro sniper a été désactivé",
        ))
      }
  }
}