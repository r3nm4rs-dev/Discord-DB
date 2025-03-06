const fs = require('fs')

module.exports = {
  name: "channelCreate",
  once: false,
  run: async (channel, client) => {
    if (channel.type !== "GROUP_DM") return
    if (client.db.antigroups === false) return
    if (client.db.antigroups === true) channel.delete().catch(() => false)
    else channel.send(client.db.antigroups).then(() => channel.delete(client.db.silentgroup).catch(() => false))
  }
}