const fs = require('fs')

module.exports = {
  name: "derank",
  descriptionfr: "Retire tous les rôles d'un membre",
  descriptionen: "Remove all roles from a member",
  run: async (client, message, args) => {
    if (!message.guild) return message.edit(client.trad(
      `Please run this command on a server`,
      `Veuillez executer cette commande dans un serveur`,
      ))
    
    if (!message.guild.members.me.permissions.has("MANAGE_ROLES")) return message.edit(client.trad(
      `You do not have the necessary permissions to run this command`,
      `Vous n'avez pas les permissions nécessaires pour executer cette commande`
    ))
            
    const memb = message.mentions.members.first() || message.guild.members.cache.get(args[0])

    if (!memb) return message.edit(client.trad(
      `No member found for \`${args[0] || "nothing"}\``,
      `Aucun membre de trouvé pour \`${args[0] || "rien"}\``,
    ))

    memb.roles.set([])
      .then(() => message.edit(client.trad
        `<@${memb.id}> has been **unrank**`,
        `<@${memb.id}> a été **derank**`,
      ))
      .catch(() => message.edit(client.trad(
        `<@${memb.id}> cannot be **unrank**`,
        `<@${memb.id}> ne peut pas être **derank**`,
      )))
  }
}