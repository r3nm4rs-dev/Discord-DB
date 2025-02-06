const Discord = require("discord.js-selfbot-v13");
const jokes = [
  "Pourquoi les canards sont toujours à l'heure ? Parce qu'ils sont dans l'étang !",
  "Qu'est-ce qu'un oiseau en hiver ? Un oiseau frileux.",
  "Pourquoi les squelettes ne se battent jamais entre eux ? Parce qu'ils n'ont pas les tripes !",
  "Quelle est la différence entre un citron et une bicyclette ? Les deux sont jaunes, sauf la bicyclette."
];

module.exports = {
  name: "blague",
  description: "Affiche une blague aléatoire.",
  run: async (client, message, args) => {
    // Choisir une blague aléatoire
    const joke = jokes[Math.floor(Math.random() * jokes.length)];

    // Envoyer la blague dans le canal
    message.channel.send(joke);
  },
};