const Discord = require("discord.js-selfbot-v13");

module.exports = {
  name: "massrole",
  description: "Ajoute un rôle mentionné ou avec l'ID du rôle à tous les membres du serveur.",
  run: async (client, message, args) => {
    if (!message.member.permissions.has(Discord.Permissions.FLAGS.MANAGE_ROLES)) {
      return message.edit(`\`❌\` Vous n'avez pas la permission de gérer les rôles.`);
    }

    if (args.length < 1) {
      return message.edit(`Veuillez mentionner un rôle ou fournir l'ID d'un rôle après la commande`);
    }

    let role = message.mentions.roles.first() || message.guild.roles.cache.get(args[0]);
    if (!role) {
      return message.edit(`\`❌\` Rôle non trouvé.`);
    }

    let members = message.guild.members.cache.filter(member => !member.roles.cache.has(role.id));
    let totalMembers = members.size;
    let processedMembers = 0;
    let progressMessage = await message.channel.send(`Ajout du rôle à 0/${totalMembers} membres...`);

    for (let [memberId, member] of members) {
      await member.roles.add(role).catch(console.error);
      processedMembers++;
      if (processedMembers % 24 === 0 || processedMembers === totalMembers) {
        progressMessage.edit(`Ajout du rôle à ${processedMembers}/${totalMembers} membres...`);
      }
    }

    progressMessage.edit(`\`✅\` Le rôle ${role} a été ajouté à tous les membres éligibles.`);
  }
};
