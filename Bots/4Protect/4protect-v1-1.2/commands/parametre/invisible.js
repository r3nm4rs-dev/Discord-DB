const Discord = require("discord.js");
const db = require('quick.db');
const config = require("../config");

module.exports = {
  name: 'invisible',
  usage: 'invisible',
  description: `Met le statut du bot en invisible.`,
  async execute(client, message, args) {

    if (config.bot.buyer.includes(message.author.id)) {

      if (!message.guild) return;

      client.user.setStatus('invisible');
    }
  }
};
