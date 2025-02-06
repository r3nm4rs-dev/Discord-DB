const Discord = require("discord.js-selfbot-v13");
const fs = require("fs");

module.exports = {
  name: "syncperms",
  description: "Synchronise les catégories et les commandes avec les permissions de la catégorie.",
  run: async (client, message, args) => {
    try {
      // Vérifier si l'utilisateur a la permission de gérer les rôles
      if (!message.member.permissions.has(Discord.Permissions.FLAGS.MANAGE_ROLES)) {
        return message.edit("Tu n'as pas la permission de gérer les rôles !");
      }

      // Synchroniser les catégories
      const categories = message.guild.channels.cache.filter(c => c.type === "GUILD_CATEGORY");
      for (const category of categories) {
        await syncCategoryPermissions(category);
      }

      // Synchroniser les commandes
      const commands = client.application.commands.cache;
      for (const command of commands) {
        await syncCommandPermissions(command);
      }

      // Message de succès
      message.edit("**Synchronisation terminée avec succès !**");
    } catch (error) {
      console.error(error);
      message.edit("**Une erreur s'est produite lors de la synchronisation.**");
    }
  },
};

async function syncCategoryPermissions(category) {
  // Récupérer les permissions de la catégorie
  const categoryPermissions = category.permissionOverwrites.cache;

  // Itérer sur les salons de la catégorie
  for (const channel of category.children) {
    // Définir les permissions du salon
    await channel.overwritePermissions(categoryPermissions);
  }
}

async function syncCommandPermissions(command) {
  // Récupérer les permissions de la commande
  const commandPermissions = command.permissions;

  // Itérer sur les rôles de la guilde
  for (const role of message.guild.roles.cache) {
    // Définir les permissions du rôle pour la commande
    await command.permissions.set({
      role: role.id,
      permissions: commandPermissions.filter(p => p.id === role.id).first().permissions,
    });
  }
}
