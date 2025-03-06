const fs = require('fs')

module.exports = {
  name: "antibans",
  descriptionfr: "Active ou désactive l'anti bans",
  descriptionen: "Enable or disable the anti bans",
  run: async (client, message, args) => {
    if (args[0] !== "on" && args[0] !== "off") return message.edit(client.trad("You must specify `on` or `off`", "Vous devez préciser `on` ou `off`"))
    if (args[0] === "on") {
      client.db.antibans = true
      client.save()
      message.edit(client.trad("Anti-bans has been activated", "L'anti bans a été activé"))
    } else {
      client.db.antibans = false
      client.save()
      message.edit(client.trad("Anti-bans has been deactivated", "L'anti bans a été désactivé"))
    }
  }
}