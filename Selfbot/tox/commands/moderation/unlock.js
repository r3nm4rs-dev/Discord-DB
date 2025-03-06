const fs = require('fs')

module.exports = {
  name: "unlock",
  descriptionfr: "Dévérouille un salon",
  descriptionen: "Unlock a channel",
  run: async (client, message, args) => {
    if (!message.guild) return message.edit(client.trad(
      `Please run this command on a server`,
      `Veuillez executer cette commande dans un serveur`,
      ))
    
    if (!message.guild.members.me.permissions.has("MANAGE_ROLES")) return message.edit(client.trad(
      `You do not have the necessary permissions to run this command`,
      `Vous n'avez pas les permissions nécessaires pour executer cette commande`
    ))
            
    const channel = message.mentions.channels.first() || message.guild.channels.cache.get(args[0]) || message.channel
    if (!channel) return message.edit(client.trad(
      `No channel found for \`${args[0] || "nothing"}\``,
      `Aucun salon de trouvé pour \`${args[0] || "rien"}\``,
    ))

    channel.permissionOverwrites.edit(message.guild.id, {
      SEND_MESSAGES: null,
    })
    message.edit(client.trad(
      `The channel <#${channel.id}> is **unlock**`,
      `le salon <#${channel.id}> a été **unlock**`,
    ))

  }
}