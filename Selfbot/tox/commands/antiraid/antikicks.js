const fs = require('fs')

module.exports = {
  name: "antikicks",
  descriptionfr: "Active ou désactive l'anti kicks",
  descriptionen: "Enable or disable the anti kicks",
  run: async (client, message, args) => {
    if (args[0] !== "on" && args[0] !== "off") return message.edit(client.trad("You must specify `on` or `off`", "Vous devez préciser `on` ou `off`"))
    if (args[0] === "on") {
      client.db.antikicks = true
      client.save()
      message.edit(client.trad("Anti-kicks has been activated", "L'anti kicks a été activé"))
    } else {
      client.db.antikicks = false
      client.save()
      message.edit(client.trad("Anti-kicks has been deactivated", "L'anti kicks a été désactivé"))
    }
  }
}