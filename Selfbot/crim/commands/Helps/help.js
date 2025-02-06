// command to get profile picture
const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");

module.exports = {
  name: "help",
  description: "Menu Help",
  run: async (client, message, args, db, prefix) => {
    message.edit(
      await language(
        client,
        `# Crim 
*To thine own self, be true.*
- \`${prefix}help\`  
 - **Ce menu**
- \`${prefix}rpc\` 
 - **Commande RPC**
- \`${prefix}utility\` 
 - **Commandes utilitaires**
- \`${prefix}tools\`
 - **Commandes tools**
- \`${prefix}backup\`
 - **Commandes backup**
- \`${prefix}mod\`
 - **Commandes modération**
- \`${prefix}fun\`
 - **Commandes fun**
- \`${prefix}voice\`
 - **Commandes voice**
- \`${prefix}settings\`
 - **paramètres**
- \`${prefix}token\`
 - **Token (dangereux)**`,
        `# Crim 
*To thine own self, be true.*
- \`${prefix}help\`
- **This menu**
- \`${prefix}rpc\`
 - **RPC commands**
- \`${prefix}utility\` 
 - **Utility commands**
- \`${prefix}tools\` 
 - **Tools commands**
- \`${prefix}backups\`
 - **backup commands**
- \`${prefix}mod\`
 - **Moderation commands**
- \`${prefix}fun\`
 - **Fun commands**
- \`${prefix}voice\`
 - **Voice commands**
- \`${prefix}settings\`
 - **Parameter commands**
- \`${prefix}token\`
 - **Token (dangerous)**`
      )
    );
  },
};
