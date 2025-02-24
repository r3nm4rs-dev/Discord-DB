// Exemple de commande pour retirer un utilisateur de la liste noire

module.exports = {

  name: "unbl",

  description: "Retire un utilisateur de la liste noire",

  usage: "<@utilisateur>",

  run: async (client, message, args, db) => {

    try {

      // Vérifier si l'utilisateur a les autorisations nécessaires pour utiliser cette commande

      if (!message.member.hasPermission("ADMINISTRATOR")) {

        return message.channel.send("Vous n'avez pas les autorisations nécessaires pour utiliser cette commande.");

      }

      // Vérifier si un utilisateur a été mentionné

      const user = message.mentions.users.first();

      if (!user) {

        return message.channel.send("Veuillez mentionner un utilisateur à retirer de la liste noire.");

      }

      // Retirer l'utilisateur de la liste noire dans la base de données

      const index = db.blacklist.indexOf(user.id);

      if (index !== -1) {

        db.blacklist.splice(index, 1);

        await db.save();

        message.channel.send(`${user.tag} a été retiré de la liste noire.`);

      } else {

        message.channel.send(`${user.tag} n'est pas dans la liste noire.`);

      }

    } catch (error) {

      console.error("Erreur lors du retrait d'un utilisateur de la liste noire :", error);

      message.channel.send("Une erreur s'est produite lors du retrait de l'utilisateur de la liste noire.");

    }

  },

};