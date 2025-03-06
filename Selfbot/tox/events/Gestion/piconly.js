const fs = require('fs')

module.exports = {
  name: "messageCreate",
  once: false,
  run: async (message, client) => {
    if (!message.member) return
    if (message.member.permissions.has("MANAGE_MESSAGES")) return
    if (!client.db.chpiconly.includes(message.channel.id)) return
    if (message.author.id === client.user.id) return
    if (message.attachments.first()?.url) return

    message.delete()
      .then(() => message.channel.send(`<@${message.author.id}> Vous devez envoyer une image sur ce salon`).then(m => setTimeout(() => m.delete().catch(() => false), 5000)))
      .catch(() => false)
  }
}