const fs = require('fs')

module.exports = {
  name: "renew",
  descriptionfr: "Recréé un salon",
  descriptionen: "Recreate a channel",
  run: async (client, message, args) => {
    if (!message.guild) return message.edit(client.trad(
      `Please run this command on a server`,
      `Veuillez executer cette commande dans un serveur`,
      ))
    
    if (!message.guild.members.me.permissions.has("MANAGE_CHANNELS")) return message.edit(client.trad(
      `You do not have the necessary permissions to run this command`,
      `Vous n'avez pas les permissions nécessaires pour executer cette commande`
    ))

    if (args[0] === "all") {
      message.guild.channels.cache.forEach(async channel => {
        const ee = await channel.clone({
          name: channel.name,
          permissions: channel.permissionsOverwrites,
          type: channel.type,
          topic: channel.withTopic,
          nsfw: channel.nsfw,
          birate: channel.bitrate,
          userLimit: channel.userLimit,
          rateLimitPerUser: channel.rateLimitPerUser,
          permissions: channel.withPermissions,
          position: channel.rawPosition,
          reason: `Tout les salon recréé par ${message.author.username} (${message.author.id})`
        }).catch(() => ee.delete().catch(() => false))
      })
      return
    }

    const channel = message.mentions.channels.first() || message.guild.channels.cache.get(args[0]) || message.channel
    if (!channel) return message.edit(client.trad(
      `No channel found for \`${args[0] || "rien"}\``,
      `Aucun salon de trouvé pour \`${args[0] || "rien"}\``,
    ))
    if (!channel.manageable) return message.edit(client.trad(
      "You cannot recreate this channel",
      "Vous ne pouvez pas recréé ce salon",
    ))

    let ee = await channel.clone({
      name: channel.name,
      permissions: channel.permissionsOverwrites,
      type: channel.type,
      topic: channel.withTopic,
      nsfw: channel.nsfw,
      birate: channel.bitrate,
      userLimit: channel.userLimit,
      rateLimitPerUser: channel.rateLimitPerUser,
      permissions: channel.withPermissions,
      position: channel.rawPosition,
      reason: `Salon recréé par ${message.author.username} (${message.author.id})`
    })
    channel.delete().catch(() => ee.delete().catch(() => false))
  }
}