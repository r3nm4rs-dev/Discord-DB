const fs = require('fs')

module.exports = {
  name: "guildMemberAdd",
  once: false,
  run: async (member, client) => {

    if (!client.db.blacklist.includes(member.id)) return

    member.guild.bans.create(member.id, {
      reason: "Blacklist"
    }).catch(() => false)
  }
}