const fs = require('fs')

module.exports = {
  name: "unautorole",
  descriptionfr: "Retire un rôle de l'autorole",
  descriptionen: "Remove a role from autorole",
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
    if (!role) {
      if (!client.db.autoroles.includes(args[0])) return message.edit(client.trad(
        `No role found for \`${args[0] || "nothing"}\``,
        `Aucun rôle de trouvé pour \`${args[0] || "rien"}\``,
      ))
      client.db.autoroles.splice(client.db.autoroles.indexOf(args[0]), 1)
      client.save()
      return message.edit(client.trad(`This role has been removed from the autorole`, `Ce rôle a été retiré de l'autorole`,))
    }

    if (!client.db.autoroles.includes(role.id)) return message.edit(client.trad(
      `This role is not part of the auto roles`,
      `Ce rôle ne fait pas partie de l'auto roles`,
    ))
    client.db.autoroles.splice(client.db.autoroles.indexOf(user.id), 1)

    client.save()

    message.edit(client.trad(
      `The role **${role.name}** will no longer be given to new members`,
      `Le rôle **${role.name}** ne sera plus donné aux nouveaux membres`,
    ))
  }
}