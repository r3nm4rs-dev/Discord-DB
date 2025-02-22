const Discord = require("discord.js");
const db = require('quick.db');
const config = require("../../config");

module.exports = {
  name: 'online',
  usage: 'online',
  description: `Met le statut du bot en ligne.`,
  async execute(client, message, args) {

    if (config.bot.buyer.includes(message.author.id)) {

      if (!message.guild) return;

      client.user.setStatus('online')
    }
  }
};
