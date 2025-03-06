const fs = require('fs')

module.exports = {
  name: "setlight",
  descriptionfr: "Modifie le thème de ton client en mode éclairé",
  descriptionen: "Modify your client's theme in light mode",
  premium: true,
  invisible: true,
  run: async (client, message, args) => {
    client.settings.setTheme("light")
    message.edit(client.trad("Your theme has been modified", "Votre thème a été modifié"))
  }
}