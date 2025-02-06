const Discord = require("discord.js-selfbot-v13");

const { language, savedb } = require("../../fonctions");

module.exports = {

  name: "setlogs",

  description: "Définir le webhook des logs de messages",

  run: async (client, message, args, db, prefix) => {

    try {

      if (!args[0]) {

        db.webhooklogs = null;

        await savedb(client, db);

        return message.edit(await language(client, "Le webhook des logs a été supprimé", "The message logs webhook has been deleted"));

      } else {

        if (!args[0].startsWith("https://")) return message.edit(await language(client, "Veuillez fournir une URL de webhook valide", "Please provide a valid webhook URL"));

        db.webhooklogs = args[0];

        await savedb(client, db);

        message.edit(await language(client, "Le webhook des logs a été mis à jour", "The message logs webhook has been updated"));

      }

    } catch (error) {

      console.error("Erreur lors de la définition du webhook des logs de messages :", error);

      message.edit(await language(client, "Une erreur s'est produite lors de la définition du webhook des logs de messages", "An error occurred while setting the message logs webhook"));

    }

  },

};