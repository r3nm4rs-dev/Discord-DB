const fs = require('fs')

module.exports = {
  name: "sethypesquad",
  descriptionfr: "Modifie ton badge de la hyepsquad",
  descriptionen: "Edit your badge of the hypesquad",
  run: async (client, message, args) => {
    const hypesquadlist = ["bravery", "brilliance", "ballance", "clear"]
    const hypesquad = (house) => {
      switch (house) {
        case "clear":
          return 0
        case "bravery":
          return 1
        case "brilliance":
          return 2
        case "ballance":
          return 3
      }
    }
    if (!args[0] || !hypesquadlist.includes(args[0])) return message.edit(`${client.trad("Please enter one of these options", "Veuillez entrer l'une de ses options")}: ${hypesquadlist.map(o => `\`${o}\``).join(', ')}`)
    client.user.setHypeSquad(hypesquad(args[0]))
      .then(() => message.edit(client.trad("Your hypesquad has been edited", "Votre hypesquad a été modifiée")))
      .catch(() => message.edit(client.trad("I can't edit you're hypesquad", "Je n'ai pas pu modifier votre hypesquad")))
  }
}