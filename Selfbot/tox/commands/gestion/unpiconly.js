const fs = require('fs')

module.exports = {
  name: "unpiconly",
  descriptionfr: "Retire un salons des piconly",
  descriptionen: "Remove a channel from piconlys",
  run: async (client, message, args) => {
    if (!message.guild)return message.edit(client.trad(
      `Please execute this command in a server`,
      `Veuillez executer cette commande dans un serveur`,
    ))
    
    const channel = message.mentions.channels.first() || message.guild.channels.cache.get(args[0])
    if (!channel) {
      if (!client.db.chpiconly.includes(args[0])) return message.edit(client.trad(
        `No channel found for \`${args[0] || "rien"}\``,
        `Aucun salon de trouvé pour \`${args[0] || "rien"}\``
      ))
      client.db.chpiconly.splice(client.db.chpiconly.indexOf(args[0]), 1)
      client.save()
      return message.edit(client.trad(
        `This channel has been removed from piconlys`,
        `Ce salon a été retiré du piconly`,
      ))
    }

    if (!client.db.chpiconly.includes(channel.id)) return message.edit(client.trad(
      `This channel is not a piconly`,
      `Ce salon ne fait pas partie des piconly`,
    ))
    client.db.chpiconly.splice(client.db.chpiconly.indexOf(channel.id), 1) =
    client.save()

    message.edit(client.trad(
      `The channel <#${channel.id}> no longer part of piconly`,
      `Le salon <#${channel.id}> ne fait plus partie des piconly`,
    ))
  }
}