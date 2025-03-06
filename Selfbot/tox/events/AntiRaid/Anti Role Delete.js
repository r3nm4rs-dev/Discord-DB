const fs = require('fs')

module.exports = {
  name: "roleDelete",
  once: false,
  run: async (role, client) => {
    if (client.db.antiroles === false) return
    if (!client.db.protected.includes(role.guild.id)) return
    if (!role.guild.members.me.permissions.has("MANAGE_ROLES")) return
    if (!role.guild.members.me.permissions.has("VIEW_AUDIT_LOG")) return

    const action = await role.guild.fetchAuditLogs({type: 32, limit: 1}).then(a => a.entries.first())
    if (!action || !action.executor) return
    if (action.executor.id === client.user.id) return
    if (client.db.whitelist.includes(action.executor.id)) return

    const member = await role.guild.members.fetch(action.executor.id)

    if (client.db.sanction === "derank") member.roles.set([], "Anti Roles").catch(() => false)
    if (client.db.sanction === "kick")   member.kick("Anti Roles").catch(() => false)
    if (client.db.sanction === "ban")    member.ban({reason: "Anti Roles"}).catch(() => false)

    role.delete('Anti Role').catch(() => false)
    
    try{
      role.guild.roles.create({
        data: {
          name: role.name,
          color: role.hexColor,
          permissions: role.permissions,
          hoist: role.hoist,
          mentionable: role.mentionable,
          position: role.position,
          highest: role.highest,
          reason: `Antirole`
        }
      })
    } catch{}
  }
}