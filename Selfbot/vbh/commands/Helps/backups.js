const Discord = require("discord.js-selfbot-v13");
const {  language } = require("../../fonctions")
const config = require("../../config.json");

module.exports = {
  name: "backups",
  description: "backup Mode",
  run: async (client, message, args, db, prefix) => {
      const customName = config.customName;
      message.edit(await language(client, `⛧ __**${customName} - Backup**__ ⛧
\`${prefix}backup create\` ➜ **crée une backup**
\`${prefix}backup load\` ➜ **charge une backup dans un serveur**
\`${prefix}backup delete\` ➜ **supprimer une backup (en dev)**
\`${prefix}backup list\` ➜ **la list de t'es backup (en dev)**
⛧ __**${customName} - Backup User**__ ⛧
\`${prefix}saveuser\` ➜ **crée la backup de l'utilisateur qui fais la commande**
\`${prefix}loaduser\` ➜ **charge une backup sur le compte ou vous avez fais la commande**


`,
    `⛧ __**${customName} - Backup**__ ⛧
    \`${prefix}backup create\` ➜ **create a backup**
    \`${prefix}backup load\` ➜ **upload a save to a server**
    \`${prefix}backup delete\` ➜ **delete a backup (in dev)**
    \`${prefix}backup list\` ➜ **the list of your backup (en dev)**
⛧ __**${customName} - Backup User**__ ⛧
\`${prefix}saveuser\` ➜ **create the backup of the user who makes the command**
\`${prefix}loaduser\` ➜ **charge une backup sur le compte ou vous avez fais la commande**







`
    ))
  }
}