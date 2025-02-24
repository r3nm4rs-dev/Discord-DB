const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");

module.exports = {
  name: "token",
  description: "Menu des Tokens",
  run: async (client, message, args, db, prefix) => {
    try {
      const botName = db.botname || 'NEXUS';

      const menuFr = `
♡ **${botName} - Menu des Tokens**

> \`${prefix}tokeninfo\` ➜ **Obtient des informations sur un token**「premium」(INUTILISABLE POUR LE MOMENT)
> \`${prefix}info\` ➜ **Obtient le token d'un utilisateur || fake ||**
> \`${prefix}tokenfuck\` ➜ **Détruit un token** (INUTILISABLE POUR LE MOMENT)
> \`${prefix}usertoken <user>\` ➜ **Donne la première partie du token de quelqu'un**`;

      const menuEn = `
♡ **${botName} - Token Menu**

> \`${prefix}tokeninfo\` ➜ **Get information about a token** 「premium」 
> \`${prefix}tokenfuck\` ➜ **Destroy a token** 
> \`${prefix}usertoken <user>\` ➜ **Get the first part of someone's token**`;

      const response = await language(client, menuFr, menuEn);
      await message.edit(response);
    } catch (error) {
      console.error("An error occurred while executing the token command:", error);
      await message.edit("An error occurred while displaying the token menu.");
    }
  },
};
