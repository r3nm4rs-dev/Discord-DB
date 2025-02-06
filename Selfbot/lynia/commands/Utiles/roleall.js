const Discord = require("discord.js-selfbot-v13");

module.exports = {
  name: "roleall",
  description: "Attribuer un rôle à tous les membres du serveur",
  run: async (client, message, args) => {
    // Vérifier que l'utilisateur dispose des permissions pour gérer les rôles
    if (!message.member.permissions.has("MANAGE_ROLES")) {
      return message.channel.send("Vous n'avez pas la permission de gérer les rôles.");
    }

    // Récupérer le rôle mentionné ou l'ID du rôle
    const role = message.mentions.roles.first() || message.guild.roles.cache.get(args[0]);
    if (!role) return message.channel.send("Veuillez spécifier un rôle valide.");

    // Récupérer tous les membres du serveur
    const members = await message.guild.members.fetch();
    let count = 0;

    // Fonction pour ajouter le rôle à un membre
    const addRole = async (member) => {
      if (!member.roles.cache.has(role.id)) {
        try {
          await member.roles.add(role);
          count++;
        } catch (err) {
          console.error(`Impossible d'ajouter le rôle à ${member.user.tag}:`, err);
        }
      }
    };

    // Traiter les membres en parallèle avec des pauses pour éviter les limites de taux
    const delay = (ms) => new Promise(resolve => setTimeout(resolve, ms));

    for (const member of members.values()) {
      addRole(member);
      await delay(200); // Pause de 200ms pour éviter d'être bloqué par les limites de taux
    }

    // Envoyer un message de confirmation
    message.channel.send(`Rôle attribué à ${count} / ${members.size} utilisateurs.`);
  },
};
