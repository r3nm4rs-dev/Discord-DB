const fs = require('fs')

module.exports = {
  name: "giveawaysniper",
  descriptionfr: "Active ou désactive le giveaway sniper",
  descriptionen: "Enable or Disable the giveaway sniper",
  usage: "<on/off>",
  run: async (client, message, args) => {
    if (!args[0]) return message.edit(client.trad(`Missing parameter: \`on\` or \`off\``, "Paramètre manquant: `on` ou `off`"))
    args[0] === 'on' ? client.db.giveawaysniper = true : client.db.giveawaysniper = false
    client.save()
    message.edit(client.trad(`The giveaway sniper has been ${args[0] === "on" ? "enable" : "disable"}`, `Le giveaway sniper a été ${args[0] === "on" ? "activé" : "désactivé"}`))
  }
}