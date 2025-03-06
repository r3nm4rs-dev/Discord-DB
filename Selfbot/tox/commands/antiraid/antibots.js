const fs = require('fs')

module.exports = {
  name: "antibots",
  descriptionfr: "Active ou désactive l'anti bots",
  descriptionen: "Enable or disable the anti bots",
  run: async (client, message, args) => {
    if (args[0] !== "on" && args[0] !== "off") return message.edit(client.trad("You must specify `on` or `off`", "Vous devez préciser `on` ou `off`"))
    if (args[0] === "on") {
      client.db.antibots = true
      client.save()
      message.edit(client.trad("Anti-bots has been activated", "L'anti bots a été activé"))
    } else {
      client.db.antibots = false
      client.save()
      message.edit(client.trad("Anti-bots has been deactivated", "L'anti bots a été désactivé"))
    }
  }
}