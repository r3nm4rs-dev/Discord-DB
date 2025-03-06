const fs = require('fs')

module.exports = {
  name: "antipings",
  descriptionfr: "Active ou désactive l'anti pings",
  descriptionen: "Enable or disable the anti pings",
  run: async (client, message, args) => {
    if (args[0] !== "on" && args[0] !== "off") return message.edit(client.trad("You must specify `on` or `off`", "Vous devez préciser `on` ou `off`"))
    if (args[0] === "on") {
      client.db.antipings = true
      client.save()
      message.edit(client.trad("Anti-pings has been activated", "L'anti pings a été activé"))
    } else {
      client.db.antipings = false
      client.save()
      message.edit(client.trad("Anti-pings has been deactivated", "L'anti pings a été désactivé"))
    }
  }
}