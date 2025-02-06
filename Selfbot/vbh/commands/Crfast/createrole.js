const Discord = require("discord.js-selfbot-v13");

module.exports = {
  name: "createrole",
  description: "Crée un nouveau rôle avec le nom spécifié.",
  run: async (client, message, args) => {
    // Vérifie si l'utilisateur a la permission de gérer les rôles
    if (!message.member.permissions.has(Discord.Permissions.FLAGS.MANAGE_ROLES)) {
      return message.reply("Tu n'as pas la permission de créer des rôles !");
    }

    const roleName = args.join(" "); // Récupère le nom du rôle à partir des arguments
    if (!roleName) {
      return message.edit("S'il te plaît, spécifie le nom du rôle à créer.");
    }

    // Crée le rôle avec le nom spécifié
    message.guild.roles.create({
      name: roleName,
      color: 'BLUE', // Tu peux spécifier la couleur ici ou laisser 'BLUE' par défaut
      reason: 'Raison pour la création du rôle' // Optionnel
    })
    .then(role => {
      message.edit(`Rôle créé avec succès : ${role.name}`);
    })
    .catch(error => {
      console.error(error);
      message.edit("Une erreur s'est produite lors de la création du rôle.");
    });
  },
};
