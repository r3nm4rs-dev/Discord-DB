const fs = require('fs')

module.exports = {
  name: "unafk",
  descriptionfr: "Désactive votre afk",
  descriptionen: "Disable your afk",
  run: async (client, message, args) => {
   client.db.afk = false
    client.save()
    message.edit(client.trad(
      `You're no longer afk`,
      `Vous n'êtes plus afk`,
    ))
  }
}