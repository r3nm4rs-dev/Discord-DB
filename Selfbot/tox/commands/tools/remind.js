const ms = require('ms')

const fs = require('fs')

module.exports = {
  name: "remind",
  descriptionfr: "Créé un rappel",
  descriptionen: "Create a reminder",
  usage: "<time> <rappel>",
  run: async (client, message, args) => {
    if (!args[0] || !ms(args[0]) || isNaN(ms(args[0]))) return message.edit(client.trad(
      "Pleease enter a valid time",
      "Veuillez entrer un temps valide",
    ))

    let time = ms(args[0])

    let query = args.slice(1).join(" ")

    if (!query) return message.edit(client.trad(
      "Please enter a valid remnid",
      "Veuillez indiquer un rappel valide",
    ))

    client.db.reminders.push({
      content: query,
      channel: message.channel.id,
      moments: Date.now() + time
    })
    client.save()

    message.edit(client.trad(
      "Your remind has been successfully create",
      "Votre rappel a été créé avec succès",
    ))
  }
}