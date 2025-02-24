const fs = require('fs');
const path = require('path');

// Fonction de traduction locale
const trad = (enMessage, frMessage, language = 'fr') => {
  return language === 'fr' ? frMessage : enMessage;
};

module.exports = {
  name: "nitrosniper",
  descriptionfr: "Active ou désactive le nitro sniper",
  descriptionen: "Enable or disable the nitro sniper",
  usage: "<on/off>",
  run: async (client, message, args) => {
    // Vérifiez que l'argument est fourni et valide
    if (!args[0] || (args[0] !== "on" && args[0] !== "off")) {
      return message.edit(trad(
        "Missing parameter: `on` or `off`",
        "Paramètre manquant: `on` ou `off`"
      ));
    }

    // Déterminez la valeur du nitro sniper
    const nitroSniperStatus = args[0] === "on";

    // Chemin vers le fichier JSON de l'utilisateur
    const userId = message.author.id;
    const dbPath = path.join(__dirname, `../../db/${userId}.json`);

    // Vérifiez si le fichier JSON existe
    if (!fs.existsSync(dbPath)) {
      return message.edit("La base de données pour cet utilisateur n'existe pas.");
    }

    // Chargez le fichier JSON
    const db = require(dbPath);

    // Modifiez le paramètre nitrosniper
    db.nitrosniper = nitroSniperStatus;

    // Sauvegardez les modifications dans le fichier JSON
    fs.writeFileSync(dbPath, JSON.stringify(db, null, 2));

    // Envoyez un message de confirmation
    const responseMessage = nitroSniperStatus
      ? "Le nitro sniper a été activé."
      : "Le nitro sniper a été désactivé.";

    message.edit(trad(
      responseMessage,
      responseMessage
    ));
  }
};
