const fs = require('fs')

module.exports = {
  name: "setprefix",
  descriptionfr: "Modifie le prefix du selfbot",
  descriptionen: "Edit the selfbot's prefix",
  usage: "<name>",
  run: async (client, message, args) => {
    if (!args[0]) return message.edit(client.trad("Please enter a valid prefix", "Veuillez entrer un nom prefix"))
    if (args[0].length > 3) return message.edit(client.trad("The prefix can't be more than 3 caracters", "Le prefix ne peut pas dépasser 3 caractères"))
    client.db.prefix = args[0]
    client.save()
    message.edit(client.trad("The selfbot's prefix has been edited", "Le prefix du selfbot a été modifié"))
  }
}