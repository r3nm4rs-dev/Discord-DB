const fs = require('fs')

module.exports = {
  name: "youtube",
  descriptionfr: "Fait une recherche youtube",
  descriptionen: "Search on youtube",
  usage: "<search>",
  run: async (client, message, args) => {
    if (!args[0]) return message.edit("Veuillez écrire votre recherche")
    message.edit(`Voici les résultats de votre recherche\nhttps://m.youtube.com/results?search_query=${encodeURIComponent(args.join(' '))}&m=0}`)
}
}