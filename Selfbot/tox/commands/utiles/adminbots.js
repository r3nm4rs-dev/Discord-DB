const fs = require('fs')

module.exports = {
  name: "alladminbots",
  descriptionfr: "Affiche les tous les bots admins d'un serveur",
  descriptionen: "Display all admins bots from a server",
  run: async (client, message, args) => {
    if (!message.guild)return message.edit(client.trad(
      `Please execute this command in a server`,
      `Veuillez executer cette commande dans un serveur`,
    ))

    const admins = guild.members.cache.filter(m => m.permissions.has("ADMINISTRATOR") && m.user.bot)

    message.edit(`${admins.size > 0 ? admins.map((m, i) => `**${i+1}** - \`${m.user.username}\``) : `**${client.trad("Nobody", "Aucun")}**`}`)
  }
}