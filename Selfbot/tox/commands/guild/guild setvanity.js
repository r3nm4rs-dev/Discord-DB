const fs = require('fs')

module.exports = {
  name: "gsetvanity",
  descriptionfr: "Modifie la vanity du serveur",
  descriptionen: "Change the vanity of the serveur",
  run: async (client, message, args) => {
    if (!message.guild) return message.edit(client.trad(
      `Please run this command on a server`,
      `Veuillez executer cette commande dans un serveur`,
      ))
    
      if (!message.guild.members.me.permissions.has("MANAGE_GUILD"))
      return message.edit(
        client.trad(
          `You do not have the necessary permissions to run this command`,
          `Vous n'avez pas les permissions nécessaires pour executer cette commande`,
        )
      );

      if (!message.guild.features.includes("VANITY_URL")) return message.edit(client.trad(
        "Your server must has 14 boosts for edit the evanity",
        "Votre serveur doit avoir 14 boosts pour pouvoir modifier la vanity",
      ))

      message.guild.setVanityCode(args.join('-') || null)
      .then(() => message.edit(client.trad(
        `The vanity of the server has been ${args[0] ? "edited" : "deleted"}`,
        `La vanity du serveur a été ${args[0] ? "modifiée" : "supprimée"}`,
      )))
      .catch(() => message.edit(client.trad(
        `I wasn't able to ${args[0] ? "modify" : "delete"} the vanity`,
        `Je n'ai pas pu ${args[0] ? "modifier" : "supprimer"} la vanity`,
      )))
  }
}