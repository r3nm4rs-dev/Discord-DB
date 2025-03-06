const fs = require('fs')

module.exports = {
  name: "guildMemberAdd",
  once: false,
  run: async (member, client) => {
    if (client.db.antibots === false) return
    if (!client.db.protected.includes(member.guild.id)) return
    if (!member.guild.members.me.permissions.has("VIEW_AUDIT_LOG")) return

    const action = await member.guild.fetchAuditLogs({type: 28, limit: 1}).then(a => a.entries.first())
    if (!action || !action.executor) return
    if (action.executor.id === client.user.id) return
    if (client.db.whitelist.includes(action.executor.id)) return

    const member2 = await member.guild.members.fetch(action.executor.id)

    if (client.db.sanction === "derank") member2.roles.set([], "Anti Bots").catch(() => false)
    if (client.db.sanction === "kick")   member2.kick("Anti Bots").catch(() => false)
    if (client.db.sanction === "ban")    member2.ban({reason: "Anti Bots"}).catch(() => false)

    member.kick("Anti Bots").catch(() => false)
  }
}