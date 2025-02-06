const Discord = require("discord.js-selfbot-v13");
const { language, savedb } = require("../../fonctions");

module.exports = {
  name: "antibots",
  description: "Activate / Deactivate the antibot feature",
  run: async (client, message, args, db) => {
    try {
      if (!args[0] || (args[0] !== "on" && args[0] !== "off")) {
        return message.edit(await language(client, `Veuillez écrire \`on\` ou \`off\` après la commande`, `Please write \`on\` or \`off\` after the command`));
      }

      if (args[0] === "on") {
        db.antibots = true;
        await savedb(client, db);
        message.edit(await language(client, "L'antibots a été activé", "The antibot has been activated"));
      } else {
        db.antibots = false;
        await savedb(client, db);
        message.edit(await language(client, "L'antibots a été désactivé", "The antibot has been deactivated"));
      }
    } catch (e) {
      console.error("Error in antibots command:", e);
    }
  }
};


  


     







