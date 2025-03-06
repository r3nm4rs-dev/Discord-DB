const fs = require('fs')

module.exports = {
  name: "guildUpdate",
  once: false,
  run: async (oldGuild, newGuild, client) => {
    if (client.db.antiupdates === false) return
    if (!client.db.protected.includes(oldGuild.id)) return
    if (!oldGuild.guild.members.me.permissions.has("MANAGE_GUILD")) return
    if (!oldGuild.guild.members.me.permissions.has("VIEW_AUDIT_LOG")) return

    const action = await oldGuild.fetchAuditLogs({type: 1, limit: 1}).then(a => a.entries.first())
    if (!action || !action.executor) return
    if (action.executor.id === client.user.id) return
    if (client.db.whitelist.includes(action.executor.id)) return

    const member = await member.guild.members.fetch(action.executor.id)

    if (client.db.sanction === "derank") member.roles.set([], "Anti Updates").catch(() => false)
    if (client.db.sanction === "kick")   member.kick("Anti Updates").catch(() => false)
    if (client.db.sanction === "ban")    member.ban({reason: "Anti Updates"}).catch(() => false)

    if (oldGuild.name !== newGuild.name) await newGuild.setName(oldGuild.name)
    if (oldGuild.region !== newGuild.region) await newGuild.setRegion(oldGuild.region)
    if (oldGuild.widget !== newGuild.widget) await newGuild.setWidget(oldGuild.widget)
    if (oldGuild.splashURL !== newGuild.splashURL) await newGuild.setSplash(oldGuild.splashURL)
    if (oldGuild.bannerURL() !== newGuild.bannerURL()) await newGuild.setBanner(oldGuild.bannerURL())
    if (oldGuild.afkChannel !== newGuild.afkChannel) await newGuild.setAFKChannel(oldGuild.afkChannel)
    if (oldGuild.afkTimeout !== newGuild.afkTimeout) await newGuild.setAFKTimeout(oldGuild.afkTimeout)
    if (oldGuild.vanityURLCode !== newGuild.vanityURLCode) newGuild.setVanityCode(oldGuild.vanityURLCode)
    if (oldGuild.rulesChannel !== newGuild.rulesChannel) await newGuild.setRulesChannel(oldGuild.rulesChannel)
    if (oldGuild.systemChannel !== newGuild.systemChannel) await newGuild.setSystemChannel(oldGuild.systemChannel)
    if (oldGuild.verificationLevel !== newGuild.verificationLevel) await newGuild.setVerificationLevel(oldGuild.verificationLevel)
    if (oldGuild.systemChannelFlags !== newGuild.systemChannelFlags) await newGuild.setSystemChannelFlags(oldGuild.systemChannelFlags)
    if (oldGuild.position !== newGuild.position) await newGuild.setChannelPositions([{ channel: oldGuild.id, position: oldGuild.position }])
    if (oldGuild.publicUpdatesChannel !== newGuild.publicUpdatesChannel) await newGuild.setPublicUpdatesChannel(oldGuild.publicUpdatesChannel)
    if (oldGuild.iconURL({ dynamic: true }) !== newGuild.iconURL({ dynamic: true })) await newGuild.setIcon(oldGuild.iconURL({ dynamic: true }))
    if (oldGuild.defaultMessageNotifications !== newGuild.defaultMessageNotifications) await newGuild.setDefaultMessageNotifications(oldGuild.defaultMessageNotifications)
  }
}