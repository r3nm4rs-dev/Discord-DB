const fs = require('fs')

module.exports = {
  name: "logs-webhook",
  descriptionfr: "Modifie l'URL du logger (webhook)",
  descriptionen: "Edit the URL of the logger (webhook)",
  usage: "[webhook url]",
  run: async (client, message, args) => {
    if (!args[0]){
      client.db.logger = null
      client.save()
      message.edit(client.trad(
        "The logger has been disable",
        "Le logger a été désactivé",
      ))
    } else {
      if (!args[0].startsWith("https://")) return message.edit(client.trad("Please enter a valid webhook link", "Veuillez m'envoyer un lien de webhook valide"))
      client.db.logger = args[0]
      client.save()
      message.edit(client.trad(
        "The logger has been enable",
        "Le logger a été activé",
      ))
    }
  }
}