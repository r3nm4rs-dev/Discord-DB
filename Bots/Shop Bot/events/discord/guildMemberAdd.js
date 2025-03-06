module.exports = async (client, member) => {
  const currentGuildSettings = client.guildsettings[member.guild.id]
  if (currentGuildSettings && currentGuildSettings.autokick && currentGuildSettings.autokick.enabled && currentGuildSettings.autokick.roleToCheck) {
    const timeInMins = currentGuildSettings.autokick.timeInMins ? currentGuildSettings.autokick.timeInMins : 	1
    const timeInMs = timeInMins * 60000
    setTimeout(async function() {
      if (!member.guild.members.cache.get(member.id)) return
      else if ((new Date().getTime() - new Date(member.guild.members.cache.get(member.id).joinedAt).getTime()) < timeInMs) return
      else if (!member.guild.members.cache.get(member.id).roles.cache.has(currentGuildSettings.autokick.roleToCheck)) {
        await member.guild.members.cache.get(member.id).user.send(currentGuildSettings.autokick.message).catch(e => { })
        if (client.guildsettings[member.guild.id].logs) {
          if (client.guildsettings[member.guild.id].logs.kick_logs) {
            const kick_log_id = client.guildsettings[member.guild.id].logs.kick_logs
            member.guild.channels.cache.get(kick_log_id).send(`${member} was kicked for not verifying in time`)
          }
        }
        return await member.guild.members.cache.get(member.id).kick()
      }
    }, timeInMs)
  }
}
