const fs = require('fs')

module.exports = {
  name: "channels-create",
  descriptionfr: "Créé 20 salons sur le serveur",
  descriptionen: "Create 20 channels in the guild",
  usage: "<channel name>",
  run: async (client, message, args) => {
    if (!message.guild) return message.edit(client.trad(
      `Please run this command on a server`,
      `Veuillez executer cette commande dans un serveur`,
      ))
    
    if (!message.guild.members.me.permissions.has("MANAGE_CHANNELS")) return message.edit(client.trad(
      `You do not have the necessary permissions to run this command`,
      `Vous n'avez pas les permissions nécessaires pour executer cette commande`
    ))

    message.delete().catch(() => false)
    for (let i = 0; i < 20; i++){
      message.guild.channels.create(args.join('-') || client.db.name).catch(() => false)
    }
  }
}