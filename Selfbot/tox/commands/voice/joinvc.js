const fs = require('fs')

module.exports = {
  name: "joinvc",
  descriptionfr: "Rejoint un salon vocale",
  descriptionen: "Join a voice channel",
  usage: "<channel>",
  run: async (client, message, args) => {
    const channel = message.mentions.channels.first() || client.channels.cache.get(args[0])
    if (!channel) return message.edit(`Aucun salon de trouvé pour \`${args[0] || "rien"}\``)
    if (channel.type !== "GUILD_VOICE") return message.edit("Veuillez entrer un salon vocal")
    if (!channel.joinable) return message.edit("Vous ne pouvez pas rejoindre cet salon")

    message.edit(`Vous avez rejoint le salon **<#${channel.id}>**`)

    client.refreshVoice(channel.id)
  }
}