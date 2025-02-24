const Discord = require("discord.js-selfbot-v13");

module.exports = {
  name: "delrole",
  description: "Supprime un rôle du serveur.",
  run: async (client, message, args) => {
    if (!message.member.permissions.has(Discord.Permissions.FLAGS.MANAGE_ROLES)) {
      return message.edit(`\`❌\` Vous n'avez pas la permission de gérer les rôles.`);
    }

    if (args.length < 1) {
      return message.edit(`Veuillez mentionner le rôle à supprimer après la commande.`);
    }

    let role = message.mentions.roles.first() || message.guild.roles.cache.get(args[0]);
    if (!role) {
      return message.edit(`\`❌\` Rôle non trouvé.`);
    }

    await role.delete().catch(console.error);

    message.edit(`\`✅\` Le rôle ${role.name} a été supprimé.`);
  }
};