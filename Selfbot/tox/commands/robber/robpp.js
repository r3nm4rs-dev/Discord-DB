const fs = require('fs')

module.exports = {
  name: "robpp",
  descriptionfr: "Vole la photo de profile d'un utilisateur",
  descriptionen: "Rob the profile picture from a user",
  usage: "<user>",
  run: async (client, message, args) => {
    let user = message.mentions.users.first() || client.users.cache.get(args[0]);
    if (!user) try {
      user = await client.users.fetch(args[0]);
    } catch {
      message.edit(client.trad(
        `No user found for \`${args[0] || "nothing"}\``,
        `Aucun utilisateur de trouvé pour \`${args[0] || "rien"}\``
      ))
    }

    if (!user.avatar) return message.edit(client.trad("This user don't have avatar", "Cette utilisateur n'a pas d'avatar"))
    client.user.setAvatar(user.avatarURL({dynamic: true}))
    message.edit(client.trad(`Your avatar has been edited`, `Votre photo de profile a été modifiée`))
  }
}