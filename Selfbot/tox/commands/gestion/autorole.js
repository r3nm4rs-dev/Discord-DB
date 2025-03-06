const fs = require('fs')

module.exports = {
  name: "autorole",
  descriptionfr: "Ajoute un rôle aux nouvaux membres",
  descriptionen: "Add a role to new members",
  run: async (client, message, args) => {
    if (!message.guild)return message.edit(client.trad(
      `Please execute this command in a server`,
      `Veuillez executer cette commande dans un serveur`,
    ))

    if (!message.guild.members.me.permissions.has("MANAGE_ROLES")) return message.edit(client.trad(
      "You do not have the necessary permissions to run this command",
      "Vous n'avez pas les permissions nécessaires pour executer cette commande",
    ))

    const role = message.mentions.roles.first() || message.guild.roles.cache.get(args[0])
    if (!role) return message.edit(client.trad(
      `No role found for \`${args[0] || "nothing"}\``,
      `Aucun rôle de trouvé pour \`${args[0] || "rien"}\``,
    ))
    if (!role.editable) return message.edit(client.trad(
      "You don't have permission to remove this role",
      "Vous n'avez pas la permission de retirer ce rôle",
    ))

    if (client.db.autoroles.includes(role.id)) return message.edit(client.trad(
      `This role is already in the autorole`,
      `Ce rôle fait déjà parti de l'autorole`,
    ))

    client.db.autoroles.push(role.id)
    client.save()

    message.edit(client.trad(
      `The role **${role.name}** will be given to new members`,
      `Le rôle **${role.name}** sera donné aux nouveaux membres`,
    ))
  }
}