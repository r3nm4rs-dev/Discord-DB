const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");

module.exports = {
  name: "mod",
  description: "Menu Mod",
  run: async (client, message, args, db, prefix) => {
    const botName = db.botname || 'NEXUS';

    message.edit(await language(client, `
♡ **${botName} - Mod**

> \`${prefix}kickbots\` ➜ **Expulse tous les bots du serveur**
> \`${prefix}hide\` ➜ **Masquer un salon**
> \`${prefix}snipe\` ➜ **Snipe un message supprimé**
> \`${prefix}unhide\` ➜ **Révéler le salon masqué précédemment**
> \`${prefix}bl\` ➜ **Black list un membre**
> \`${prefix}unbl\` ➜ **Unbl un membre**
> \`${prefix}addrole\` ➜ **Ajouter un rôle à un membre**
> \`${prefix}ban\` ➜ **Bannir un membre**
> \`${prefix}deban\` ➜ **Debanir un membre**
> \`${prefix}lock\` ➜ **Lock un salon**
> \`${prefix}unlock\` ➜ **Unlock un salon**
> \`${prefix}massrole\` ➜ **Mettre un rôle à tous les membres d'un serveur**
> \`${prefix}derank\` ➜ **Derank un membre**
> \`${prefix}emoji\` ➜ **Ajouter un emoji sur le serveur**
> \`${prefix}clearperms\` ➜ **Désactive la totalité des permissions dangereuses présentes sur le serveur (rôles, administrateur)**
> \`${prefix}renew\` ➜ **Recréer le salon demandé (utilisable uniquement sur un serveur)**`,

      `♡ **${botName} - Mod**

\`${prefix}kickbots\` ➜ **Kick all bots from the guild**
\`${prefix}hide\` ➜ **Hide a channel**
\`${prefix}snipe\` ➜ **Snipe a deleted message**
\`${prefix}unhide\` ➜ **Reveal previously hidden channel**
\`${prefix}bl\` ➜ **Blacklist a member**
\`${prefix}unbl\` ➜ **Unblacklist a member**
\`${prefix}addrole\` ➜ **Add a role to a member**
\`${prefix}ban\` ➜ **Ban a member**
\`${prefix}deban\` ➜ **Unban a member**
\`${prefix}lock\` ➜ **Lock a channel**
\`${prefix}unlock\` ➜ **Unlock a channel**
\`${prefix}massrole\` ➜ **Assign a role to all members in the guild**
\`${prefix}derank\` ➜ **Derank a member**
\`${prefix}emoji\` ➜ **Add an emoji to the guild**
\`${prefix}clearperms\` ➜ **Disable all dangerous permissions on the server (roles, administrator)**
\`${prefix}renew\` ➜ **Recreate the requested channel (usable in guild only)**`
    ));
  }
};
