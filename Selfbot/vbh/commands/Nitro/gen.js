const Discord = require("discord.js-selfbot-v13");
const { language, savedb, nitrocode } = require("../../fonctions");

const nbLiensNitroParMessage = 3; // Nombre de liens Nitro par message

module.exports = {
  name: "gen",
  description: "Génère un nombre défini de codes Nitro aléatoires.",
  run: async (client, message, args, db) => {
    try {
      // Vérifier le nombre d'arguments
      if (!args.length) {
        return message.edit(`❌ Veuillez fournir un nombre de codes Nitro à générer.`);
      }

      // Analyser le nombre
      const nbCodes = parseInt(args[0]);
      if (isNaN(nbCodes) || nbCodes <= 0) {
        return message.edit(`❌ Veuillez fournir un nombre valide supérieur à 0.`);
      }

      // Générer les codes Nitro
      const codesNitro = [];
      for (let i = 0; i < nbCodes; i++) {
        codesNitro.push(`https://discord.gift/${nitrocode(16, "0aA")}`);
      }

      // Envoyer les codes Nitro
      for (let i = 0; i < codesNitro.length; i += nbLiensNitroParMessage) {
        const messageContent = `${codesNitro.slice(i, i + nbLiensNitroParMessage).join("\n")}`;

        // Envoyer le message
        await message.channel.send(messageContent);
      }
    } catch (error) {
      console.error(error);
      message.edit(`❌
 Erreur : ${error.message}`);
    }
  },
};

