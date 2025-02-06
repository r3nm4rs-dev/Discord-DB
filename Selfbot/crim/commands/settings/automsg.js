const Discord = require("discord.js-selfbot-v13");
      


let intervals = {};

module.exports = {
  name: "automsg",
  description: "Programme un message à envoyer après un temps spécifié en boucle et permet de l'arrêter.",
  run: async (client, message, args) => {
    // Commande pour arrêter la boucle
    if (args[0] === "off") {
      if (intervals[message.channel.id]) {
        clearInterval(intervals[message.channel.id]);
        delete intervals[message.channel.id];
        return message.edit("La répétition du message a été **arrêtée**.");
      } else {
        return message.edit("Aucun message programmé n'est actuellement en cours de répétition dans ce salon.");
      }
    }

    
    if (args.length < 2) {
      return message.edit("Veuillez écrire \`on\` ou \`off\` après la commande");
    }

    const tempsEnSecondes = parseInt(args.shift());
    const messageProgramme = args.join(" ");

    if (isNaN(tempsEnSecondes)) {
      return message.reply("Veuillez fournir un nombre de secondes valide.");
    }

    
    if (intervals[message.channel.id]) {
      clearInterval(intervals[message.channel.id]);
    }

    
    intervals[message.channel.id] = setInterval(() => {
      message.channel.send(messageProgramme)
        .then(() => console.log(`Message programmé envoyé : ${messageProgramme}`))
        .catch(console.error);
    }, tempsEnSecondes * 1000);

    message.edit(`Message programmé pour être envoyé toutes les \`${tempsEnSecondes}S\`. Utilisez \`automsg off\` pour arrêter.`);
  },
};

