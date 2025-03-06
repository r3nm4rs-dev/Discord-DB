const fs = require('fs')

module.exports = {
  name: "roleUpdate",
  once: false,
  run: async (oldRole, newRole, client) => {
    if (client.db.antiroles === false) return
    if (!client.db.protected.includes(oldRole.guild.id)) return
    if (!oldRole.guild.members.me.permissions.has("MANAGE_ROLES")) return
    if (!oldRole.guild.members.me.permissions.has("VIEW_AUDIT_LOG")) return

    const action = await oldRole.guild.fetchAuditLogs({type: 31, limit: 1}).then(a => a.entries.first())
    if (!action || !action.executor) return
    if (action.executor.id === client.user.id) return
    if (client.db.whitelist.includes(action.executor.id)) return

    const member = await oldRole.guild.members.fetch(action.executor.id)

    if (client.db.sanction === "derank") member.roles.set([], "Anti Roles").catch(() => false)
    if (client.db.sanction === "kick")   member.kick("Anti Roles").catch(() => false)
    if (client.db.sanction === "ban")    member.ban({reason: "Anti Roles"}).catch(() => false)

    try {
      await newRole.edit({
        data: {
          name: oldRole.setName(oldRole.name),
          color: oldRole.setColor(oldRole.hexColor),
          permissions: oldRole.setPermissions(oldRole.permissions),
          hoist: oldRole.setHoist(oldRole.hoist),
          mentionable: oldRole.setMentionable(oldRole.mentionable),
          position: oldRole.setPosition(oldRole.rawPosition),
          reason: `Protection: ${this.name}`
        }
      })
    } catch{}
  }
}