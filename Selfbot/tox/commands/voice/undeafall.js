const fs = require('fs')

module.exports = {
  name: "undeafall",
  descriptionfr: "unmute casque tous les membres d'un vocal",
  descriptionen: "Undeaf all members in vc channel",
  usage: "<channel>",
  run: async (client, message, args) => {
    const channel = message.mentions.channels.first() || client.channels.cache.get(args[0])
    if (!channel) return message.edit(`Aucun salon de trouvé pour \`${args[0] || "rien"}\``)
    if (!channel.guild.members.me.permissions.has("DEAFEN_MEMBERS")) return message.edit("Vous n'avez pas la permissions d'executer cette commannde")
    if (channel.type !== "GUILD_VOICE") return message.edit("Veuillez entrer un salon vocal")

    channel.members.forEach(m => m.voice.setDeaf(false).catch(() => false))
    message.edit(`Tous les membres en vocal ont été unmute casque`)
}
}