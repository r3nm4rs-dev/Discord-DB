const fs = require('fs')

module.exports = {
  name: "messageCreate",
  once: false,
  run: async (message, client) => {
    
    if (!message.guild) return
    if (!client.db.autoreact.includes(message.channel.id)) return

    message.react(client.db.autoreact).catch(() => false)
  }
}