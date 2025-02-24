const fs = require('fs');

const path = require('path');

module.exports = {

  name: "setwelcome",

  description: "Définit et envoie un message de bienvenue dans le salon actuel, en mentionnant la personne.",

  usage: "<server_id> <message>",

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

    // Vérification si l'utilisateur est l'owner du bot ou un utilisateur premium

    if (!config.owner.includes(message.author.id) && !config.premiumUsers.includes(message.author.id)) {

      return message.edit(`\`🚫\` Tu n'as pas l'accès à cette commande.`);

    }

    // Vérification des arguments

    const serverId = args[0];

    const welcomeMessage = args.slice(1).join(" ");

    if (!serverId || !welcomeMessage) {

      return message.edit("Veuillez fournir un ID de serveur et un message de bienvenue.");

    }

    // Initialiser l'objet de messages de bienvenue si nécessaire

    if (!config.welcomeMessages) {

      config.welcomeMessages = {};

    }

    // Enregistrement du message de bienvenue pour le serveur donné

    config.welcomeMessages[serverId] = welcomeMessage;

    try {

      fs.writeFileSync(configPath, JSON.stringify(config, null, 2), 'utf8');

      message.edit(`\`✅\` Le message de bienvenue pour le serveur \`${serverId}\` a été mis à jour.`);

      // Envoi du message de bienvenue dans le salon où la commande a été exécutée

      message.channel.send(`${welcomeMessage} <@${message.author.id}>`);

    } catch (err) {

      console.error("Erreur lors de l'écriture dans le fichier config.json", err);

      message.edit("Erreur lors de la mise à jour de la configuration.");

    }

  }

};