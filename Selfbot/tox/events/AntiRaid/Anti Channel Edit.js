const fs = require('fs');

module.exports = {
  name: "channelUpdate",
  once: false,
  run: async (oldChannel, newChannel, client) => {
    if (!oldChannel.guild) return; // Utilisation correcte de oldChannel
    if (client.db.antichannels === false) return;
    if (!client.db.protected.includes(oldChannel.guild.id)) return;
    if (!oldChannel.guild.members.me.permissions.has("MANAGE_CHANNELS")) return;
    if (!oldChannel.guild.members.me.permissions.has("VIEW_AUDIT_LOG")) return;

    const action = await oldChannel.guild.fetchAuditLogs({ type: 11, limit: 1 }).then(a => a.entries.first());
    if (!action || !action.executor) return;
    if (action.executor.id === client.user.id) return;
    if (client.db.whitelist.includes(action.executor.id)) return;

    const member = await oldChannel.guild.members.fetch(action.executor.id);

    if (client.db.sanction === "derank") member.roles.set([], "Anti Channel").catch(() => false);
    if (client.db.sanction === "kick") member.kick("Anti Channel").catch(() => false);
    if (client.db.sanction === "ban") member.ban({ reason: "Anti Channel" }).catch(() => false);

    try {
      newChannel.edit({
        name: oldChannel.name,
        permissions: oldChannel.permissionsOverwrites,
        type: oldChannel.type,
        topic: oldChannel.withTopic,
        nsfw: oldChannel.nsfw,
        bitrate: oldChannel.bitrate,
        userLimit: oldChannel.userLimit,
        rateLimitPerUser: oldChannel.rateLimitPerUser,
        position: oldChannel.rawPosition,
        reason: `Antichannel`
      });
      newChannel.overwritePermissions(oldChannel.permissionOverwrites);
    } catch { }
  }
};
