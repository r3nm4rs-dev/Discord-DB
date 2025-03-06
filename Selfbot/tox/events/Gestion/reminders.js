const fs = require('fs')

module.exports = {
  name: "messageCreate",
  once: false,
  run: async (message, client) => {
    setInterval(() => {
      const data = client.db.reminders.filter(d => d.moments <= Date.now())
      data.forEach(d => {
        const channel = client.channels.cache.get(d.channel)
        if (!channel) return; 
        channel.send(`<@${client.user.id}> ${d.content}`).then(m => m.markUnread()).catch(() => false)
        let data2 = client.db.reminders.filter(c => c.channel !== channel.id);
        client.db.reminders = data2
        client.save()
      })
    }, 1000)
  }
}