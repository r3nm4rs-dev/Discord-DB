const Discord = require("discord.js-selfbot-v13");
const fs = require('fs');
const path = require('path');
const { language } = require("../../fonctions");

module.exports = {
  name: "addtoken",
  description: "Ajoute un token utilisateur dans le config.json",
  run: async (client, message, args, db, prefix) => {
    if (args.length < 2) {
      return message.edit("Usage: " + prefix + "addtoken <user_id> <token>");
    }

    const userIdToAdd = args[0];
    const tokenToAdd = args[1];
    const configPath = path.join(__dirname, '../../config.json');

    fs.readFile(configPath, 'utf8', (err, data) => {
      if (err) {
        console.error("Erreur lors de la lecture du fichier config.json", err);
        return;
      }

      const config = JSON.parse(data);

      
      if (!config.owner.includes(message.author.id)) {
        return message.edit("Vous n'avez pas la permission d'utiliser cette commande.");
      }

     
      config.user[userIdToAdd] = { id: userIdToAdd, token: tokenToAdd };

      
      fs.writeFile(configPath, JSON.stringify(config, null, 2), 'utf8', (err) => {
        if (err) {
          console.error("Erreur lors de l'écriture dans le fichier config.json", err);
          return;
        }

        
        message.edit("Token ajouté avec succès pour l'utilisateur " + userIdToAdd);
      });
    });
  },
};
