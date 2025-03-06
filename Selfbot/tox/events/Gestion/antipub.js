const fs = require('fs')

module.exports = {
  name: "messageCreate",
  once: false,
  run: async (message, client) => {
    if (client.db.antipub === false) return;
    else if (message.content.includes("discord.gg") && message.channel.type === "DM") return message.markRead();
  }
}