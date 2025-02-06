const Discord = require("discord.js-selfbot-v13");

module.exports = {

  name: "ban",

  description: "Bannir un membre du serveur.",

  run: async (client, message, args) => {

    if (!message.member.permissions.has(Discord.Permissions.FLAGS.BAN_MEMBERS)) {

      return message.edit(`\`❌\` Vous n'avez pas la permission de bannir des membres.`);

    }

    if (args.length < 1) {

      return message.edit(`Veuillez mentionner un membre à bannir après la commande.`);

    }

    let member = message.mentions.members.first();

    if (!member) {

      return message.edit(`\`❌\` Membre non trouvé.`);

    }

    if (!member.bannable) {

      return message.edit(`\`❌\` Je n'ai pas la permission de bannir ce membre.`);

    }

    await member.ban({ reason: args.slice(1).join(" ") || "Aucune raison spécifiée." }).catch(console.error);

    message.edit(`\`✅\` ${member.user.tag} a été banni du serveur.`);

  }

};