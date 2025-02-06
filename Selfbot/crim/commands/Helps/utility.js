// command to get profile picture
const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");

module.exports = {
  name: "utility",
  description: "Menu Utility",
  run: async (client, message, args, db, prefix) => {
    message.edit(
      await language(
        client,
        `# Crim 
- \`${prefix}serverinfo <guildID>\`
 - **Affiche les informations d'un serveur**
- \`${prefix}profile <@user/ID>\`
 - **Affiche le profile d'un utilisateur**
- \`${prefix}clear <number>\`
 - **Supprimer un nombre de vos messages**
- \`${prefix}closedms\`
 - **Ferme tous vos DM ouverts**
- \`${prefix}clearall\`
 - **Supprimer tous vos messages dans vos DM's ouvert**
- \`${prefix}find [id]\`
 - **Permet de trouver un utilisateur en vocal**
- \`${prefix}snipe\`
 - **Snipe le dernier message supprimé**`,
        `# Crim 
- \`${prefix}serverinfo <guildID>\`
 - **Shows information about a server**
- \`${prefix}profile <@user/ID>\`
 - **Displays a user's profile**
- \`${prefix}clear <number>\`
 - **Delete a number of your messages**
- \`${prefix}closedms\`
 - **Closes all your open DMs**
- \`${prefix}clearall\`
 - **Delete all your messages open DMs**
- \`${prefix}find [id]\`
 - **Allows you to find a user by voice**
- \`${prefix}snipe\`
 - **Snipe the last deleted message**`
      )
    );
  },
};
