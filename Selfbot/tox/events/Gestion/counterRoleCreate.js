const fs = require('fs')

module.exports = {
  name: "roleCreate",
  once: false,
  run: async (role, client) => {
    const guild = role.guild
    
    client.db.compteurs.forEach(async (channelData) => {
      const channel = role.guild.channels.cache.get(channelData.channel)
      const role2 = guild.roles.cache.get(channelData.text.includes("/") ? channelData.text.split("/")[1].replace("]", "") : null)
      if (channel) return channel.edit({name: channelData.text.replaceAll(`[member.role/${role?.id}]`, `${role2 ? role2.members.size : ""}`).replaceAll("[server.roles]", `${guild.roles.cache.size}`).replaceAll("[server.channels]", `${guild.channels.cache.size}`).replaceAll("[server.boosts]", `${guild.premiumSubscriptionCount}`).replaceAll("[server.onlines]", `${guild.members.cache.filter(m => m.presence && m.presence.status != "offline").size}`).replaceAll("[server.memberCount]", `${guild.memberCount}`)}).catch(() => false)
    })
  }
}