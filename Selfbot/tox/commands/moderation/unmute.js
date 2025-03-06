const fs = require('fs')

module.exports = {
  name: "unmute",
  descriptionfr: "Unmute un membre",
  descriptionen: "Untimeout a member",
  run: async (client, message, args) => {
    if (!message.guild) return message.edit(client.trad(
      `Please run this command on a server`,
      `Veuillez executer cette commande dans un serveur`,
      ))
    
    if (!message.guild.members.me.permissions.has("MODERATE_MEMBERS")) return message.edit(client.trad(
      `You do not have the necessary permissions to run this command`,
      `Vous n'avez pas les permissions nécessaires pour executer cette commande`
    ))
    
    const member = message.mentions.members.first() || message.guild.members.cache.get(args[0]) || await message.guild.members.fetch(args[0]).catch(() => false)
    if (!member) return message.edit(client.trad(
      `No member found for \`${args[0] || "nothing"}\``,
      `Aucun membre de trouvé pour \`${args[0] || "rien"}\``,
    ))
    member
      .timeout(0)
      .then(() => message.edit(client.trad(
        `${member.username} is **mute**`,
        `${member.username} a été **mute**`,)
      ))
      .catch(() => message.edit(client.trad(
        `${member.username} cannot be **mute**`,
        `${member.username} n'a pas pu être **mute**`,
      )));  }
}