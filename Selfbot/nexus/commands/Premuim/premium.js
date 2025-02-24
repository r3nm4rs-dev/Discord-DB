const fs = require('fs');

const path = require('path');

module.exports = {

  name: "premium",

  description: "Ajoute un utilisateur à la liste des membres premium.",

  run: async (client, message, args) => {

    const configPath = path.join(__dirname, '../../config.json');

    // Lecture du fichier config.json

    let config;

    try {

      config = JSON.parse(fs.readFileSync(configPath, 'utf8'));

    } catch (err) {

      console.error("Erreur lors de la lecture du fichier config.json", err);

      return message.edit("Erreur lors de la lecture de la configuration.");

    }

    // Vérification si l'utilisateur est l'owner du bot ou dans la liste blanche

    if (!config.owner.includes(message.author.id) && (!config.whitelist || !config.whitelist.includes(message.author.id))) {

      return message.edit(`\`🚫\` Tu n'as pas l'accès à cette commande.`);

    }

    // Vérification si un utilisateur a été mentionné

    const mention = args[0];

    if (!mention) {

      return message.edit(`\`❗\` Veuillez mentionner l'utilisateur.`);

    }

    const userId = mention.replace(/<@!?(\d+)>/, '$1');

    // Vérification si l'utilisateur est déjà premium

    if (!config.premiumUsers) {

      config.premiumUsers = [];

    }

    if (config.premiumUsers.includes(userId)) {

      return message.edit(`\`❌\` *L'utilisateur :* <@${userId}> est __déjà__ dans la __liste__ des **membres premium**`);

    }

    // Ajout de l'utilisateur à la liste des utilisateurs premium sans durée

    config.premiumUsers.push(userId);

    // Mise à jour du fichier config.json

    try {

      fs.writeFileSync(configPath, JSON.stringify(config, null, 2), 'utf8');

      message.edit(`\`✅\` **L'utilisateur :** <@${userId}> a été __ajouté__ à la __liste__ des **membres premium**`);

    } catch (err) {

      console.error("Erreur lors de l'écriture dans le fichier config.json", err);

      message.edit("Erreur lors de la mise à jour de la configuration.");

    }

  },

};