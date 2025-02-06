const Discord = require("discord.js-selfbot-v13");
const { language, savedb } = require("../../fonctions");

module.exports = {
  name: "samsungrpc",
  description: "Modifie le Samsung RPC status",
  run: async (client, message, args, db) => {
    try {
      if (!args.length) {
        return message.edit("Veuillez fournir l'action (START, UPDATE, STOP)");
      }

      const appId = "com.kiloo.subwaysurf"
      const action = args[0] ? args[0].toUpperCase() : ""; 

     
      if (!["START", "UPDATE", "STOP"].includes(action)) {
        return message.edit("Action invalide. Les actions valides sont : START, UPDATE, STOP.");
      }

     
      client.user.setSamsungActivity(appId, action);

      message.edit(language(client, "Votre Samsung RPC status a été modifié pour RL2D", "Your Samsung RPC status has been editted for RL2D"));
    } catch (e) {
      console.error(e);
    }
  },
};
