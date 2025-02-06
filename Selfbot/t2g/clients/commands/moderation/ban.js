const Discord = require("discord.js-selfbot-v13");

module.exports = {
  name: "ban",
  description: "Ban a user",
  run: async (client, message, args) => {
    if (!message.guild) {
      if(client.db.lang === "fr") message.edit(`***You need to use this command within a server**.*`);
      if(client.db.lang === "en") message.edit(`***You do not have the permission to use this command**.*`);
      return
    }

    if (!message.member.permissions.has("BAN_MEMBERS")) {
      if(client.db.lang === "fr") message.edit(`***Vous n'avez pas la permission d'utiliser cette commande**.*`);
      if(client.db.lang === "en") message.edit(`***You do not have the permission to use this command**.*`);
      return
    }

    const userToBan = message.mentions.members.first();

    if (!userToBan) {
      if(client.db.lang === "fr") message.edit(`***Veuillez mentionner un utilisateur à bannir**.*`);
      if(client.db.lang === "en") message.edit(`***Please mention a user to ban**.*`);
      return
    }

    const reason = args.slice(1).join(" ");

    await userToBan.ban({ reason }).catch(() => false);
    if(client.db.lang === "fr") message.edit(`***L'utilisateur <@${userToBan.id}> a été ban**.*`);
    if(client.db.lang === "en") message.edit(`***The user <@${userToBan.id}> has been banned**.*`);
  },
};