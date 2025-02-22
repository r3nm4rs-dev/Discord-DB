const Discord = require("discord.js");
const db = require('quick.db');
const config = require("../config");

module.exports = {
  name: 'idle',
  usage: 'idle',
  description: `Met le statut du bot en inactif.`,
  async execute(client, message, args) {

    if (config.bot.buyer.includes(message.author.id)) {

      if (!message.guild) return;

      client.user.setStatus('idle')
        .then(() => {
          message.channel.send("Mon statut est désormais inactif !");
        })
    }
  }
};