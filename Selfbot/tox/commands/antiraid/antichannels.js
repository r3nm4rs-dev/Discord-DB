const fs = require('fs')

module.exports = {
  name: "antichannels",
  descriptionfr: "Active ou désactive l'anti channels",
  descriptionen: "Enable or disable the anti channels",
  run: async (client, message, args) => {
    if (args[0] !== "on" && args[0] !== "off") return message.edit(client.trad("You must specify `on` or `off`", "Vous devez préciser `on` ou `off`"))
    if (args[0] === "on") {
      client.db.antichannels = true
      client.save()
      message.edit(client.trad("Anti-channel has been activated", "L'anti channels a été activé"))
    } else {
      client.db.antichannels = false
      client.save()
      message.edit(client.trad("Anti-channel has been deactivated", "L'anti channels a été désactivé"))
    }
  }
}