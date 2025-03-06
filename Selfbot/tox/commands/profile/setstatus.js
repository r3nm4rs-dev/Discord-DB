const fs = require('fs')

module.exports = {
  name: "setstatus",
  descriptionfr: "Modifie ton status discord",
  descriptionen: "Edit your discord status",
  run: async (client, message, args) => {
    const presences = ["online", "idle", "dnd", "offline"]
    if (!args[0] || !presences.includes(args[0])) return message.edit(`${client.trad("Please enter one of these options",  "Veuillez entrer l'une de ses options")}: ${presences.map(o => `\`${o}\``).join(', ')}`)
    client.user.setStatus(args[0])
    message.edit(client.trad("Your status has been changed", "Votre status a été modifié"))
  }
}