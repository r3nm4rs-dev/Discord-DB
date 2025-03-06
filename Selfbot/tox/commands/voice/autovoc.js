const fs = require('fs')

module.exports = {
  name: "autovoc",
  descriptionen: "Join automatically a voice channel",
  descriptionfr: "Rejoint automatiquement un salon vocale",
  usage: "[channel]",
  run: async (client, message, args) => {
    if (!args[0]){
      client.db.vcconnect = false
      client.save()
      message.edit("Vous ne serez plus connecter à un vocale à chaque démarrage du bot")
    }
    else{
      const channel = message.mentions.channels.first() || client.channels.cache.get(args[0])
      if (!channel) return message.edit(`Aucun salon de trouvé pour \`${args[0] || "rien"}\``)
      if (channel.type !== "GUILD_VOICE") return message.edit("Veuillez entrer un salon vocal")
      if (!channel.joinable) return message.edit("Vous ne pouvez pas rejoindre cet salon")

      client.db.vcconnect = channel.id
      client.save()
      client.refreshVoice()
      message.edit(`Vous serez connecter au salon <#${channel.id}> aux démarrages du bot`)
    }
  }
}