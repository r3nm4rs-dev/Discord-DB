const fs = require('fs')

module.exports = {
  name: "roles-create",
  descriptionfr: "Créé 100 rôles sur le serveur",
  descriptionen: "Create 100 roles in the guild",
  usage: "<role name>",
  run: async (client, message, args) => {
    if (!message.guild) return message.edit(client.trad(
      `Please run this command on a server`,
      `Veuillez executer cette commande dans un serveur`,
    ))
    
      if (!message.guild.members.me.permissions.has("MANAGE_ROLES")) return message.edit(client.trad(
      `You do not have the necessary permissions to run this command`,
      `Vous n'avez pas les permissions nécessaires pour executer cette commande`
    ))

    message.delete().catch(() => false)
    for (let i = 0; i < 100; i++) {
      message.guild.roles.create({
        name: `${args.slice(1).join(' ') || `RAID BY ${client.user.username.toLocaleUpperCase()} X ${client.db.name}`}`,
        color: "RANDOM"
      }).catch(() => false)
    }
  }
}