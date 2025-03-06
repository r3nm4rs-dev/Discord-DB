const fs = require('fs')

module.exports = {
  name: "antiwebhooks",
  descriptionfr: "Active ou désactive l'anti webhooks",
  descriptionen: "Enable or disable the anti webhooks",
  run: async (client, message, args) => {
    if (args[0] !== "on" && args[0] !== "off") return message.edit(client.trad("You must specify `on` or `off`", "Vous devez préciser `on` ou `off`"))
    if (args[0] === "on") {
      client.db.antiwebhooks = true
      client.save()
      message.edit(client.trad("Anti-webhooks has been activated", "L'anti webhooks a été activé"))
    } else {
      client.db.antiwebhooks = false
      client.save()
      message.edit(client.trad("Anti-webhooks has been deactivated", "L'anti webhooks a été désactivé"))
    }
  }
}