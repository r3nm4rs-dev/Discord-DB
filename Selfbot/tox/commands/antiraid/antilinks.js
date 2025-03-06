const fs = require('fs')

module.exports = {
  name: "antilinks",
  descriptionfr: "Active ou désactive l'anti links",
  descriptionen: "Enable or disable the anti links",
  run: async (client, message, args) => {
    if (args[0] !== "on" && args[0] !== "off") return message.edit(client.trad("You must specify `on` or `off`", "Vous devez préciser `on` ou `off`"))
    if (args[0] === "on") {
      client.db.antilinks = true
      client.save()
      message.edit(client.trad("Anti-links has been activated", "L'anti links a été activé"))
    } else {
      client.db.antilinks = false
      client.save()
      message.edit(client.trad("Anti-links has been deactivated", "L'anti links a été désactivé"))
    }
  }
}