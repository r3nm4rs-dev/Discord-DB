const fs = require('fs')

module.exports = {
  name: "streaming",
  descriptionfr: "Change ton status en stream...",
  descriptionen: "Change your status to stream...",
  usage: "<text>",
  run: async (client, message, args) => {
    client.user.setActivity(args.slice(0).join(' ') || client.db.name, {
      type: "STREAMING",
      url: client.db.twitch
    })
    message.edit(client.trad(
      `You are **streaming** \`${args.slice(0).join(' ') || client.db.name}\``,
      `Vous êtes en train de **streamer** \`${args.slice(0).join(' ') || client.db.name}\``,
    ))
  }
}