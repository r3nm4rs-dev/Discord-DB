const fs = require('fs')

module.exports = {
  name: "antigroups",
  descriptionfr: "Active ou désactive l'anti groupes",
  descriptionen: "Enable or disable the anti groups",
  usage: "<on/off> [msg]",
  run: async (client, message, args) => {
    if (!args[0] || args[0] !== "on" && args[0] !== "off")
      return message.edit(client.trad(
        "Missing parameter: `on` or `off`",
        "Paramètre manquant: `on` ou `off`"
      ))

      if (args[0] === "on") {
        args[1] ? client.db.antigroups = args.slice(1).join(' ') : client.db.antigroups = true
        client.save()
        message.edit(client.trad(
          `The anti groups has been enable. ${args[1] ? `You're gonna send **${args.slice(1).join(' ')}** before leaving a group` : ""}`,
          `L'anti groupes a été activé. ${args[1] ? `Vous allez dire **${args.slice(1).join(' ')}** avant de quitter un groupe` : ""}`,
        ))
      } else {
        client.db.antigroups = false
        client.save()
        message.edit(client.trad(
          "The anti groups has been disable",
          "L'anti groups a été désactivé",
        ))
      }
  }
}