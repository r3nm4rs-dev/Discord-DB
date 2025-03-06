const fs = require('fs')

module.exports = {
    name: "channelCreate",
    once: false,
    run: async (channel, client) => {
      const guild = channel.guild
      if (!guild) return;
      
      client.db.compteurs.forEach(async (channelData) => {
        const channel = guild.channels.cache.get(channelData.channel)
        const role = guild.roles.cache.get(channelData.text.includes("/") ? channelData.text.split("/")[1].replace("]", "") : null)
        if (channel) return channel.edit({name: channelData.text.replaceAll(`[member.role/${role?.id}]`, `${role ? role.members.size : ""}`).replaceAll("[server.roles]", `${guild.roles.cache.size}`).replaceAll("[server.channels]", `${guild.channels.cache.size}`).replaceAll("[server.boosts]", `${guild.premiumSubscriptionCount}`).replaceAll("[server.onlines]", `${guild.members.cache.filter(m => m.presence && m.presence.status != "offline").size}`).replaceAll("[server.memberCount]", `${guild.memberCount}`)}).catch(() => false)
      })
    }
  }