const fs = require('fs')

module.exports = {
  name: "gsetrules",
  descriptionfr: "Modifie le salons des règles discord",
  descriptionen: "Edit the discord rules channel",
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

    message.guild.setRulesChannel(channel)
      .then(() => message.edit(client.trad(
        `The rules channel is now: <#${channel.id}>`,
        `Le salon des règles est maintenant: <#${channel.id}>`,
      )))
      .catch(() => message.edit(client.trad(
        "I've been unable to edit the server's rules channel",
        "Je n'ai pas pu modifier le salon des règles du serveur",
      )))
  }
}