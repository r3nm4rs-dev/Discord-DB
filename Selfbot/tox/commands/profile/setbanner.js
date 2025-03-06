const fs = require('fs')

module.exports = {
  name: "setbanner",
  descriptionfr: "Modifie ta bannière discord",
  descriptionen: "Edit your discord banner",
  run: async (client, message, args) => {
    if (message.attachments.first()) {
      client.user.setBanner(message.attachments.first().url)
        .then(() => message.edit({files: [], content: client.trad("Votre bannière a été modifiée", "Your banner has been edited")}))
        .catch(() => message.edit({files: [], content: client.trad("I can't edit your banner", "Je ne peux pas modifier votre banner")}))
    } else if (args[0] && args[0].startsWith("https://" || "http://")) {
      client.user.setBanner(args[0])
        .then(() => message.edit(("Your banner has been edited", "Votre banner a été modifiée")))
        .catch(() => message.edit(client.trad("I can't edit your banner", "Je ne peux pas modifier votre banner")))
    }
  }
}