const Discord = require("discord.js");
const db = require('quick.db');
const config = require("../config");

module.exports = {
  name: 'remove-activity',
  usage: 'remove-activity',
  description: `Supprime l'activité actuelle du bot.`,
  async execute(client, message, args) {

    if (config.bot.buyer.includes(message.author.id)) {

      if (!message.guild) return;

        await client.user.setActivity();

        message.channel.send("L'activité a été supprimée avec succès !");
    }
  }
};
