const fs = require('fs')

module.exports = {
  name: "piconly",
  descriptionfr: "Ajoute un salons aux piconly",
  descriptionen: "Add a channel to piconlys",
  run: async (client, message, args) => {

    if (!args[0]) {
      return message.edit(`**PICONLY**\n\n${client.db.chpiconly.map(c => `> <#${c}> (${c})`).join('\n')}`)
    } else {
      if (!message.guild)return message.edit(client.trad(
        `Please execute this command in a server`,
        `Veuillez executer cette commande dans un serveur`,
      ))

      const channel = message.mentions.channels.first() || message.guild.channels.cache.get(args[0])
      if (!channel) return message.edit(client.trad(
        `Aucun salon de trouvé pour \`${args[0] || "rien"}\``,
        `No channel found for \`${args[0] || "rien"}\``,
      ))

      if (client.db.chpiconly.includes(channel.id)) return message.edit(client.trad(
        "This channel is alreeady in piconlys",
        `Ce salon fait déjà parti des piconly`,
      ))

      client.db.chpiconly.push(channel.id)
      client.save()

      message.edit(client.trad(
        `The channel <#${channel.id}> is now a piconly channel`,
        `Le salon <#${channel.id}> fait parti des piconly`,
      ))
    }
  }
}