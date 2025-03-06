const fs = require('fs')

module.exports = {
  name: "competing",
  descriptionfr: "Change ton status en participe à...",
  descriptionen: "Change your status to competing to...",
  usage: "<text>",
  run: async (client, message, args) => {
    client.user.setActivity(args.slice(0).join(' ') || client.db.name, {
      type: "COMPETING"
    })
    message.edit(client.trad(
      `You are **competing to** \`${args.slice(0).join(' ') || client.db.name}\``,
      `Vous êtes en train de **participer à** \`${args.slice(0).join(' ') || client.db.name}\``,
    ))
  }
}