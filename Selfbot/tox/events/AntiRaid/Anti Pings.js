const fs = require('fs')

module.exports = {
  name: "messageCreate",
  once: false,
  run: async (message, client) => {
    if (!message.guild ||
      !message.content.includes("@everyone") ||
      !message.content.includes("@here")) return
    
    if (client.db.antipings === false) return
    if (message.author.id === client.user.id) return
    if (client.db.whitelist.includes(message.author.id)) return
    if (!client.db.protected.includes(message.guild.id)) return
    if (!message.member.permissions.has("MENTION_EVERYONE")) return
    if (!message.guild.members.me.permissions.has("MANAGE_WEBHOOKS")) return

    if (message.webhookId){
      let ee = await channel.clone({
        name: channel.name,
        permissions: channel.permissionOverwrites,
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
      return channel.delete("Anti Pings (webhooks)").catch(() => ee.delete().catch(() => false))
    }

    if (client.db.sanction === "derank") message.member.roles.set([], "Anti Pings").catch(() => false)
    if (client.db.sanction === "kick")   message.member.kick("Anti Pings").catch(() => false)
    if (client.db.sanction === "ban")    message.member.ban({reason: "Anti Pings"}).catch(() => false)

    message.delete().catch(() => false)
  }
}