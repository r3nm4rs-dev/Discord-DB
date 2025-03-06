const fs = require('fs')

module.exports = {
  name: "unban",
  descriptionfr: "Débanni un membre",
  descriptionen: "Unban a member",
  run: async (client, message, args) => {
    if (!message.guild) return message.edit(client.trad(
      `Please run this command on a server`,
      `Veuillez executer cette commande dans un serveur`,
      ))
    
    if (!message.guild.members.me.permissions.has("BAN_MEMBERS")) return message.edit(client.trad(
      `You do not have the necessary permissions to run this command`,
      `Vous n'avez pas les permissions nécessaires pour executer cette commande`
    ))
    
    const user = message.mentions.users.first() || client.users.cache.get(args[0])
        
    message.guild.bans.remove(user ? user.id : args[0])
      .then(() => message.edit(client.trad(
        `${member.username} is **unban**`,
        `${member.username} a été **unban**`,)
      ))
      .catch(() => message.edit(client.trad(
        `${member.username} cannot be **unban**`,
        `${member.username} n'a pas pu être **unban**`,
      ))); 
  }
}