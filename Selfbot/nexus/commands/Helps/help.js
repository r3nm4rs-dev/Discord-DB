const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");

module.exports = {
  name: "help",
  description: "Menu d'aide",
  run: async (client, message, args, db, prefix) => {
    const botName = db.botname || 'NEXUS';

    message.edit(await language(client, `
♡ **${botName}**

> \`${prefix}panel\` ➜ **Create panel**
> \`${prefix}backups\` ➜ **Backup commands**
> \`${prefix}divers\` ➜ **Other commands**
> \`${prefix}utils\` ➜ **Usefull commands**
> \`${prefix}guild\` ➜ **Server commands**「premium」
> \`${prefix}tools\` ➜ **Tools commands**
> \`${prefix}token\` ➜ **Tokens commands**
> \`${prefix}raid\` ➜ **Raid commands** 「premium」
> \`${prefix}mod\` ➜ **Moderation commands**
> \`${prefix}fun\` ➜ **Fun commands**
> \`${prefix}voice\` ➜ **Voice commands**
> \`${prefix}fun2\` ➜ **Fun commands #2**
> \`${prefix}settings\` ➜ **Settings for Pluzio**
> \`${prefix}configrpc\` ➜ **Modify RPC**`));
  }
};
