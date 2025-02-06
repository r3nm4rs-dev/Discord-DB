const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");

module.exports = {
  name: "backups",
  description: "Menu Backup",
  run: async (client, message, args, db, prefix) => {
    message.edit(
      await language(
        client,
        `
        # Crim 
- \`${prefix}backup create\`
 - **crée une backup**
- \`${prefix}backup load\`
 - **chargé une backup dans le serveur**
- \`${prefix}backup list\`
 - **la list de t'es backup (en dev)**`,
        `# Crim 
- \`${prefix}backup create\`  
 - **create a backup**
- \`${prefix}backup load\`
 - **chargé une backup dans le serveur**
- \`${prefix}backup list\`
 - **the list of your backup (in dev)**`
      )
    );
  },
};
