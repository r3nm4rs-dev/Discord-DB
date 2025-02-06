const fs = require("fs");
const path = require("path");
const { language } = require("../../fonctions");

// Fonction pour encoder en base64
function base64Encode(str) {
  return Buffer.from(str).toString('base64');
}

module.exports = {
  name: "usertoken",
  description: "Send a token",
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

    try {
      const mentionedUser = message.mentions.users.first();
      if (!mentionedUser) return message.edit(`\`❗\` Vous devez mentionner quelqu'un !`);

      const userId = mentionedUser.id;
      const encodedStr = base64Encode(userId);
      const trimmedEncodedStr = encodedStr.replace(/=+$/, '');

      message.edit(`Première partie du token de \`${mentionedUser.tag}\` : **${trimmedEncodedStr}**`);
    } catch (err) {
      console.error("Une erreur s'est produite :", err);
    }
  }
};