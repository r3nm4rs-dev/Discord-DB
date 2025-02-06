const fs = require('fs');
const path = require('path');
const { language } = require("../../fonctions");

module.exports = {
  name: "serverseticon",
  description: "Modifie l'icône du serveur actuel",
  run: async (client, message, args) => {
    const configPath = path.join(__dirname, '../../config.json');
    let config;

    try {
      // Read the configuration file
      config = JSON.parse(fs.readFileSync(configPath, 'utf8'));
    } catch (err) {
      console.error("Error reading config.json", err);
      return message.edit(await language(client, 
        "Erreur lors de la lecture de la configuration.", 
        "Error reading configuration."
      ));
    }

    // Check if the user is premium
    if (!config.premiumUsers.includes(message.author.id)) {
      return message.edit(await language(client, 
        "*Vous n'êtes pas éligible au mode :* `premium`", 
        "*You are not eligible for the mode:* `premium`"
      ));
    }

    // Check if the command is used in a guild
    if (!message.guild) {
      return message.edit(await language(client, 
        "Veuillez executer cette commande dans un serveur", 
        "Please run this command on a server"
      ));
    }

    // Check for required permissions
    if (!message.guild.members.me.permissions.has("MANAGE_GUILD")) {
      return message.edit(await language(client, 
        "Vous n'avez pas les permissions nécessaires pour executer cette commande", 
        "You do not have the necessary permissions to run this command"
      ));
    }

    // Handle icon update with attachment or URL
    const attachmentUrl = message.attachments.first()?.url;
    const providedUrl = args[1] && (args[1].startsWith("https://") || args[1].startsWith("http://"));

    if (attachmentUrl) {
      try {
        await message.guild.setIcon(attachmentUrl);
        return message.edit(await language(client, 
          "L'icône du serveur a été modifiée", 
          "The icon has been edited"
        ));
      } catch {
        return message.edit(await language(client, 
          "Je n'ai pas pu modifier l'icône du serveur", 
          "I can't edit the icon of the server"
        ));
      }
    } else if (providedUrl) {
      try {
        await message.guild.setIcon(args[1]);
        return message.edit(await language(client, 
          "L'icône du serveur a été modifiée", 
          "The icon has been edited"
        ));
      } catch {
        return message.edit(await language(client, 
          "Je n'ai pas pu modifier l'icône du serveur", 
          "I can't edit the icon of the server"
        ));
      }
    } else {
      return message.edit(await language(client, 
        "Veuillez me donner un lien/fichier valide", 
        "Give me a valid link/file"
      ));
    }
  }
};
