const Discord = require("discord.js-selfbot-v13");

module.exports = {
  name: "kick",
  description: "Kick a user",
  run: async (client, message, args) => {

    if (!message.guild) {
      if(client.db.lang === "fr") message.edit(`***You need to use this command within a server**.*`);
      if(client.db.lang === "en") message.edit(`***You do not have the permission to use this command**.*`);
      return
    }

    if (!message.member.permissions.has("KICK_MEMBERS")) {
      if(client.db.lang === "fr") message.edit(`***Vous n'avez pas la permission d'utiliser cette commande**.*`);
      if(client.db.lang === "en") message.edit(`***You do not have the permission to use this command**.*`);
      return
    }

    const userToKick = message.mentions.members.first();

    if (!userToKick) {
      if(client.db.lang === "fr") message.edit(`***Veuillez mentionner un utilisateur à expulser**.*`);
      if(client.db.lang === "en") message.edit(`***Please mention a user to kick**.*`);
      return
    }

    const reason = args.slice(1).join(" ");


    await userToKick.kick({ reason }).catch(() => false);
    if(client.db.lang === "fr") message.edit(`***L'utilisateur <@${userToKick.id}> a été expulsé(e)**.*`);
    if(client.db.lang === "en") message.edit(`***The user <@${userToKick.id}> has been kicked out**.*`);
  },
};