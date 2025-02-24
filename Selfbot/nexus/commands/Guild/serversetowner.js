const fs = require('fs');
const path = require('path');
const { language } = require("../../fonctions");

module.exports = {
  name: "serversetowner",
  description: "Transmet la propriété du serveur",
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

    // Check if the command user is the owner
    if (message.guild.ownerId !== client.user.id) {
      return message.edit(await language(client, 
        "Vous devez être le propriétaire du serveur pour utiliser cette commande", 
        "You must be the owner of the guild to use this command"
      ));
    }

    // Find the member to transfer ownership
    const member = message.mentions.members.first() || message.guild.members.cache.get(args[0]);
    if (!member) {
      return message.edit(await language(client, 
        `Aucun membre trouvé pour \`${args[0] || "rien"}\``, 
        `No member found for \`${args[0] || "nothing"}\``
      ));
    }

    try {
      await message.guild.setOwner(member);
      return message.edit(await language(client, 
        "Le propriétaire du serveur a été modifié", 
        "The owner of the guild has been changed"
      ));
    } catch {
      return message.edit(await language(client, 
        "Le propriétaire du serveur n'a pas pu être modifié", 
        "The owner of the guild could not be changed"
      ));
    }
  }
};
