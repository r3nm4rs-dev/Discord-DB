const fs = require('fs')

module.exports = {
  name: "logs-color",
  descriptionfr: "Modifie la couleur du logger",
  descriptionen: "Edit the color of the logger",
  usage: "<color>",
  run: async (client, message, args) => {
    if (!args[0]) return message.edit(client.trad('Please enter a valid color hex', 'Entre une couleur HEX valide'))
    if (!/^#[0-9A-F]{6}$/i.test(args[0])) return message.edit(client.trad('Please enter a valid color hex', 'Entre une couleur HEX valide'))
    
    client.db.clogger = args[0]
    client.save()
    message.edit(client.trad("The new color has been saved", "La nouvelle couleur a été sauvegardé"))
  }
}