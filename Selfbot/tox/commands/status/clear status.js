const fs = require('fs')

module.exports = {
  name: "clearstatus",
  descriptionfr: "Supprime ton status",
  descriptionen: "Delete your status",
  run: async (client, message, args) => {
    client.user.setActivity(null)
    message.edit(client.trad(
      "Your status has been deleted",
      "Votre status a été supprimé"
    ))
  }
}