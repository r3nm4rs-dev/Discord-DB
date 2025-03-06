const fs = require('fs')

module.exports = {
  name: "robbio",
  descriptionfr: "Vole la bio d'un utilisateur",
  descriptionen: "Rob the about me from a user",
  usage: "<user>",
  run: async (client, message, args) => {
    let user = message.mentions.users.first() || client.users.cache.get(args[0]);
    if (!user) try {
      user = await client.users.fetch(args[0]);
    } catch { return message.edit(client.trad( `No user found for \`${args[0] || "nothing"}\``, `Aucun utilisateur de trouvé pour \`${args[0] || "rien"}\``)) }

    
    if (!user.bio) return message.edit(client.trad("This user don't have an about me", "Cette utilisateur n'a pas de bio"))
    client.user.setAboutMe(user.bio)
    message.edit(client.trad(`Your about me has been edited`, `Votre bio a été modifiée`))
  }
}