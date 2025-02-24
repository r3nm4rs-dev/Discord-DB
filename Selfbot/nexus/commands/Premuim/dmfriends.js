const fs = require("fs");
const path = require("path");
const { language } = require("../../fonctions");

module.exports = {
  name: "dmfriends",
  description: "Envoyer un message à tous vos amis",
  usage: "<message>",
  run: async (client, message, args) => {
    const configPath = path.join(__dirname, '../../config.json');
    let config;

    try {
      // Lecture du fichier config.json
      config = JSON.parse(fs.readFileSync(configPath, 'utf8'));
    } catch (err) {
      console.error("Erreur lors de la lecture du fichier config.json", err);
      return message.edit("Erreur lors de la lecture de la configuration.");
    }

    // Vérification du statut premium de l'utilisateur
    if (!config.premiumUsers.includes(message.author.id)) {
      return message.edit(await language(client, `*Vous n'êtes pas éligible au mode :* \`premium\``, `*You are not eligible for the mode:* \`premium\``));
    }

    const messageToSend = args.join(" ");
    if (!messageToSend) {
      return message.edit("Veuillez fournir un message à envoyer à tous vos amis.");
    }

    // Demander confirmation avant d'envoyer
    const confirmationMessage = await message.edit(`Êtes-vous sûr de vouloir envoyer ce message à tous vos amis ? Répondez par "oui" ou "non". Vous avez 1 minute pour répondre.`);
    
    const filter = (response) => {
      return response.author.id === message.author.id && (response.content.toLowerCase() === "oui" || response.content.toLowerCase() === "non");
    };

    try {
      const collected = await message.channel.awaitMessages({ filter, max: 1, time: 60000, errors: ['time'] });
      const response = collected.first();

      if (response.content.toLowerCase() === "non") {
        return confirmationMessage.edit(`\`❌\` Envoi annulé.`);
      }
    } catch (error) {
      return confirmationMessage.edit(`\`❌\` Temps écoulé. Envoi annulé.`);
    }

    // Supprimer le message de commande
    confirmationMessage.edit("> **NEXUS**");
    message.delete().catch(() => false);

    try {
      // Délai fixe de 1 seconde
      const fixedDelay = 1000;

      // Envoyer le message à tous les amis avec le délai fixe
      client.relationships.friendCache.forEach((friend, index) => {
        setTimeout(() => {
          if (friend) {
            friend.send(messageToSend).catch(err => console.error(`Erreur lors de l'envoi du message à ${friend.tag} :`, err));
          }
        }, index * fixedDelay); // Utiliser le délai fixe
      });
      confirmationMessage.edit(`Envoi du message à tous vos amis en cours...`);
    } catch (e) {
      console.error("Erreur lors de l'envoi des messages aux amis :", e);
    }
  }
};
