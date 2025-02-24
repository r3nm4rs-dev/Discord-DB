const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");
const fs = require('fs');

module.exports = {
  name: "avatar",
  description: "Get a user's avatar",
  run: async (client, message, args) => {
    try {
      let user;
      if (!args[0]) user = message.author;
      if (args[0]) user = message.mentions.users.first() || await client.users.fetch(args[0]);

      const dbFilePath = `./db/${client.user.id}.json`;
      const db = JSON.parse(fs.readFileSync(dbFilePath));

      const botName = db.botname || "NEXUS V3"; // Fallback to "Bot" if botname is not defined

      if (!user) {
        message.edit(`⛧ **${botName}**♡  \n> **Avatar de : <@${message.author.id}>\n> Photo :** ` +
          client.user.displayAvatarURL({ dynamic: true, size: 4096 })
        );
        return;
      }

      message.edit(`⛧ **${botName}**♡ \n> **Avatar de : <@${user.id}>\n> Photo :** ` +
        user.displayAvatarURL({ dynamic: true, size: 4096 })
      );
    } catch (e) {
      message.edit(await language(client, `Aucun utilisateur trouvé pour \`${args[0] || "rien"}\``, `No user found for \`${args[0] || "nothing"}\``));
    }
  },
};
