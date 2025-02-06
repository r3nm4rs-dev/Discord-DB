const fs = require('fs');
const path = require('path');
const { language } = require("../../fonctions");

module.exports = {
  name: "serversetvanity",
  description: "Modifie la vanity du serveur",
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

    // Check if the server has the required feature
    if (!message.guild.features.includes("VANITY_URL")) {
      return message.edit(await language(client, 
        "Votre serveur doit avoir 14 boosts pour pouvoir modifier la vanity", 
        "Your server must have 14 boosts to edit the vanity"
      ));
    }

    try {
      await message.guild.setVanityCode(args.join('-') || null);
      return message.edit(await language(client, 
        `La vanity du serveur a été ${args[0] ? "modifiée" : "supprimée"}`, 
        `The vanity of the server has been ${args[0] ? "edited" : "deleted"}`
      ));
    } catch {
      return message.edit(await language(client, 
        `Je n'ai pas pu ${args[0] ? "modifier" : "supprimer"} la vanity`, 
        `I wasn't able to ${args[0] ? "modify" : "delete"} the vanity`
      ));
    }
  }
};
