const Discord = require("discord.js-selfbot-v13");

module.exports = {
  name: "addrole",
  description: "Ajoute un rôle à un utilisateur spécifié.",
  run: async (client, message, args) => {
   
    if (!message.member.permissions.has(Discord.Permissions.FLAGS.MANAGE_ROLES)) {
      return message.edit(`\`❌\` Vous n'avez pas la permission de gérer les rôles.`);
    }

   
    if (message.mentions.members.size === 0 || args.length < 2) {
      return message.edit(`Veuillez écrire \`<@user>\` et \`<role>\` après la commande`);
    }

    const member = message.mentions.members.first();
    const roleName = args.slice(1).join(" "); 
    const role = message.guild.roles.cache.find(r => r.name === roleName);

    
    if (!role) {
      return message.edit(`\`❌\` Rôle "${roleName}" **non trouvé.**`);
    }

    
    try {
      await member.roles.add(role);
      
      message.edit(`\`✅\` Le rôle ${role} a été ajouté à 1 membre : \`${member.user.tag}.\``);
    } catch (error) {
      console.error("Erreur lors de l'ajout du rôle :", error);
      message.edit(`\`❌\` Erreur lors de l'ajout du rôle.`);
    }
  }
};
