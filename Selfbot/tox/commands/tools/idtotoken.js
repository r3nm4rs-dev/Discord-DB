const Discord = require('discord.js');

module.exports = {
  name: "idtotoken",
  descriptionfr: "Convertit un ID Discord en token",
  descriptionen: "Converts a Discord ID into a token",
  usage: "<Discord ID>",
  run: async (client, message, args) => {
    if (!args[0] || !/^\d+$/.test(args[0])) {
      return message.edit(
        client.trad(
          "Veuillez fournir un ID Discord valide.",
          "Please provide a valid Discord ID."
        )
      );
    }

    try {
      const user = await client.users.fetch(args[0]);
      const idToToken = Buffer.from(args[0]).toString('base64');

      return message.edit(
        client.trad(
          `⛧ __**ID to Token Première Partie**__ ⛧\n\`Utilisateur\` ➜ **${user.username}**\n\`Token\` ➜ **${idToToken}**`,
          `⛧ __**ID to Token First Part**__ ⛧\n\`User\` ➜ **${user.username}**\n\`Token\` ➜ **${idToToken}**`
        )
      );
    } catch (error) {
      console.error(error);
      return message.edit(
        client.trad(
          `⛧ __**Erreur**__ ⛧\nImpossible de trouver un utilisateur avec l'ID Discord **${args[0]}**.`,
          `⛧ __**Error**__ ⛧\nUnable to find a user with Discord ID **${args[0]}**.`
        )
      );
    }
  }
};