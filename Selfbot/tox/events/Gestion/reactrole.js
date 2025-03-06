const fs = require('fs')

module.exports = {
  name: "messageReactionAdd",
  once: false,
  run: async (reaction, user, client) => {
    if (reaction.message.partial) await reaction.message.fetch();
    if (reaction.partial) await reaction.fetch();
    if (user.bot) return;

    const guild = reaction.message.guild;
    if (!guild) return
    if (!guild.members.me.permissions.has("MANAGE_ROLES")) return;

    const member = guild.members.cache.get(user.id);
    if (!member) return;

    const reaction2 = client.db.rolemenus.find(r => r.emotes === reaction.emoji.toString() && r.msgsid === reaction.message?.id)

    if (reaction2) member.roles.add(reaction2.roleid).catch(() => false);
  }
}