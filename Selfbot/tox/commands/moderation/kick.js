const fs = require('fs')

module.exports = {
  name: "kick",
  descriptionfr: "Expulse un membre",
  descriptionen: "kick a member",
  run: async (client, message, args) => {
    if (!message.guild) return message.edit(client.trad(
      `Please run this command on a server`,
      `Veuillez executer cette commande dans un serveur`,
      ))
    
    if (!message.guild.members.me.permissions.has("KICK_MEMBERS")) return message.edit(client.trad(
      `You do not have the necessary permissions to run this command`,
      `Vous n'avez pas les permissions nécessaires pour executer cette commande`
    ))
    
    const member = message.mentions.members.first() || message.guild.members.cache.get(args[0]) || await message.guild.members.fetch(args[0]).catch(() => false)
    if (!member) return message.edit(client.trad(
      `Aucun membre de trouvé pour \`${args[0] || "rien"}\``,
      `No member found for \`${args[0] || "nothing"}\``
    ))
    member
    .kick()
    .then(() => message.edit(client.trad(
        `${member.user.username} has been **kick**`,
        `${member.user.username} a été **kick**`,)
      ))
      .catch(() => message.edit(client.trad(
        `${member.user.username} n'a pas pu être **kick**`,
        `${member.user.username} cannot be **kick**`
      )));  }
}