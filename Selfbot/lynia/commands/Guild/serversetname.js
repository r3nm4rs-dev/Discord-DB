const fs = require('fs');
const path = require('path');
const { language } = require("../../fonctions");

module.exports = {
  name: "serversetname",
  description: "Modifie le nom du serveur actuel",
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

    // Check for server name argument
    if (!args[0]) {
      return message.edit(await language(client, 
        "Veuillez entrer un nom de serveur", 
        "Please enter a server name"
      ));
    }

    try {
      await message.guild.setName(args.slice(0).join(" "));
      return message.edit(await language(client, 
        `Le nom du serveur est maintenant \`${args.slice(0).join(" ")}\``, 
        `The guild name is now \`${args.slice(0).join(" ")}\``
      ));
    } catch {
      return message.edit(await language(client, 
        "Je n'ai pas pu modifier le nom du serveur", 
        "I couldn't change the server name"
      ));
    }
  },
};
