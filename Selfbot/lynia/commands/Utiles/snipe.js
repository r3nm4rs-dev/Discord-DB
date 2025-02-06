const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");
const fs = require('fs');

module.exports = {
  name: "snipe",
  description: "Snipe the last message",
  run: async (client, message, args) => {
    const msg = client.snipes.get(message.channel.id);
    if (!msg) return message.edit("Aucun message enregistré.");

    const dbFilePath = `./db/${client.user.id}.json`;
    const db = JSON.parse(fs.readFileSync(dbFilePath));

    const botName = db.botname || "NEXUS V3";

    message.edit(
      await language(
        client,
        `♡**${botName} Message-Sniper**♡
    > Auteur: ${msg.author}
    > Message: ${msg.content}
    > Image: ${msg.image}
    > Date: <t:${parseInt(msg.date / 1000, 10)}:R>`,
        `♡**${botName} Message-Sniper**♡
    > Author: ${msg.author}
    > Content: ${msg.content}
    > Image: ${msg.image}
    > Date: <t:${parseInt(msg.date / 1000, 10)}:R>`
      )
    );
  },
};
