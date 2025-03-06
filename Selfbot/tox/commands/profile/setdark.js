const fs = require('fs')

module.exports = {
  name: "setdark",
  descriptionfr: "Modifie le thème de ton client en mode sombre",
  descriptionen: "Modify your client's theme in dark mode",
  premium: true,
  invisible: true,
  run: async (client, message, args) => {
    client.settings.setTheme("dark")
    message.edit(client.trad("Your theme has been modified",
    "Votre thème a été modifié"))
  }
}