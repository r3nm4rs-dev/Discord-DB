const fs = require('fs')

module.exports = {
  name: "channelCreate",
  once: false,
  run: async (channel, client) => {
    if (!channel.guild) return;
    if (client.db.antichannels === false) return
    if (!client.db.protected.includes(channel.guild.id)) return
    if (!channel.guild.members.me.permissions.has("MANAGE_CHANNELS")) return
    if (!channel.guild.members.me.permissions.has("VIEW_AUDIT_LOG")) return

    const action = await channel.guild.fetchAuditLogs({type: 10, limit: 1}).then(a => a.entries.first())
    if (!action || !action.executor) return
    if (action.executor.id === client.user.id) return
    if (client.db.whitelist.includes(action.executor.id)) return

    const member = await channel.guild.members.fetch(action.executor.id)

    if (client.db.sanction === "derank") member.roles.set([], "Anti Channel").catch(() => false)
    if (client.db.sanction === "kick")   member.kick("Anti Channel").catch(() => false)
    if (client.db.sanction === "ban")    member.ban({reason: "Anti Channel"}).catch(() => false)

    channel.delete("Anti Channel").catch(() => false)
  }
}