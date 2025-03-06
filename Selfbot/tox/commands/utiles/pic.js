const fs = require('fs')

module.exports = {
  name: "pic",
  descriptionfr: "Envoie l'avatar d'une personne",
  descriptionen: "Send the picture of a user",
  usage: "[user]",
  run: async (client, message, args) => {
    let user = message.mentions.users.first() || client.users.cache.get(args[0]);
    if (!user) try {
      user = await client.users.fetch(args[0]);
    } catch {
      user = message.author;
    }
    message.edit(`**Voici l'avatar de ${user.username}**\n\n${user.avatarURL({
      dynamic: true,
      size: 4096
    })}`)

  }
}