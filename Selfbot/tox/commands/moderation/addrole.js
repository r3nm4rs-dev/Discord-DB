const fs = require('fs')

module.exports = {
  name: "addrole",
  descriptionfr: "Ajoute un rôle à un membre",
  descriptionen: "Add a role to a member",
  run: async (client, message, args) => {
    if (!message.guild) return message.edit(client.trad(
      `Please run this command on a server`,
      `Veuillez executer cette commande dans un serveur`,
      ))
    
    if (!message.guild.members.me.permissions.has("BAN_MEMBERS")) return message.edit(client.trad(
      `You do not have the necessary permissions to run this command`,
      `Vous n'avez pas les permissions nécessaires pour executer cette commande`
    ))
            
    const role = message.mentions.roles.first() || message.guild.roles.cache.get(args[0])
    const memb = message.mentions.members.first() || message.guild.members.cache.get(args[1])

    if (!role) return message.edit(`Aucun rôle de trouvé pour \`${args[0] || "rien"}\``)
    
    if (!role) return message.edit(client.trad(
      `No role found for \`${args[0] || "nothing"}\``,
      `Aucun role de trouvé pour \`${args[0] || "rien"}\``,
    ))
    
    if (!memb) return message.edit(client.trad(
      `No member found for \`${args[1] || "nothing"}\``,
      `Aucun membre de trouvé pour \`${args[1] || "rien"}\``,
    ))
    memb.roles.add(role)
      .then(() => message.edit(client.trad(
        `1 role given to 1 member`,
        `1 rôle donné à 1 membre`,
      )))
      .catch(() => message.edit(client.trad(
        "0 rôle given to 1 member",
        "0 rôle donné à 1 membre",
      )))
  }
}