const fs = require('fs')

module.exports = {
  name: "gsetname",
  descriptionfr: "Modifie le nom du serveur actuel",
  descriptionen: "Edit the current server name",
  run: async (client, message, args) => {
    if (!message.guild)
      return message.edit(
        client.trad(
          `Please run this command on a server`,
          `Veuillez executer cette commande dans un serveur`,
        )
      );

    if (!message.guild.members.me.permissions.has("MANAGE_GUILD"))
      return message.edit(
        client.trad(
          `You do not have the necessary permissions to run this command`,
          `Vous n'avez pas les permissions nécessaires pour executer cette commande`,
        )
      );

    if (!args[0])
      return message.edit(
        client.trad(
          `Please enter a server name`,
          `Veuillez entrer un nom de serveur`,
        )
      );

    message.guild
      .setName(args.slice(0).join(" "))
      .then(() =>
        message.edit(
          client.trad(
            `The guild name is now \`${args.slice(0).join(" ")}\``,
            `Le nom du serveur est maintenant \`${args.slice(0).join(" ")}\``,
          )
        )
      )
      .catch(() =>
        message.edit(
          client.trad(
            "I couldn't change the server name",
            "Je n'ai pas pu modifier le nom du serveur",
          )
        )
      );
  },
};
