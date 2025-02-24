const Discord = require("discord.js-selfbot-v13");

module.exports = {
  name: "removeroleall",
  description: "Supprimer un rôle à tous les membres du serveur",
  run: async (client, message, args) => {
    if (!message.member.permissions.has("MANAGE_ROLES")) {
      return message.channel.send("Vous n'avez pas la permission de gérer les rôles.");
    }

    const role = message.mentions.roles.first() || message.guild.roles.cache.get(args[0]);
    if (!role) return message.channel.send("Veuillez spécifier un rôle valide.");

    const members = await message.guild.members.fetch();
    let count = 0;

    const removeRole = async (member) => {
      if (member.roles.cache.has(role.id)) {
        try {
          await member.roles.remove(role);
          count++;
        } catch (err) {
          console.error(`Impossible de retirer le rôle de ${member.user.tag}:`, err);
        }
      }
    };

    const delay = (ms) => new Promise(resolve => setTimeout(resolve, ms));

    for (const member of members.values()) {
      removeRole(member);
      await delay(200);
    }

    message.channel.send(`Rôle supprimé à ${count} / ${members.size} utilisateurs.`);
  },
};
