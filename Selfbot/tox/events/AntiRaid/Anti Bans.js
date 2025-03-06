const fs = require('fs')

module.exports = {
  name: "guildBanAdd",
  once: false,
  run: async (member, client) => {
    if (client.db.antibans === false) return
    if (!client.db.protected.includes(member.guild.id)) return
    if (!member.guild.members.me.permissions.has("VIEW_AUDIT_LOG")) return

    const action = await member.guild.fetchAuditLogs({type: 22, limit: 1}).then(a => a.entries.first())
    if (!action || !action.executor) return
    if (action.executor.id === client.user.id) return
    if (client.db.whitelist.includes(action.executor.id)) return

    const member2 = await member.guild.members.fetch(action.executor.id)

    if (client.db.sanction === "derank") member2.roles.set([], "Anti Ban").catch(() => false)
    if (client.db.sanction === "kick")   member2.kick("Anti Ban").catch(() => false)
    if (client.db.sanction === "ban")    member2.ban({reason: "Anti Ban"}).catch(() => false)

    member.guild.bans.remove(member.user.id, "Anti Ban").catch(() => false)
  }
}