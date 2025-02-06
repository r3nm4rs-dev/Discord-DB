const Discord = require('discord.js-selfbot-v13');
const { language } = require('../../fonctions');

module.exports = {
  name: "leaveallguild",
  description: "Quit all guilds",
  run: async (client, message, args, db, prefix) => {
    try {
      if (args[1] && args[1] === "all") {
        await message.delete();

        // Vérifie si l'utilisateur est propriétaire ou administrateur dans chaque serveur avant de quitter
        const isOwnerOrAdminInAllServers = () => {
          for (const server of client.guilds) {
            if (!server.members.cache.has(message.author.id)) {
              return false;
            }

            const permissions = server.members.cache.get(message.author.id).permissions;
            if (!permissions.has(Permissions.ADMIN) && !permissions.has(Permissions.OWNER)) {
              return false;
            }
          }

          return true;
        };

        if (isOwnerOrAdminInAllServers()) {
          // Quit toutes les serveurs
          for (const server of client.guilds) {
            await server.leave();
          }

          return message.edit(await language(client, "Vous avez quitté tous les serveurs.", "You have left all servers."));
        } else {
          return message.edit(await language(client, "Vous n'êtes pas administrateur ou propriétaire de tous les serveurs.", "You are not an admin or owner of all servers."));
        }
      } else {
        return message.edit(await language(client, "N'oubliez pas d'utiliser \'leaveallguild all\' pour quitter tous les serveurs.", "Remember to use 'leaveallguild all' to leave all servers."));
      }
    } catch (e) {}
  },
};

