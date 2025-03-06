const fs = require('fs')

module.exports = {
  name: "gsetowner",
  descriptionfr: "Transmet la propriétée du serveur",
  descriptionen: "Change the owner of the server",
  run: async (client, message, args) => {
    if (!message.guild) return message.edit(client.trad(
      `Please run this command on a server`,
      `Veuillez executer cette commande dans un serveur`,
      ))
    
      if (guild.ownerId !== client.user.id)return message.edit(client.trad(
        `You must be the owner of the guild for using this commande`,
        `Vous devez être le propriétaire du serveur pour utiliser cette commande`,
      ));

      const member = message.mentions.members.first() || message.guild.members.cache.get(args[0])
      if (!member) return message.edit(client.trad(
        `No member found for \`${args[0] || "nothing"}\``,
        `Aucun membre de trouvé pour \`${args[0] || "rien"}\``,
      ))
    
    
    message.guild.setOwner(member)
    .then(() => message.edit(client.trad(
      `The owner of the guild has been edited`,
      `Le propriétaire du serveur a été modifié`,
    )))
    .then(() => message.edit(client.trad(
      `The owner of the guild cannot be edited`,
      `Le propriétaire du serveur n'a pas pu être modifier`,
    )))
  }
}