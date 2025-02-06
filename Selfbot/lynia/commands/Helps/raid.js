const { language } = require("../../fonctions");

module.exports = {
  name: "raid",
  description: "Quelques commandes de raid.",
  run: async (client, message, args, db, prefix) => {
    const botName = db.botname || 'NEXUS';

    message.edit(await language(client, `
♡ **${botName} - raid**

> \`${prefix}banall\` ➜ **Ban all un serveur (permission requise).** 「premium」
> \`${prefix}delete-channel\` ➜ **Supprime tous les salons d'un serveur (action irréversible).** 「premium」
> \`${prefix}delete-role\` ➜ **Supprime tous les rôles du serveur.** 「premium」
> \`${prefix}kickall\` ➜ **Kick all tous les membres d'un serveur.** 「premium」 
> \`${prefix}spam\` ➜ **Spam un message**`,

    `
♡ **${botName} - raid**

> \`${prefix}banall\` ➜ **Ban all a server** 
> \`${prefix}delete-channel\` ➜ **Delete all channels from server** 
> \`${prefix}delete-role\` ➜ **Delete all roles from server** 
> \`${prefix}dmall <delay>\` ➜ **Send a private message to all members with a delay (1/2/3/4/5 seconds)** 
> \`${prefix}kickall\` ➜ **Kick all members from the server** 「premium」 
> \`${prefix}spam\` ➜ **Spam message**`));
  },
};
