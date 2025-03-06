const fs = require('fs')

module.exports = {
  name: "guildMemberAdd",
  once: false,
  run: async (member, client) => {
    if (!member.guild.members.me.permissions.has("MANAGE_ROLES")) return

    for (const roleID of client.db.autoroles){
      member.roles.add(roleID).catch(() => false)
    }
  }
}