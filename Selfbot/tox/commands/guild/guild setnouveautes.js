const fs = require('fs')

module.exports = {
  name: "gsetnouv",
  descriptionfr: "Modifie le salons des nouveautés discord",
  descriptionen: "Edit the discord news channel",
  run: async (client, message, args) => {
    if (!message.guild) return message.edit(client.trad(
      `Please run this command on a server`,
      `Veuillez executer cette commande dans un serveur`,
      ))
    
    if (!message.guild.members.me.permissions.has("MANAGE_GUILD")) return message.edit(client.trad(
      `You do not have the necessary permissions to run this command`,
      `Vous n'avez pas les permissions nécessaires pour executer cette commande`
    ))

    if (!message.guild.features.includes("COMMUNITY")) return message.edit(
      client.trad(
        "You must activate the server community to use this command.",
        "Vous devez activer la communautée du serveur pour utiliser cette commande",
      )
    );

   
    const channel = message.mentions.channels.first() || message.guild.channels.cache.get(args[1])
    if (!channel) return message.edit(`Aucun salon de trouvé pour \`${args[1] || "rien"}\``)

    message.guild.setSafetyAlertsChannel(channel)
      .then(() => message.edit(client.trad(
        `Le salon des nouveautés discord est maintenant: <#${channel.id}>`,
        `The discord news channel is now: <#${channel.id}>`
      )))
      .catch(() => message.edit(client.trad(
        "Je n'ai pas pu modifier le salon des nouveautés discord du serveur",
        "I've been unable to edit the server's discord news channel"
      )))
  }
}