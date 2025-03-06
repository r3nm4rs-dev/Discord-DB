const fs = require('fs')

module.exports = {
  name: "modele",
  descriptionfr: "Modifie le style du menu help",
  descriptionen: "Edit the style of the help menu",
  usage: "<modele>",
  run: async (client, message, args) => {
    const helps = ["nighty", "codeblock","speed", "k3s", "ethone", "ryz", "mill"]
    if (!helps.includes(args[0])) return message.edit(`Paramètre manquant: ${helps.map(h => `\`${h}\``).join(", ")}`)
    client.db.theme = args[0]
    client.save()
    message.edit(`Votre menu help a été modifié`)
  }
}