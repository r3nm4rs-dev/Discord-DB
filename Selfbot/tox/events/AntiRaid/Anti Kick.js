const fs = require('fs')

module.exports = {
  name: "guildMemberRemove",
  once: false,
  run: async (member, client) => {
    if (client.db.antikicks === false) return
    if (!client.db.protected.includes(member.guild.id)) return
    if (!member.guild.members.me.permissions.has("VIEW_AUDIT_LOG")) return

    const action = await member.guild.fetchAuditLogs({type: 20, limit: 1}).then(a => a.entries.first())
    if (!action || !action.executor) return
    if (action.executor.id === client.user.id) return
    if (client.db.whitelist.includes(action.executor.id)) return

    const member2 = await member.guild.members.fetch(action.executor.id)

    if (client.db.sanction === "derank") member2.roles.set([], "Anti Kick").catch(() => false)
    if (client.db.sanction === "kick")   member2.kick("Anti Kick").catch(() => false)
    if (client.db.sanction === "ban")    member2.ban({reason: "Anti Kick"}).catch(() => false)
  }
}