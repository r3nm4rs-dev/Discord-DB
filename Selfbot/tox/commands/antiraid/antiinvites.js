const fs = require('fs')

module.exports = {
  name: "antiinvites",
  descriptionfr: "Active ou désactive l'anti invites",
  descriptionen: "Enable or disable the anti invites",
  run: async (client, message, args) => {
    if (args[0] !== "on" && args[0] !== "off") return message.edit(client.trad("You must specify `on` or `off`", "Vous devez préciser `on` ou `off`"))
    if (args[0] === "on") {
      client.db.antiinvites = true
      client.save()
      message.edit(client.trad("Anti-invites has been activated", "L'anti invites a été activé"))
    } else {
      client.db.antiinvites = false
      client.save()
      message.edit(client.trad("Anti-invites has been deactivated", "L'anti invites a été désactivé"))
    }
  }
}