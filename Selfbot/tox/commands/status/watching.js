const fs = require('fs')

module.exports = {
  name: "watching",
  descriptionfr: "Change ton status en regarde...",
  descriptionen: "Change your status to watching...",
  usage: "<text>",
  run: async (client, message, args) => {
    client.user.setActivity(args.slice(0).join(' ') || client.db.name, {
      type: "WATCHING"
    })
    message.edit(client.trad(
      `You are **watching** \`${args.slice(0).join(' ') || client.db.name}\``,
      `Vous êtes en train de **regarder** \`${args.slice(0).join(' ') || client.db.name}\``,
    ))
  }
}