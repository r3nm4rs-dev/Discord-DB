// antigroup.js
const fs = require('fs');
const path = require('path');

// Fonction de traduction locale
const trad = (enMessage, frMessage, language = 'fr') => {
  return language === 'fr' ? frMessage : enMessage;
};

module.exports = {
  name: "antigroup",
  descriptionfr: "Active ou désactive la protection anti-groupe",
  descriptionen: "Enable or disable anti-group protection",
  usage: "<on/off>",
  run: async (client, message, args) => {
    // Vérifier que l'argument est fourni et valide
    if (!args[0] || (args[0] !== "on" && args[0] !== "off")) {
      return message.edit(trad(
        "Missing parameter: `on` or `off`",
        "Paramètre manquant : `on` ou `off`"
      ));
    }

    // Déterminer le statut de l'anti-groupe
    const noAddGrpStatus = args[0] === "on";

    // Chemin vers le fichier JSON de l'utilisateur
    const userId = message.author.id;
    const dbPath = path.join(__dirname, `../../db/${userId}.json`);

    // Vérifier si le fichier JSON existe
    if (!fs.existsSync(dbPath)) {
      return message.edit("La base de données pour cet utilisateur n'existe pas.");
    }

    // Charger le fichier JSON
    const db = JSON.parse(fs.readFileSync(dbPath, 'utf8'));

    // Modifier le paramètre noaddgrp
    db.noaddgrp = noAddGrpStatus;

    // Sauvegarder les modifications dans le fichier JSON
    fs.writeFileSync(dbPath, JSON.stringify(db, null, 2));

    // Envoyer un message de confirmation
    const responseMessage = noAddGrpStatus
      ? "La protection anti-groupe a été activée."
      : "La protection anti-groupe a été désactivée.";

    message.edit(trad(
      responseMessage,
      responseMessage
    ));
  }
};
