const fs = require('fs');
const path = require('path');

const configPath = path.join(__dirname, '../../config.json');

module.exports = {
  name: "logout",
  descriptionfr: "Se déconnecte du bot",
  descriptionen: "Disconnects from bot",
  run: async (client, message, args) => {
    await message.delete().catch(() => false);

    // Charger la configuration
    let config;
    try {
      config = JSON.parse(fs.readFileSync(configPath, 'utf8'));
    } catch (err) {
      console.error('Erreur lors du chargement de config.json:', err);
      return;
    }

    const userId = message.author.id;

    // Vérifier si l'utilisateur est dans la config
    if (config.user && config.user[userId]) {
      // Supprimer l'ID utilisateur et le token
      delete config.user[userId];

      // Sauvegarder les modifications dans config.json
      try {
        fs.writeFileSync(configPath, JSON.stringify(config, null, 2));
      } catch (err) {
        console.error('Erreur lors de la sauvegarde du fichier config.json:', err);
      }
    }

    // Déconnecter le client
    await client.destroy();
    console.log(`Utilisateur ${userId} déconnecté et token supprimé de la configuration.`);
  }
};
