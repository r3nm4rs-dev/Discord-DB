const fs = require('fs')

module.exports = {
  name: "banner",
  descriptionfr: "Envoie la bannière d'une personne",
  descriptionen: "Send the banner of a user",
  usage: "[user]",
  run: async (client, message, args) => {
    let user = message.mentions.users.first() || await client.users.fetch(args[0]).catch(() => false);
    if (!user) user = message.author

    message.edit(`**${client.trad("This is the banner of", "Voici la bannière de")} ${user.username}**\n\n${user.bannerURL({
      dynamic: true,
      size: 4096
    })}`)
  }
}