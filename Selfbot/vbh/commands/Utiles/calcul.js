const Discord = require("discord.js-selfbot-v13");
const math = require("mathjs");

module.exports = {
  name: "calcul",
  description: "Effectue un calcul mathématique.",
  run: async (client, message, args, db, prefix) => {
    if (args.length === 0) {
      return message.edit("Veuillez fournir une expression à calculer. Exemple: `calc 2 + 2`");
    }

    const query = args.join(" ");
    try {
      const result = math.evaluate(query);
      message.edit(`Résultat de \`${query}\` : ${result}`);
    } catch (error) {
      message.edit(`Erreur de calcul: \`${error.message}\``);
    }
  },
};
