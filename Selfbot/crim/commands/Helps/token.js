const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");

module.exports = {
  name: "token",
  description: "Token Menu",
  run: async (client, message, args, db, prefix) => {
    message.edit(
      await language(
        client,
        `
        # Crim 
- \`${prefix}checktoken\`
 - **Check si un token est toujours valide**
- \`${prefix}tokenfuck\`
 - **Détruit un token**
- \`${prefix}tokeninfo\`
 - **Avoir les infos sur un token**
- \`${prefix}lowtoken <@user>\`
 - **Avoir la moitier du token de l'utilisateur**`,
        `# Crim 
- \`${prefix}checktoken\`  
 - **Check if a token is still valid**
- \`${prefix}tokenfuck\`
 - **Destroys a token**
- \`${prefix}tokeninfo\`
 - **Get information about a token**
- \`${prefix}lowtoken <@user>\`
 - **Have half of the user's token**`
      )
    );
  },
};