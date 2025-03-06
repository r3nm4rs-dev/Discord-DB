const fs = require('fs')

module.exports = {
  name: "muteall",
  descriptionfr: "Mute tous les membres d'un vocal",
  descriptionen: "Mute all members in vc channel",
  usage: "<channel>",
  premium: true,
  invisible: true,
  run: async (client, message, args) => {
    const channel = message.mentions.channels.first() || client.channels.cache.get(args[0])
    if (!channel) return message.edit(`Aucun salon de trouvé pour \`${args[0] || "rien"}\``)
    if (!channel.guild.members.me.permissions.has("MUTE_MEMBERS")) return message.edit("Vous n'avez pas la permissions d'executer cette commannde")
    if (channel.type !== "GUILD_VOICE") return message.edit("Veuillez entrer un salon vocal")

    channel.members.forEach(m => m.voice.setMute(true).catch(() => false))
    message.edit(`Tous les membres en vocal ont été mute`)
  }
}