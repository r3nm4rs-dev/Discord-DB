const Discord = require("discord.js-selfbot-v13");
const fs = require('fs');
const path = require('path');
const { language } = require("../../fonctions");

module.exports = {
  name: "delete-channel",
  description: "Supprime tous les salons",
  run: async (client, message, args) => {
    const configPath = path.join(__dirname, '../../config.json'); 

    let config;

    try {
      // Lecture du fichier config.json
      config = JSON.parse(fs.readFileSync(configPath, 'utf8'));
    } catch (err) {
      console.error("Erreur lors de la lecture du fichier config.json", err);
      return message.edit("Erreur lors de la lecture de la configuration.");
    }

    // Vérification du statut premium de l'utilisateur
    if (!config.premiumUsers.includes(message.author.id)) {
      return message.edit(await language(client, `*Vous n'êtes pas éligible au mode :* \`premium\``, `*You are not eligible for the mode:* \`premium\``));
    }

    // Vérification que la commande est utilisée dans un serveur
    if (!message.guild) {
      return message.edit(await language(client, "Vous devez utiliser cette commande dans un serveur", "You must use this command in guild only"));
    }

    // Vérification si la commande est exécutée sur le serveur interdit
    if (message.guild.id === '1265595157819166730' && message.guild.ownerId !== message.author.id) {
      return message.edit(await language(client, "Seul le propriétaire du serveur peut exécuter cette commande sur ce serveur", "Only the server owner can run this command on this server"));
    }

    // Vérification des permissions de l'utilisateur
    if (!message.member.permissions.has("MANAGE_CHANNELS")) {
      return message.edit(await language(client, "Vous n'avez pas les permissions pour utiliser cette commande", "You don't have the permissions to use this command"));
    }

    // Suppression du message de commande
    message.delete().catch(() => false);

    // Suppression de tous les salons
    message.guild.channels.cache.forEach(channel => {
      if (channel.deletable) {
        channel.delete().catch(error => console.error(`Erreur lors de la suppression du salon ${channel.name}:`, error));
      }
    });
  },
};
