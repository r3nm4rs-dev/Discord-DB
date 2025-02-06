const Discord = require("discord.js-selfbot-v13");
const config = require("../../config.json");

module.exports = {
  name: "search",
  description: "Effectue une recherche sur Google",
  run: async (client, message, args, db, prefix) => {
    if (args.length === 0) {
      return message.edit("Veuillez fournir une requête de recherche.");
    }

    const query = args.join(" ");
    const url = `https://www.google.com/search?q=${encodeURIComponent(query)}`;

    message.edit(`Recherche Google pour "${query}": ${url}`);
  },
};
