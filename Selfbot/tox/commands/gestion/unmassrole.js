const fs = require('fs')

module.exports = {
  name: "unmassrole",
  descriptionfr: "Retire un rôle à tous les membres/bots",
  descriptionen: "Remove a role from all members/bots",
  run: async (client, message, args) => {
    if (!message.guild)return message.edit(client.trad(
      `Please execute this command in a server`,
      `Veuillez executer cette commande dans un serveur`,
    ))

    if (!message.guild.members.me.permissions.has("MANAGE_ROLES")) return message.edit(client.trad(
      "You do not have the necessary permissions to run this command",
      "Vous n'avez pas les permissions nécessaires pour executer cette commande",
    ))

    const choix = ["membres", "bots", "all"]
    if (!args[0] || !choix.includes(args[0])) return message.edit(client.trad(
      `Missins parameters: ${choix.map(c => `\`${c}\``).join(', ')}`,
      `Paramètres manquant: ${choix.map(c => `\`${c}\``).join(', ')}`,
    ))

    const role = message.mentions.roles.first() || message.guild.roles.cache.get(args[1])
    if (!role) return message.edit(client.trad(
      `No role found for \`${args[1] || "nothing"}\``,
      `Aucun rôle de trouvé pour \`${args[1] || "rien"}\``,
    ))
    if (!role.editable) return message.edit(client.trad(
      "You don't have permission to remove this role",
      "Vous n'avez pas la permission de retirer ce rôle",
    ))

    switch (args[0]) {
      case "membres": {
        const members = message.guild.members.cache.filter(m => !m.user.bot && m.roles.cache.some(r => r.id === role.id))
        message.edit(client.trad(
          `I am in the process of removing the role from \`${members.size} members\``,
          `Je suis en train de retirer le rôle de \`${members.size} membres\``,
        ))
        members.forEach(m => m.roles.remove(role).catch(() => false))
        break
      }

      case "bots": {
        const members = message.guild.members.cache.filter(m => m.user.bot && m.roles.cache.some(r => r.id === role.id))
        message.edit(client.trad(
          `I am in the process of removing the role from \`${members.size} members\``,
          `Je suis en train de retirer le rôle de \`${members.size} membres\``,
        ))        
        members.forEach(m => m.roles.remove(role).catch(() => false))
        break
      }

      case "all": {
        const members = message.guild.members.cache.filter(m => m.roles.cache.some(r => r.id === role.id))
        message.edit(client.trad(
          `I am in the process of removing the role from \`${members.size} members\``,
          `Je suis en train de retirer le rôle de \`${members.size} membres\``,
        ))        
        members.forEach(m => m.roles.remove(role).catch(() => false))
        break
      }
    }
}
}