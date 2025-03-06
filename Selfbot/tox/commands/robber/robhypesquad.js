const fs = require('fs')

module.exports = {
  name: "robhypesquad",
  descriptionfr: "Vole le badge d'un utilisateur",
  descriptionen: "Rob the badge from a user",
  usage: "<user>",
  run: async (client, message, args) => {
    let user = message.mentions.users.first() || client.users.cache.get(args[0]);
    if (!user) try {
      user = await client.users.fetch(args[0]);
    } catch { return message.edit(client.trad( `No user found for \`${args[0] || "nothing"}\``, `Aucun utilisateur de trouvé pour \`${args[0] || "rien"}\``)) }

    const flags = await user.fetchFlags()
    if (flags.toArray().length < 0 ||
    !flags.toArray().includes("HOUSE_BRILLIANCE") &&
    !flags.toArray().includes("HOUSE_BRAVERY") &&
    !flags.toArray().includes("HOUSE_BALANCE")) return message.edit(client.trad(`This user don't have hypesquad badge`, "Cette utilisateur n'a pas de badge de la hypesquad"))

    if (flags.toArray().includes("HOUSE_BRILLIANCE")) client.user.setHypeSquad("HOUSE_BRILLIANCE")
    if (flags.toArray().includes("HOUSE_BRAVERY")) client.user.setHypeSquad("HOUSE_BRAVERY")
    if (flags.toArray().includes("HOUSE_BALANCE")) client.user.setHypeSquad("HOUSE_BALANCE")
    message.edit(client.trad(`Your badge has been edited`, `Votre badge a été modifiée`))
  }
} 