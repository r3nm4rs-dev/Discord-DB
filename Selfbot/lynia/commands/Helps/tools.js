const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");

module.exports = {
  name: "tools",
  description: "Menu Help",
  run: async (client, message, args, db, prefix) => {
    const botName = db.botname || 'NEXUS';

    const menuFr = `
♡ **${botName} - tools**

> \`${prefix}ipinfo [ip]\` ➜ **Obtenir des informations sur une adresse IP** 
> \`${prefix}dmfriends [message]\` ➜ **Envoie un message privé à tous tes amis** 「premium」
> \`${prefix}pingall\` ➜ **Ping tous les membres d'un serveur**
> \`${prefix}setdark\` ➜ **Met votre thème Discord en noir**
> \`${prefix}setlight\` ➜ **Met votre thème Discord en blanc**
> \`${prefix}sethypesquad\` ➜ **Active/Change votre badge Hypesquad <clear/bravery/brilliance/balance>** 「premium」
> \`${prefix}spoof <desktop/mobile/web/android/console>\` ➜ **Change la plateforme du client Discord**`;

    const menuEn = `
__♡ **${botName} - tools**__

> \`${prefix}backup\` ➜ **Create a backup (create, load, etc.)** 
> \`${prefix}ipinfo [ip]\` ➜ **Get information about an IP address** 
> \`${prefix}leaveguild\` ➜ **Exit all Discord servers** 
> \`${prefix}dmfriends [message]\` ➜ **Send a private message to all your friends** 「premium」 
> \`${prefix}username [user]\` ➜ **Search for the user on social networks**`;

    const response = await language(client, menuFr, menuEn);
    await message.edit(response);
  },
};
