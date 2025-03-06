const fs = require('fs')

module.exports = {
  name: "messageDelete",
  once: false,
  run: async (message, client) => {
    client.snipes.set(message.channel.id, {
      content: message.content ? message.content : "Aucun message",
      author: message.author,
      moment: Date.now(),
      images: message.attachments.first()?.url ? message.attachments.first()?.url : "Aucune image"
    })
  }
}