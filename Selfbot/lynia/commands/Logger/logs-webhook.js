const fs = require('fs');
const path = require('path');
const { language } = require("../../fonctions");

module.exports = {
  name: "logs-webhook",
  description: "Modifie l'URL du logger (webhook)",
  usage: "[webhook url]",
  run: async (client, message, args) => {
    const configPath = path.join(__dirname, '../../config.json');
    let config;

    try {
      config = JSON.parse(fs.readFileSync(configPath, 'utf8'));
    } catch (err) {
      console.error("Error reading config.json", err);
      return message.edit(await language(client, 
        "Erreur lors de la lecture de la configuration.", 
        "Error reading configuration."
      ));
    }

    // Vérification de l'éligibilité au mode premium
    if (!config.premiumUsers.includes(message.author.id)) {
      return message.edit(await language(client, 
        "*Vous n'êtes pas éligible au mode :* `premium`", 
        "*You are not eligible for the mode:* `premium`"
      ));
    }

    const userDbPath = path.join(__dirname, '../../db', `${message.author.id}.json`);
    let userDb;

    try {
      userDb = JSON.parse(fs.readFileSync(userDbPath, 'utf8'));
    } catch (err) {
      console.error("Error reading user database", err);
      return message.edit(await language(client, 
        "Erreur lors de la lecture de votre base de données.", 
        "Error reading your database."
      ));
    }

    if (!args[0]) {
      userDb.logger = null;
      await fs.promises.writeFile(userDbPath, JSON.stringify(userDb));
      return message.edit(await language(client, 
        "Le logger a été désactivé.", 
        "The logger has been disabled."
      ));
    } else {
      if (!args[0].startsWith("https://")) {
        return message.edit(await language(client, 
          "Veuillez m'envoyer un lien de webhook valide.", 
          "Please enter a valid webhook link."
        ));
      }
      userDb.logger = args[0];
      await fs.promises.writeFile(userDbPath, JSON.stringify(userDb));
      return message.edit(await language(client, 
        "Le logger a été activé.", 
        "The logger has been enabled."
      ));
    }
  }
};
