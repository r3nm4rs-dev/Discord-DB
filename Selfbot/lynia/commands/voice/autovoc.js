const fs = require('fs');
const path = require('path');

module.exports = {
  name: "autovoc",
  descriptionfr: "Active ou désactive la connexion automatique à un salon vocal.",
  description: "Enables or disables automatic voice connection.",
  usage: "autovoc <channel-id> | autovoc off",
  run: async (client, message, args) => {
    // Vérifier si un ID de salon vocal ou 'off' a été fourni
    const option = args[0];
    const userId = message.author.id;
    const dbPath = path.join("/home/container/db", `${userId}.json`);

    // Charger ou créer la base de données de l'utilisateur
    let userData;
    if (fs.existsSync(dbPath)) {
      userData = JSON.parse(fs.readFileSync(dbPath, 'utf8'));
    } else {
      userData = JSON.parse(fs.readFileSync("/home/container/db/exemple.json", 'utf8'));
    }

    if (option === "off") {
      // Désactiver la connexion automatique en supprimant l'ID du salon vocal
      delete userData.voiceconnect;
      fs.writeFileSync(dbPath, JSON.stringify(userData, null, 2));
      return message.channel.send("Connexion automatique désactivée.");
    }

    // Sinon, activer la connexion automatique avec l'ID de salon fourni
    const channelId = option;
    if (!channelId) {
      return message.channel.send("Veuillez fournir l'ID du salon vocal ou 'off' pour désactiver.");
    }

    // Mettre à jour l'ID du salon vocal dans la base de données
    userData.voiceconnect = channelId;
    fs.writeFileSync(dbPath, JSON.stringify(userData, null, 2));

    // Essayer de rejoindre le salon vocal
    try {
      await client.refreshVoice(channelId);
      message.channel.send(`Connexion automatique activée dans : ${channelId}.`);
      console.log(`Rejoint le salon vocal: ${channelId} pour l'utilisateur ${userId}`);
    } catch (error) {
      console.error(`Erreur lors de la tentative de rejoindre le salon vocal pour l'utilisateur ${userId}:`, error);
      message.channel.send("Une erreur est survenue.");
    }
  },
};
