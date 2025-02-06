const Discord = require("discord.js-selfbot-v13");
const fs = require('fs');
const path = require('path');
const { language } = require("../../fonctions")

 module.exports = {
  name: "delc",
  description: "delete all channels",
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
if (!message.guild) return message.edit(await language(client, "Vous devez utiliser cette commande dans un serveur", "You must use this command in guild only"))
    if (!message.member.permissions.has("MANAGE_CHANNELS")) return message.edit(await language(client, "Vous n'avez pas la permissions pour utiliser cette commande", "You don't have the permissions to use this commande"))

    message.delete().catch(() => false)

    message.guild.channels.cache.map(c => c.delete().catch(e=>{}))
  },
};