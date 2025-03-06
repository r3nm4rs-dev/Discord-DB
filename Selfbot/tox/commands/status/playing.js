const fs = require('fs')

module.exports = {
  name: "playing",
  descriptionfr: "Change ton status en joue à...",
  descriptionen: "Change your status to playing...",
  usage: "<text>",
  run: async (client, message, args) => {
    client.user.setActivity(args.slice(0).join(' ') || client.db.name, {
      type: "PLAYING"
    })
    message.edit(client.trad(
      `You are **playing at** \`${args.slice(0).join(' ') || client.db.name}\``,
      `Vous êtes en train de **jouer à** \`${args.slice(0).join(' ') || client.db.name}\``,
    ))
  }
}