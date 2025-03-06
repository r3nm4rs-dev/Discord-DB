const { RichPresence } = require("djs-selfbot-v13")

const fs = require('fs')

module.exports = {
  name: "secretstream",
  descriptionfr: "Te met un stream discret",
  descriptionen: "Make you a secret stream",
  usage: "<text>",
  run: async (client, message, args) => {
    const r = new RichPresence().setName(args.join(' ') || client.db.name).setType("STREAMING")
    client.user.setActivity(r)
    
    message.edit(client.trad(
      `You are **playing at** \`${args.slice(0).join(' ') || client.db.name}\``,
      `Vous êtes en train de **jouer à** \`${args.slice(0).join(' ') || client.db.name}\``,
    ))
  }
}