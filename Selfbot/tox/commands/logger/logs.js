const { Permissions } = require("djs-selfbot-v13")

const fs = require('fs')

module.exports = {
  name: "logs",
  descriptionfr: "Active ou désactive les logs",
  descriptionen: "Enable or disable the logs",
  usage: "<on/off>",
  run: async (client, message, args) => {
    if (!args[0] || args[0] !== "on" && args[0] !== "off")
      return message.edit(client.trad(
        "Missing parameter: `on` or `off`",
        "Paramètre manquant: `on` ou `off`"
      ))

      if (args[0] === "on") {
        client.db.onlogger = true
        client.save()
        message.edit(client.trad(
          `The logger has been enable.`,
          `Le logger a été activé.`,
        ))
      } else {
        client.db.onlogger = false
        client.save()
        message.edit(client.trad(
          "The logger has been disable",
          "Le logger a été désactivé",
        ))
      }
  }
}