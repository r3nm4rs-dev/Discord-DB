const fs = require('fs')

module.exports = {
  name: "autoreact",
  descriptionfr: "Ajoute un salons aux autoreacts",
  descriptionen: "Add a channel to autoreacts",
  run: async (client, message, args) => {

    if (!args[0]) {
      return message.edit(`**AUTOREACTS**\n\n${client.db.autoreact.map(c => `> <#${c}> (${c})`).join('\n')}`)
    } else {
      if (!message.guild)return message.edit(client.trad(
        `Please execute this command in a server`,
        `Veuillez executer cette commande dans un serveur`,
      ))

      const channel = message.mentions.channels.first() || message.guild.channels.cache.get(args[0])
      if (!channel) return message.edit(client.trad(
        `No channel found for \`${args[0] || "rien"}\``,
        `Aucun salon de trouvé pour \`${args[0] || "rien"}\``
      ))

      if (client.db.autoreact.includes(channel.id)) return message.edit(client.trad(
        "This channel is already in piconlys",
        `Ce salon fait déjà parti des piconly`
      ))

      client.db.autoreact.push(channel.id)
      client.save()

      message.edit(client.trad(
        `The channel <#${channel.id}> is now a autoreacts channel`,
        `Le salon <#${channel.id}> fait parti des autoreacts`
      ))
    }
  }
}