const Discord = require("discord.js-selfbot-v13");
const fs = require('fs').promises;
const path = require('path');

module.exports = {
  name: "wl",
  description: "Ajoute un utilisateur à la liste des membres whitelistés pour qu'il puisse utiliser la commande addpremium.",
  run: async (client, message, args, db, prefix) => {
    const configPath = path.join(__dirname, '../../config.json');

    try {
      // Lecture du fichier config.json
      const configData = await fs.readFile(configPath, 'utf8');
      const config = JSON.parse(configData);

      // Vérification des autorisations (seuls les propriétaires peuvent ajouter à la whitelist)
      if (!config.owner.includes(message.author.id)) {
        return message.edit('`🚫` Tu n\'as pas l\'accès à cette commande');
      }

      // Vérification des arguments
      if (!args.length) {
        return message.edit('`❗` Veuillez mentionner l\'utilisateur à whitelister');
      }

      const mention = args[0];
      const userIdMatch = mention.match(/<@!?(\d+)>/);
      if (!userIdMatch) {
        return message.edit('`❗` Veuillez mentionner un utilisateur valide.');
      }

      const userId = userIdMatch[1];

      // Initialisation de la liste whitelist s'il n'existe pas
      if (!Array.isArray(config.whitelist)) {
        config.whitelist = [];
      }

      // Ajout de l'utilisateur à la liste s'il n'y est pas déjà
      if (!config.whitelist.includes(userId)) {
        config.whitelist.push(userId);

        // Écriture sécurisée dans le fichier config.json
        await fs.writeFile(configPath, JSON.stringify(config, null, 2), 'utf8');
        message.edit(`\`✅\` **L'utilisateur :** <@${userId}> a été __ajouté__ à la __liste__ des **whitelistés**`);
      } else {
        return message.edit(`\`❌\` *L'utilisateur :* <@${userId}> est __déjà__ dans la __liste__ des **whitelistés**`);
      }
    } catch (err) {
      console.error("Erreur lors de la manipulation du fichier config.json", err);
      message.edit('`❌` Une erreur s\'est produite lors de l\'ajout de l\'utilisateur à la whitelist.');
    }
  },
};
