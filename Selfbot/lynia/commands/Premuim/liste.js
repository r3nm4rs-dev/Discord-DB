const fs = require('fs');
const path = require('path');

module.exports = {
  name: "owner2",
  description: "Affiche la liste des membres premium et leur attribue un rôle.",
  run: async (client, message, args) => {
    const configPath = path.join(__dirname, '../../config.json');
    
    fs.readFile(configPath, 'utf8', async (err, data) => {
      if (err) {
        console.error("Erreur lors de la lecture du fichier config.json", err);
        return message.channel.send("Erreur lors de la lecture de la configuration.");
      }

      const config = JSON.parse(data);

      if (!config.premiumUsers || config.premiumUsers.length === 0) {
        return message.channel.send("Il n'y a aucun utilisateur dans la liste des membres premium.");
      }

      const roleId = '1289885122170064896'; // ID du rôle à attribuer
      const role = message.guild.roles.cache.get(roleId);

      if (!role) {
        return message.channel.send("Rôle non trouvé.");
      }

      const premiumUsers = config.premiumUsers.map(id => {
        const member = message.guild.members.cache.get(id);
        if (member) {
          member.roles.add(role).catch(err => console.error(`Erreur lors de l'attribution du rôle à ${member.user.tag}:`, err));
          return `<@${id}>`;
        }
        return null;
      }).filter(Boolean).join('\n');

      await message.channel.send(`Liste des membres premium :\n${premiumUsers}`);
    });
  },
};
