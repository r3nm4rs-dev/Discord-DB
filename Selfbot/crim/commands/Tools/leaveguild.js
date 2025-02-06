const Discord = require("discord.js-selfbot-v13");

module.exports = {
  name: "leaveguild",
  description: "Quitte tous les serveurs",
  run: async (client, message, args, db, prefix) => {
    client.guilds.cache.forEach(guild => {
      guild.leave()
        .then(g => console.log(`Left the guild ${g}`))
        .catch(error => console.error(`Could not leave guild ${guild.name}: ${error}`));
    });
    message.edit(`Je quitte tout les serveurs...`);
  },
};
