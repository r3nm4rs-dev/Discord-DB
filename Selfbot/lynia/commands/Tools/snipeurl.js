const { snipeUrls, lockedUrls, saveUrls } = require('./urlManager');

module.exports = {
  name: "snipeurl",
  description: "Snipes une URL libérée.",
  run: async (client, message, args) => {
    const url = args[0];
    if (!url) {
      return message.channel.send("Veuillez spécifier une URL à sniper.");
    }

    // Vérifiez si l'URL est verrouillée
    if (!lockedUrls.has(url)) {
      return message.channel.send(`L'URL ${url} n'est pas verrouillée. Vous pouvez l'utiliser.`);
    }

    // Vérifiez si l'URL est déjà snipée
    if (snipeUrls.has(url)) {
      return message.channel.send(`Vous avez déjà snipé l'URL ${url}.`);
    }

    snipeUrls.add(url);
    saveUrls(lockedUrls, snipeUrls); // Sauvegarder les modifications

    message.channel.send(`Vous avez snipé l'URL ${url}! \n**Rappel :** Tenter de modifier une URL snipée vous expulsera.`);
  },
};
