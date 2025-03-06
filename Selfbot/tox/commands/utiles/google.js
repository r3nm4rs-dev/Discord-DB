const fs = require('fs')

module.exports = {
  name: "google",
  descriptionfr: "Fait une recherche google",
  usage: "<recherche>",
  run: async (client, message, args) => {
    if (!args[0]) return message.edit("Veuillez écrire votre recherche")
    message.edit(`Voici les résultats de votre recherche\nhttps://www.google.fr/search?q=${args.join("%20")}`)
  }
}