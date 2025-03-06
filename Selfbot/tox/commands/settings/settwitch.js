const fs = require('fs')

module.exports = {
  name: "settwitch",
  descriptionfr: "Modifie l'url twitch du selfbot",
  descriptionen: "Edit the twitch url of the selfbot",
  usage: "<url>",
  run: async (client, message, args) => {
    if (!args[0] || !args[0].startsWith("https://twitch.tv/")) return message.edit(client.trad("Please enter a valid url", "Veuillez entrer un url valide"))
    client.db.twitch = args[0]
    client.save()
    message.edit(client.trad("The twitch url has been edited", "L'url twitch a été modifié"))
  }
}