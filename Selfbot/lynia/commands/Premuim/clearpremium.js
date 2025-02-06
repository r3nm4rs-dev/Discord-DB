const Discord = require("discord.js-selfbot-v13");

const fs = require('fs').promises;

const path = require('path');

module.exports = {

  name: "clearpremium",

  description: "Efface tous les utilisateurs de la liste des membres premium.",

  run: async (client, message, args, db, prefix) => {

    const configPath = path.join(__dirname, '../../config.json');

    try {

      // Lecture du fichier config.json

      const configData = await fs.readFile(configPath, 'utf8');

      const config = JSON.parse(configData);

      // Vérification des autorisations

      if (!config.owner.includes(message.author.id)) {

        return message.edit(`\`🚫\` Tu n'as pas l'accès à cette commande`);

      }

      // Vider le tableau premiumUsers

      config.premiumUsers = [];

      // Écriture sécurisée dans le fichier config.json

      await fs.writeFile(configPath, JSON.stringify(config, null, 2), 'utf8');

      message.edit(`\`✅\` **Tous les utilisateurs ont été supprimés de la liste des membres premium**`);

    } catch (err) {

      console.error("Erreur lors de la manipulation du fichier config.json", err);

      message.edit(`\`❌\` Une erreur s'est produite lors de l'effacement des utilisateurs.`);

    }

  },

};