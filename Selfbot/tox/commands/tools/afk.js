const fs = require('fs')

module.exports = {
  name: "afk",
  descriptionfr: "Active votre afk",
  descriptionen: "Enable your afk",
  usage: "[reason]",
  run: async (client, message, args) => {
   client.db.afk = args[0] ? args.join(' ') : null
    client.save()
    message.edit(client.trad(
      `You're afk for \`${args[0] ? args.join(' ') : "No reason"}\``,
      `Vous êtes afk pour \`${args[0] ? args.join(' ') : "Aucune raison"}\``
    ))
  }
}