const { getVoiceConnection } = require('@discordjs/voice');
const config = require('../../config.json'); // Charger le fichier config.json

module.exports = {
  name: "leave",
  description: "Quitte le salon vocal",
  
  run: async (client, message, args) => {
    const userId = message.author.id; // Obtenir l'ID de l'utilisateur qui a envoyé la commande
    const userConfig = config.user[userId]; // Récupérer la configuration de l'utilisateur

    if (!userConfig || !userConfig.token) {
      return message.edit(`\`❌\` Token utilisateur non trouvé.`); // Vérifier si le token existe
    }

    const voiceConnection = getVoiceConnection(message.guild.id);
    
    if (!voiceConnection) {
      return message.edit(`\`❌\` Je ne suis actuellement dans aucun salon vocal.`);
    }

    // Vérifie si l'utilisateur qui demande de quitter est celui connecté au salon vocal
    const { channelId } = voiceConnection.joinConfig || {}; // Utiliser une déstructuration avec une valeur par défaut

    if (channelId) {
      // Déconnecte l'utilisateur du salon vocal
      voiceConnection.destroy();
      message.edit(`\`✅\` J'ai quitté le salon vocal.`);
    } else {
      message.edit(`\`❌\` Vous ne pouvez pas quitter ce salon vocal car je n'y suis pas connecté.`);
    }
  },
};
