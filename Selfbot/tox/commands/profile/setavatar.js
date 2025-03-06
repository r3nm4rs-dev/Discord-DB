const fs = require('fs')

module.exports = {
  name: "setavatar",
  descriptionfr: "Modifie ton avatar discord",
  descriptionen: "Edit your discord avatar",
  run: async (client, message, args) => {
    if (message.attachments.first()) {
      client.user.setAvatar(message.attachments.first().url)
        .then(() => message.edit({files: [], content: client.trad("Your avatar has been edited", "Votre avatar a été modifiée")}))
        .catch(() => message.edit({files: [], content: client.trad("I can't edit your avatar", "Je ne peux pas modifier votre avatar")}))
    } else if (args[0] && args[0].startsWith("https://" || "http://")) {
      client.user.setAvatar(args[0])
        .then(() => message.edit(("Your avatar has been edited", "Votre avatar a été modifiée")))
        .catch(() => message.edit(client.trad("I can't edit your avatar", "Je ne peux pas modifier votre avatar")))
    }
  }
}