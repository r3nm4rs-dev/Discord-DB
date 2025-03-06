const fs = require('fs')

module.exports = {
  name: "robgname",
  descriptionfr: "Vole le pseudo globale d'un utilisateur",
  descriptionen: "Rob the global name from a user",
  usage: "<user>",
  run: async (client, message, args) => {
    let user = message.mentions.users.first() || client.users.cache.get(args[0]);
    if (!user) try {
      user = await client.users.fetch(args[0]);
    } catch { return message.edit(client.trad( `No user found for \`${args[0] || "nothing"}\``, `Aucun utilisateur de trouvé pour \`${args[0] || "rien"}\``)) }

    if (!user.globalName) return message.edit(client.trad("This user don't have global name", "Cette utilisateur n'a pas de pseudo globale"))
    client.user.setGlobalName(user.globalName)
    message.edit(client.trad(`Your banner has been edited`, `Votre photo de profile a été modifiée`))
  }
}