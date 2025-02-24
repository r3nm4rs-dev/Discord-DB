const fs = require('fs');
const Discord = require('discord.js-selfbot-v13');

module.exports = {
  name: "branlette",
  description: "La meilleure commande",
  run: async (client, message, args) => {
    const sltcv = [
      "8=:fist:==D",
      "8==:fist:=D",
      "8===:fist:D",
      "8==:fist:=D",
      "8=:fist:==D",
      "8:fist:===D",
      "8=:fist:==D",
      "8==:fist:=D",
      "8===:fist:D",
      "8==:fist:=D:sweat_drops:",
      "8===:fist:D:sweat_drops:"
    ];

    const delay = (ms) => new Promise(resolve => setTimeout(resolve, ms));

    for (let i = 0; i < sltcv.length; i++) {
      try {
        await message.edit(sltcv[i]);
        await delay(500);
      } catch (error) {
        console.error("Erreur lors de la modification du message:", error);
      }
    }
  }
};
