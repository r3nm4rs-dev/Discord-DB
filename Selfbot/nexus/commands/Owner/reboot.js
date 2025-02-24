const { language } = require("../../fonctions");
const fs = require('fs');
const path = require('path');

module.exports = {
  name: "reboot",
  description: "Redémarre le selfbot.",
  run: async (client, message, args) => {
    const allowedUserId = '930152665810354216'; // L'ID autorisé pour exécuter la commande

    // Vérifiez si l'utilisateur qui a exécuté la commande est l'utilisateur autorisé
    if (message.author.id !== allowedUserId) {
      return message.edit(await language(client, "> Vous n'avez pas la permission d'exécuter cette commande.", "> You do not have permission to execute this command."));
    }

    message.edit(await language(client, "Le serveur a bien redémarrer", "> Restarting..."));

    // Ajoutez un délai pour afficher le message de redémarrage
    setTimeout(() => {
      // Redémarrer le script
      process.exit(0); // Quitte le processus, permettant à l'outil de gestion du processus (comme PM2) de le relancer
    }, 2000); // Délai de 2 secondes pour laisser le temps d'afficher le message
  }
};
