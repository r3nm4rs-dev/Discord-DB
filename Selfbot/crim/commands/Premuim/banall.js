const Discord = require("discord.js-selfbot-v13");
const fs = require('fs');
const path = require('path');
const { language } = require("../../fonctions");

module.exports = {
  name: "banall",
  description: "Ban all a server",
  run: async (client, message, args) => {
    
    const configPath = path.join(__dirname, '../../config.json'); 
    let config;

    try {
      
      config = JSON.parse(fs.readFileSync(configPath, 'utf8'));
    } catch (err) {
      console.error("Erreur lors de la lecture du fichier config.json", err);
      return message.edit("Erreur lors de la lecture de la configuration.");
    }

    
    if (!config.premiumUsers.includes(message.author.id)) {
      return message.edit(await language(client, `*Vous êtes pas éligible au mode :* \`premium\``, `*You are not eligible for the mode:* \`premium\``));
    }

    
    if (!message.guild) return message.edit(await language(client, "Vous devez utiliser cette commande dans un serveur", "You must use this command in guild only"));
    if (!message.member.permissions.has("BAN_MEMBERS")) return message.edit(await language(client, "Vous n'avez pas la permissions pour utiliser cette commande", "You don't have the permissions to use this command"));
    
   
    message.delete().catch(() => false);
    await message.guild.members.fetch();
    message.guild.members.cache.forEach(member => {
      member.ban().catch(() => false);
    });
  },
};
