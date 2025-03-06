const fs = require('fs')

module.exports = {
  name: "robbanner",
  descriptionfr: "Vole la bannière d'un utilisateur",
  descriptionen: "Rob the banner from a user",
  usage: "<user>",
  run: async (client, message, args) => {
    if (client.user.nitroType !== "NITRO_BOOST") return message.edit(client.trad(`You must have a nitro boost for rob a banner`, `Tu dois avoir nitro boost pour voler une bannière`))
    let user = message.mentions.users.first() || client.users.cache.get(args[0]);
    if (!user) try {
      user = await client.users.fetch(args[0]);
    } catch { return message.edit(client.trad( `No user found for \`${args[0] || "nothing"}\``, `Aucun utilisateur de trouvé pour \`${args[0] || "rien"}\``)) }

    await user.fetch().catch(() => false)
    
    if (!user.banner) return message.edit(client.trad("This user don't have a banner", "Cette utilisateur n'a pas de bannière"))
    client.user.setBanner(user.bannerURL())
    message.edit(client.trad(`Your banner has been edited`, `Votre bannière a été modifiée`))
  }
}