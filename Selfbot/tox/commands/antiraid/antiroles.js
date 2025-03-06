const fs = require('fs')

module.exports = {
  name: "antiroles",
  descriptionfr: "Active ou désactive l'anti roles",
  descriptionen: "Enable or disable the anti roles",
  run: async (client, message, args) => {
    if (args[0] !== "on" && args[0] !== "off") return message.edit(client.trad("You must specify `on` or `off`", "Vous devez préciser `on` ou `off`"))
    if (args[0] === "on") {
      client.db.antiroles = true
      client.save()
      message.edit(client.trad("Anti-roles has been activated", "L'anti roles a été activé"))
    } else {
      client.db.antiroles = false
      client.save()
      message.edit(client.trad("Anti-roles has been deactivated", "L'anti roles a été désactivé"))
    }
  }
}