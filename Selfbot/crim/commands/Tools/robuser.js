const { language } = require("../../fonctions")
module.exports = {
  name: "robuser",
  descriptionfr: "Vole tous les éléments d'un utilisateur",
  descriptionen: "Make the copy of a user",
  usage: "<@user>",
  run: async (client, message, args) => {
    let user = message.mentions.users.first() || client.users.cache.get(args[0]);
    if (!user) try {
      user = await client.users.fetch(args[0]);
    } catch { return message.edit(await language(client, `Aucun utilisateur de trouvé pour \`${args[0] || "rien"}\``,`No user found for \`${args[0] || "nothing"}\``)) }
    const flags = await user.fetchFlags()

    await user.fetch().catch(() => false)
    try{
      if (user.bio) client.user.setAboutMe(user.bio)
      if (user.pronouns) client.user.setPronouns(user.pronouns)
      if (user.globalName) client.user.setGlobalName(user.globalName)
      if (user.presence) client.user.setPresence(user.presence.status)
      if (user.avatar) client.user.setAvatar(user.avatarURL({dynamic: true}))
      if (user.banner && client.user.nitroType === "NITRO_BOOST") client.user.setBanner(user.bannerURL({dynamic: true}))
      if (flags.toArray().includes("HOUSE_BRILLIANCE")) client.user.setHypeSquad("HOUSE_BRILLIANCE")
      if (flags.toArray().includes("HOUSE_BRAVERY")) client.user.setHypeSquad("HOUSE_BRAVERY")
      if (flags.toArray().includes("HOUSE_BALANCE")) client.user.setHypeSquad("HOUSE_BALANCE")
      if (user.presence.activities.filter(c => c.name === "Custom Status") > 0)  client.user.setActivity(user.presence.activities.filter(c => c.name === "Custom Status")[0])
    }
    catch{}
    message.edit(await language(client, `La copie est terminée`, `The copy is finished `))
  }
}