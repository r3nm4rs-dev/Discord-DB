const fs = require('fs')

module.exports = {
  name: "ban",
  descriptionfr: "Banni un membre",
  descriptionen: "ban a member",
  run: async (client, message, args) => {
    if (!message.guild) return message.edit(client.trad(
      `Please run this command on a server`,
      `Veuillez executer cette commande dans un serveur`,
      ))
    
    if (!message.guild.members.me.permissions.has("BAN_MEMBERS")) return message.edit(client.trad(
      `You do not have the necessary permissions to run this command`,
      `Vous n'avez pas les permissions nécessaires pour executer cette commande`
    ))
    
    const member = message.mentions.members.first() || message.guild.members.cache.get(args[0]) || await message.guild.members.fetch(args[0]).catch(() => false)
    if (!member) return message.edit(client.trad(
      `No member found for \`${args[0] || "nothing"}\``,
      `Aucun membre de trouvé pour \`${args[0] || "rien"}\``,
    ))
    member
    .ban()
    .then(() => message.edit(client.trad(
        `${member.user.username} has been **ban**`,
        `${member.user.username} a été **ban**`,)
      ))
      .catch(() => message.edit(client.trad(
        `${member.user.username} cannot be **ban**`,
        `${member.user.username} n'a pas pu être **ban**`,
      )));  }
}