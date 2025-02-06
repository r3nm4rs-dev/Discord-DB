// command to get profile picture
const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");

module.exports = {
  name: "mod",
  description: "Menu Mod",
  run: async (client, message, args, db, prefix) => {
    message.edit(
      await language(
        client,
        `# Crim 
- \`${prefix}kickbots\`
 - **Expulse tout les bots du serveur**
- \`${prefix}clearperms\`
- **Désactivez toutes les permissions dangereuses sur le serveur (rôles, administrateur)**
- \`${prefix}lock\`
 - **Verrouiller le salon**
- \`${prefix}unlock\`
 - **Déverouille le salon**
- \`${prefix}renew\`
 - **Recréé le salon demandé (utilisable uniquement sur un serveur)**
- \`${prefix}addrole [user] [rôle]\`
 - **Ajoute le role préciser**`,
        `# Crim 
- \`${prefix}kickbots\`
 - **Kick all bots from the guild**
- \`${prefix}clearperms\`
 - **Disable all dangerous permissions on the server (roles, administrator)**
- \`${prefix}lock\`
 - **Lock the channel**
- \`${prefix}unlock\`
 - **Unlock the channel**
- \`${prefix}renew\`
 - **Recreate a channel (usable in guild only)**
- \`${prefix}addrole [user] [role]\`
- **Add the specified role**`

      )
    );
  },
};
