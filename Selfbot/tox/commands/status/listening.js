const fs = require('fs')

module.exports = {
  name: "listening",
  descriptionfr: "Change ton status en écoute...",
  descriptionen: "Change your status to listening...",
  usage: "<text>",
  run: async (client, message, args) => {
    client.user.setActivity(args.slice(0).join(' ') || client.db.name, {
      type: "LISTENING"
    })
    message.edit(client.trad(
      `You are **listening** \`${args.slice(0).join(' ') || client.db.name}\``,
      `Vous êtes en train d' **écouter** \`${args.slice(0).join(' ') || client.db.name}\``,
    ))
  }
}