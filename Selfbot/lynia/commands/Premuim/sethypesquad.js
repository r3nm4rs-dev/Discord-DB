const fs = require('fs');
const path = require('path');
const { language } = require("../../fonctions");

module.exports = {
  name: "sethypesquad",
  description: "Modifie ton badge de la hypesquad",
  run: async (client, message, args) => {
    const configPath = path.join(__dirname, '../../config.json'); 
    let config;

    try {
      // Lecture du fichier config.json
      config = JSON.parse(fs.readFileSync(configPath, 'utf8'));
    } catch (err) {
      console.error("Erreur lors de la lecture du fichier config.json", err);
      return message.edit(await language(client, "Erreur lors de la lecture de la configuration.", "Error reading configuration."));
    }

    // Vérification du statut premium de l'utilisateur
    if (!config.premiumUsers.includes(message.author.id)) {
      return message.edit(await language(client, 
        "*Vous n'êtes pas éligible au mode :* `premium`", 
        "*You are not eligible for the mode:* `premium`"
      ));
    }

    const hypesquadlist = ["bravery", "brilliance", "balance", "clear"];
    
    const hypesquad = (house) => {
      switch (house) {
        case "clear": return 0;
        case "bravery": return 1;
        case "brilliance": return 2;
        case "balance": return 3;
      }
    };

    if (!args[0] || !hypesquadlist.includes(args[0])) {
      return message.edit(await language(client, 
        "Veuillez entrer l'une de ses options : " + hypesquadlist.map(o => `\`${o}\``).join(', '), 
        "Please enter one of these options: " + hypesquadlist.map(o => `\`${o}\``).join(', ')
      ));
    }

    try {
      await client.user.setHypeSquad(hypesquad(args[0]));
      message.edit(await language(client, 
        "Votre hypesquad a été modifiée", 
        "Your hypesquad has been edited"
      ));
    } catch (error) {
      message.edit(await language(client, 
        "Je n'ai pas pu modifier votre hypesquad", 
        "I can't edit your hypesquad"
      ));
    }
  }
};
