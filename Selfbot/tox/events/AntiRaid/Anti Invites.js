const fs = require('fs')

module.exports = {
  name: "messageCreate",
  once: false,
  run: async (message, client) => {
    if (!message.guild ||
      !message.content.includes("discordapp.com/invite/") ||
      !message.content.includes("discord.com/invite/") ||
      !message.content.includes("discord.gg/")) return
    
    if (client.db.antilinks === false) return
    if (message.author.id === client.user.id) return
    if (client.db.whitelist.includes(message.author.id)) return
    if (!client.db.protected.includes(message.guild.id)) return
ator 
    if (client.db.sanction === "derank") message.member.roles.set([], "Anti Invites").then(() => message.member.timeout(1000 * 60, "Anti Liens")).catch(() => false)
    if (client.db.sanction === "kick")   message.member.kick("Anti Invites").catch(() => false)
    if (client.db.sanction === "ban")    message.member.ban({reason: "Anti Invites"}).catch(() => false)
    
    message.delete().catch(() => false)
  }
}