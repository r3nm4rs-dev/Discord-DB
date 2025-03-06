const fs = require('fs')

module.exports = {
  name: "searchspotify",
  descriptionfr: "Fait une recherche spotify",
  descriptionen: "Search on spotify",
  usage: "<search>",
  run: async (client, message, args) => {
    if (!args[0]) return message.edit("Veuillez écrire votre recherche")
    message.edit(`Voici les résultats de votre recherche\nhttps://open.spotify.com/search/q=${args.join("%20")}`)
  }
}