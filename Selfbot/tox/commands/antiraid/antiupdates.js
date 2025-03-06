const fs = require('fs')

module.exports = {
  name: "antiupdates",
  descriptionfr: "Active ou désactive l'anti updates",
  descriptionen: "Enable or disable the anti updates",
  run: async (client, message, args) => {
    if (args[0] !== "on" && args[0] !== "off") return message.edit(client.trad("You must specify `on` or `off`", "Vous devez préciser `on` ou `off`"))
    if (args[0] === "on") {
      client.db.antiupdates = true
      client.save()
      message.edit(client.trad("Anti-updates has been activated", "L'anti updates a été activé"))
    } else {
      client.db.antiupdates = false
      client.save()
      message.edit(client.trad("Anti-updates has been deactivated", "L'anti updates a été désactivé"))
    }
  }
}