const Discord = require("discord.js-selfbot-v13");

module.exports = {

  name: "deban",

  description: "Débannir un membre du serveur.",

  run: async (client, message, args) => {

    if (!message.member.permissions.has(Discord.Permissions.FLAGS.BAN_MEMBERS)) {

      return message.edit(`\`❌\` Vous n'avez pas la permission de débannir des membres.`);

    }

    if (args.length < 1) {

      return message.edit(`Veuillez spécifier l'ID de l'utilisateur à débannir après la commande.`);

    }

    let userId = args[0];

    let user = await client.users.fetch(userId);

    if (!user) {

      return message.edit(`\`❌\` Utilisateur non trouvé.`);

    }

    let bans = await message.guild.fetchBans();

    let bannedUser = bans.get(user.id);

    if (!bannedUser) {

      return message.edit(`\`❌\` Cet utilisateur n'est pas banni.`);

    }

    await message.guild.members.unban(user.id, args.slice(1).join(" ") || "Aucune raison spécifiée.").catch(console.error);

    message.edit(`\`✅\` ${user.tag} a été débanni du serveur.`);

  }

};