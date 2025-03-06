const { Client, Intents } = require("oceanic.js");

module.exports = {
  name: "gspam",
  descriptionfr: "Spam un nombre de messages (gspam stop pour arrêter)",
  descriptionen: "Spam a number of messages (gspam stop to stop the spam)",
  usage: "<nombre> <message> ou stop",
  run: async (client, message, args) => {
    // Supprime la commande une fois exécutée
    message.delete().catch(() => false);

    // Vérification si aucun argument
    if (!args[0]) {
      return message.channel.send(
        "Veuillez spécifier un nombre et un message à envoyer, ou utiliser 'stop' pour arrêter."
      ).catch(() => false);
    }

    // Gestion du stop
    if (args[0].toLowerCase() === "stop" && !args[1]) {
      if (client.msgspammer) {
        clearInterval(client.msgspammer);
        client.msgspammer = null;
      }
      return; // Quitte après avoir arrêté
    }

    // Conversion du premier argument en nombre
    const amount = parseInt(args[0], 10);
    const messageToSend = args.slice(1).join(" ");

    // Validation des arguments
    if (isNaN(amount) || amount <= 0) {
      return message.channel.send("Veuillez fournir un nombre valide de messages.")
        .catch(() => false);
    }

    if (!messageToSend) {
      return message.channel.send("Veuillez préciser un message à envoyer.")
        .catch(() => false);
    }

    // Spam
    let count = 0;

    client.msgspammer = setInterval(() => {
      if (count >= amount) {
        clearInterval(client.msgspammer);
        client.msgspammer = null;
        return;
      }

      message.channel.send(messageToSend).catch(() => false);
      count++;
    }, 1000); // Envoie un message toutes les secondes
  },
};
