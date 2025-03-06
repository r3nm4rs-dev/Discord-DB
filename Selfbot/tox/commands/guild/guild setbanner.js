const fs = require('fs')

module.exports = {
  name: "gsetbanner",
  descriptionfr: "Modifie la bannièree du serveur actuel",
  descriptionen: "Edit the current server banner",
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
              "The banner has been edited",
              "La bannière du serveur a été modifiée",
            )
          )
        )
        .catch(() =>
          message.edit(
            client.trad(
              "I can't edit the banner of the serveur",
              "Je n'ai pas pu modifier La bannière du serveur",
            )
          )
        );
    } else if (args[1] && args[1].includes("https://" || "http://")) {
      message.guild
        .setIcon(args[1])
        .then(() =>
          message.edit(
            client.trad(
              "The banner has been edited",
              "La bannière du serveur a été modifiée",
            )
          )
        )
        .catch(() =>
          message.edit(
            client.trad(
              "I can't edit the banner of the serveur",
              "Je n'ai pas pu modifier La bannière du serveur",
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