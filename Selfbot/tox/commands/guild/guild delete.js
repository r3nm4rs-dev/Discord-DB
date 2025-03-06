const fs = require('fs')

module.exports = {
  name: "gdelete",
  descriptionfr: "Supprime le serveur actuel",
  descriptionen: "Delete the current server",
  run: async (client, message, args) => {
    const guild = client.guilds.cache.get(args[0]) || message.guild;
    if (!guild)
      return message.edit(
        client.trad(
          `No guild found for \`${args[0] || "nothing"}\``,
          `Aucun serveur de trouvé pour \`${args[0] || "rien"}\``,
        )
      );

    if (guild.ownerId !== client.user.id)
      return message.edit(
        client.trad(
          `You must be the owner of the guild for using this commande`,
          `Vous devez être le propriétaire du serveur pour utiliser cette commande`
        )
      );
    guild.delete();
  },
};
