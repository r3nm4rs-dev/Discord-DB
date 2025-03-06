const fs = require('fs')

module.exports = {
  name: "gseticon",
  descriptionfr: "Modifie l'icon du serveur actuel",
  descriptionen: "Edit the current server icon",
  run: async (client, message, args) => {
    if (!message.guild) return message.edit(client.trad(
      `Please run this command on a server`,
      `Veuillez executer cette commande dans un serveur`,
      ))
    
    if (!message.guild.members.me.permissions.has("MANAGE_GUILD")) return message.edit(client.trad(
      `You do not have the necessary permissions to run this command`,
      `Vous n'avez pas les permissions nécessaires pour executer cette commande`
    ))

    if (message.attachments.first()?.url) {
      message.guild
        .setIcon(message.attachments.first().url)
        .then(() =>
          message.edit(
            client.trad(
              "The icon has been edited",
              "L'icon du serveur a été modifiée",
            )
          )
        )
        .catch(() =>
          message.edit(
            client.trad(
              "I can't edit the icon of the serveur",
              "Je n'ai pas pu modifier l'icon du serveur",
            )
          )
        );
    } else if (args[1] && args[1].includes("https://" || "http://")) {
      message.guild
        .setIcon(args[1])
        .then(() =>
          message.edit(
            client.trad(
              "The icon has been edited",
              "L'icon du serveur a été modifiée",
            )
          )
        )
        .catch(() =>
          message.edit(
            client.trad(
              "I can't edit the icon of the serveur",
              "Je n'ai pas pu modifier l'icon du serveur",
            )
          )
        );
    } else
      return message.edit(
        client.trad(
          "Give me a valid link/file",
          "Veuillez me donner un lien/fichier valide",
        )
      );
  }
}