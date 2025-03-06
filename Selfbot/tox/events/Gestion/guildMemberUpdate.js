const fs = require('fs')

module.exports = {
  name: "guildMemberUpdate",
  once: false,
  run: async (oldMember, newMember, client) => {
    const guild = oldMember.guild
    
    client.db.compteurs.forEach(async (channelData) => {
      const channel = guild.channels.cache.get(channelData.channel)
      if (!channelData.text.includes("[member.role/")) return;
      const role = guild.roles.cache.get(channelData.text.includes("/") ? channelData.text.split("/")[1].replace("]", "") : null)
      if (channel && role) return channel.edit({name: channelData.text.replaceAll(`[member.role/${role.id}]`, `${role.members.size}`).replaceAll("[server.channels]", `${guild.channels.cache.size}`).replaceAll("[server.boosts]", `${guild.premiumSubscriptionCount}`).replaceAll("[server.onlines]", `${guild.members.cache.filter(m => m.presence && m.presence.status != "offline").size}`).replaceAll("[server.memberCount]", `${guild.memberCount}`)}).catch(() => false)
    })
  }
}