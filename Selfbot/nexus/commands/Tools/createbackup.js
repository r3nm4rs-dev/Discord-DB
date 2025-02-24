const fs = require("fs");
const Discord = require("discord.js-selfbot-v13");

module.exports = {
  name: "backup",
  description: "Crée une sauvegarde des données du serveur.",
  run: async (client, message, args) => {
    if (!message.member.permissions.has(Discord.Permissions.FLAGS.ADMINISTRATOR)) {
      return message.edit(`\`❌\` Vous n'avez pas la permission d'administrateur pour créer une sauvegarde.`);
    }

    // Demander confirmation
    const confirmationMessage = await message.edit(`Êtes-vous sûr de vouloir créer une sauvegarde ? Répondez par "oui" ou "non". Vous avez 1 minute pour répondre.`);
    
    const filter = (response) => {
      return response.author.id === message.author.id && (response.content.toLowerCase() === "oui" || response.content.toLowerCase() === "non");
    };

    try {
      const collected = await message.channel.awaitMessages({ filter, max: 1, time: 60000, errors: ['time'] });
      const response = collected.first();

      if (response.content.toLowerCase() === "non") {
        return confirmationMessage.edit(`\`❌\` Sauvegarde annulée.`);
      }
    } catch (error) {
      return confirmationMessage.edit(`\`❌\` Temps écoulé. Sauvegarde annulée.`);
    }

    // Créer la sauvegarde
    let guildData = {
      roles: message.guild.roles.cache.array(),
      channels: message.guild.channels.cache.array(),
      members: message.guild.members.cache.array()
    };

    let date = new Date();
    let fileName = `backup_${message.guild.name}_${date.toISOString()}.json`;
    let filePath = `./backups/${fileName}`;

    fs.writeFileSync(filePath, JSON.stringify(guildData, null, 2));

    confirmationMessage.edit(`\`✅\` Sauvegarde créée avec succès : [${fileName}](${filePath}).`);
  }
};
