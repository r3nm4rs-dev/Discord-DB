const fs = require('fs');
const path = require('path');
const { language } = require("../../fonctions");

module.exports = {
  name: "serversetrules",
  description: "Modifie le salon des règles discord",
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

    // Check if server has COMMUNITY feature
    if (!message.guild.features.includes("COMMUNITY")) {
      return message.edit(await language(client, 
        "Vous devez activer la communauté du serveur pour utiliser cette commande", 
        "You must activate the server community to use this command."
      ));
    }

    // Find the channel to set as rules channel
    const channel = message.mentions.channels.first() || message.guild.channels.cache.get(args[1]);
    if (!channel) {
      return message.edit(await language(client, 
        `Aucun salon trouvé pour \`${args[1] || "rien"}\``, 
        `No channel found for \`${args[1] || "nothing"}\``
      ));
    }

    try {
      await message.guild.setRulesChannel(channel);
      return message.edit(await language(client, 
        `Le salon des règles est maintenant : <#${channel.id}>`, 
        `The rules channel is now: <#${channel.id}>`
      ));
    } catch {
      return message.edit(await language(client, 
        "Je n'ai pas pu modifier le salon des règles du serveur", 
        "I've been unable to edit the server's rules channel"
      ));
    }
  }
};
