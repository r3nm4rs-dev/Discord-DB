module.exports = {
  name: "lockurl",
  description: "Verrouille une URL pour empêcher sa modification.",
  run: async (client, message, args) => {
    if (!args[0]) {
      return message.channel.send("Veuillez spécifier une URL à verrouiller.");
    }

    const url = args[0];

    // Vérifiez si l'URL est déjà verrouillée
    if (lockedUrls.has(url)) {
      return message.channel.send(`L'URL ${url} est déjà verrouillée.`);
    }

    lockedUrls.add(url);
    saveUrls(lockedUrls, snipeUrls); // Utilisation de snipeUrls après l'importation

    message.channel.send(`L'URL ${url} est maintenant verrouillée. Aucun utilisateur ne peut la modifier. \n**Rappel :** Tenter de modifier cette URL entraînera un kick.`);
  },
};
