const fs = require('fs')

module.exports = {
  name: "setname",
  descriptionfr: "Modifie ton pseudo discord",
  descriptionen: "Edit your discord username",
  run: async (client, message, args) => {
    if (!args[0]) return message.edit(client.trad("Please give me a username", "Veuillez me donner un pseudo"))
    client.user.setUsername(args.join(' '))
      .then(() => message.edit(client.trad("Your username has been edited", "Votre pseudo a été modifié")))
      .catch(() => message.edit(client.trad("I can't edit your username", "Je ne peux pas modifier votre pseudo")))
  }
}