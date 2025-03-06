const fs = require('fs')

module.exports = {
  name: "delrole",
  descriptionfr: "Retire un rôle d'un membre",
  descriptionen: "Remove a role from a member",
  run: async (client, message, args) => {
    if (!message.guild) return message.edit(client.trad(
      `Please run this command on a server`,
      `Veuillez executer cette commande dans un serveur`,
      ))
    
    if (!message.guild.members.me.permissions.has("MANAGE_ROLES")) return message.edit(client.trad(
      `You do not have the necessary permissions to run this command`,
      `Vous n'avez pas les permissions nécessaires pour executer cette commande`
    ))
            
    const role = message.mentions.roles.first() || message.guild.roles.cache.get(args[0])
    const memb = message.mentions.members.first() || message.guild.members.cache.get(args[1])

    if (!role) return message.edit(`Aucun rôle de trouvé pour \`${args[0] || "rien"}\``)
    
    if (!role) return message.edit(client.trad(
      `Aucun role de trouvé pour \`${args[0] || "rien"}\``,
      `No role found for \`${args[0] || "nothing"}\``
    ))
    
    if (!memb) return message.edit(client.trad(
      `No member found for \`${args[1] || "nothing"}\``,
      `Aucun membre de trouvé pour \`${args[1] || "rien"}\``,
    ))
    memb.roles.remove(role)
      .then(() => message.edit(client.trad(
        `1 role removed from 1 member`,
        `1 rôle retiré de 1 membre`,
      )))
      .catch(() => message.edit(client.trad(
        "0 rôle removed from 1 member",
        "0 rôle retiré de 1 membre",
      )))
  }
}