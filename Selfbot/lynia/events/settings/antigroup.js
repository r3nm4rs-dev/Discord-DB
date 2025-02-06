// antigroup.js
const fs = require('fs');
const path = require('path');

module.exports = async (client) => {
  client.on('messageCreate', async (message) => {
    // Vérifier que le message provient d'un groupe DM
    if (!message.channel.isGroupDM()) return;

    const userId = client.user.id;
    const dbPath = path.join(__dirname, `../../db/${userId}.json`);

    // Vérifier si le fichier JSON de l'utilisateur existe
    if (!fs.existsSync(dbPath)) {
      console.log("La base de données pour cet utilisateur n'existe pas.");
      return;
    }

    // Charger les données de l'utilisateur
    const db = JSON.parse(fs.readFileSync(dbPath, 'utf8'));

    // Vérifier si l'option anti-groupe est activée
    if (db.noaddgrp) {
      try {
        // Quitter le groupe automatiquement
        await message.channel.leave();
        console.log(`Groupe quitté automatiquement car l'option anti-groupe est activée.`);
      } catch (error) {
        console.error(`Impossible de quitter le groupe : ${error.message}`);
      }
    }
  });
};
