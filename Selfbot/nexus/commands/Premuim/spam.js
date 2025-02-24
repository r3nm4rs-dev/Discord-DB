const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions")

module.exports = {
  name: "spam",
  description: "Spam a message",
  run: async (client, message, args) => {
    const amount = parseInt(args[0]);
    const messageToSend = args.slice(1).join(" ");

    message.delete().catch(() => false);

    if (!amount) {
      return message.channel.send(await language(client, "Veuillez me donner un nombre de messages à envoyer", "Please specify an amount of messages to send.")).catch(() => false);
    }

    if (isNaN(amount)) {
      return message.channel.send(await language(client, "Veuillez me donner un nombre valide", "Give me a valid number"));
    }

    if (!messageToSend) {
      return message.channel.send(await language(client, "Veuillez me donner un message à envoyer", "Please specify a message to send.")).catch(() => false);
    }

    if (amount > 100) {
      return message.channel.send(await language(client, "La limite est de 100 messages. Veuillez choisir un nombre inférieur ou égal à 100.", "The limit is 100 messages. Please choose a number less than or equal to 100.")).catch(() => false);
    }

    for (let i = 0; i < amount; i++) {
      message.channel.send(messageToSend).catch(() => false);
    }
  },
};
