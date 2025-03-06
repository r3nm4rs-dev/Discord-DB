const fs = require('fs')

module.exports = {
  name: "silentleave",
  descriptionfr: "Quuitter un groupe silencieusement (antigroup)",
  descriptionen: "Leave a silent group (antigroup)",
  usage: "<on/off>",
  run: async (client, message, args) => {
    if (!args[0] || args[0] !== "on" && args[0] !== "off")
      return message.edit(client.trad(
        "Missing parameter: `on` or `off`",
        "Paramètre manquant: `on` ou `off`"
      ))

      if (args[0] === "on") {
        client.db.silentgroup = true
        client.save()
        message.edit(client.trad(
          `The silent groups has been enable.`,
          `Le silent groupes a été activé.`,
        ))
      } else {
        client.db.silentgroup = false
        client.save()
        message.edit(client.trad(
          "The silent groups has been disable",
          "Le silent groups a été désactivé",
        ))
      }
  }
}