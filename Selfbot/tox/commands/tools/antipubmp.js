const fs = require('fs')

module.exports = {
  name: "antipubmp",
  descriptionfr: "Active ou désactive l'anti pub mp",
  descriptionen: "Enable or disable the anti pub dm",
  usage: "<on/off>",
  run: async (client, message, args) => {
    if (!args[0] || args[0] !== "on" && args[0] !== "off")
      return message.edit(client.trad(
        "Missing parameter: `on` or `off`",
        "Paramètre manquant: `on` ou `off`"
      ))

      if (args[0] === "on") {
        client.db.antipub = true
        client.save()
        message.edit(client.trad(
          `The anti pub dm has been enable.`,
          `L'anti pub mp a été activé.`,
        ))
      } else {
        client.db.antipub = false
        client.save()
        message.edit(client.trad(
          "The anti pub dm has been disable",
          "L'anti pub mp a été désactivé",
        ))
      }
  }
}