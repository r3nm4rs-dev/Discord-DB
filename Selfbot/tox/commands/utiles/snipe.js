const fs = require('fs')

module.exports = {
  name: "snipe",
  descriptionfr: "Affiche le dernier message supprimé",
  descriptionen: "Display the last deleted message",
  premium: true,
  run: async (client, message, args) => {
    const msg = client.snipes.get(message.channel.id)
    if (!msg) return message.edit(client.trad(
      "No message save.",
      "Aucun message enregistré."
    ))

        message.edit(`\`${client.trad("Auteur", "Author")}\` » ${msg.author}
\`Message\` » ${msg.content}
\`Date\` » <t:${parseInt(msg.moment / 1000, 10)}:R>
\`Image\` » ${msg.images}`)
  }
}