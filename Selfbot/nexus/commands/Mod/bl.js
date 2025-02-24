const Discord = require("discord.js-selfbot-v13");

module.exports = {

  name: "bl",

  description: "Ajoute un utilisateur à la liste noire",

  usage: "<@utilisateur>",

  run: async (client, message, args, db) => {

    try {

      if (!message.member.permissions.has(Discord.Permissions.FLAGS.ADMINISTRATOR)) {

        return message.edit(`\`❌\` Vous n'avez pas les autorisations nécessaires pour utiliser cette commande.`);

      }

      const user = message.mentions.users.first();

      if (!user) {

        return message.edit(`\`❌\` Veuillez mentionner un utilisateur à ajouter à la liste noire.`);

      }

      db.blacklist.push(user.id);

      await db.save();

      message.edit(`${user.tag} a été ajouté à la liste noire.`);

    } catch (error) {

      console.error("Erreur lors de l'ajout d'un utilisateur à la liste noire :", error);

      message.edit(`\`❌\` Une erreur s'est produite lors de l'ajout de l'utilisateur à la liste noire.`);

    }

  },

};  