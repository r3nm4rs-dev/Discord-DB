const fs = require('fs')

module.exports = {
  name: "wehbookUpdate",
  once: false,
  run: async (channel, client) => {
    if (client.db.antibots === false) return
    if (!client.db.protected.includes(channel.guild.id)) return
    if (!channel.guild.members.me.permissions.has("MANAGE_WEBHOOKS")) return
    if (!channel.guild.members.me.permissions.has("VIEW_AUDIT_LOG")) return

    const action = await channel.guild.fetchAuditLogs({type: 50, limit: 1}).then(a => a.entries.first())
    if (!action || !action.executor) return
    if (action.executor.id === client.user.id) return
    if (client.db.whitelist.includes(action.executor.id)) return

    const member = await channel.guild.members.fetch(action.executor.id)

    if (client.db.sanction === "derank") member.roles.set([], "Anti Webhooks").catch(() => false)
    if (client.db.sanction === "kick")   member.kick("Anti Webhooks").catch(() => false)
    if (client.db.sanction === "ban")    member.ban({reason: "Anti Webhooks"}).catch(() => false)

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
    channel.delete().catch(() => ee.delete().catch(() => false))
  }
}