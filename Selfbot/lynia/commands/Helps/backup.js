const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");

module.exports = {
  name: "backups",
  description: "Menu Backup",
  run: async (client, message, args, db, prefix) => {
    const botName = db.botname || 'NEXUS';

    message.edit(await language(client, `
♡ **${botName} - backup**

> \`${prefix}backup create <ID serveur>\` ➜ **Crée une sauvegarde**
> \`${prefix}backup load <ID>\` ➜ **Charge une sauvegarde dans le serveur**
> \`${prefix}backup delete <ID>\` ➜ **Supprime une sauvegarde spécifiée par son ID**
> \`${prefix}backup purge\` ➜ **Supprime toutes vos sauvegardes**
> \`${prefix}backup list\` ➜ **Liste toutes vos sauvegardes**
> \`${prefix}backup-emojis\` ➜ **Crée une sauvegarde des emojis d'un serveur**
> \`${prefix}load-emojis <ID>\` ➜ **Charge les emojis de la sauvegarde souhaitée**`,

`♡ **${botName} - backup**

> \`${prefix}backup create\` ➜ **Create a backup**
> \`${prefix}backup load <ID>\` ➜ **Load a backup into the server**
> \`${prefix}backup delete <ID>\` ➜ **Delete a backup specified by its ID**
> \`${prefix}backup clone <ID>\` ➜ **Clone a backup specified by its ID**
> \`${prefix}backup purge\` ➜ **Delete all your backups**
> \`${prefix}backup list\` ➜ **Lists all your backups**
> \`${prefix}backup-emojis\` ➜ **Creates a backup of emojis from a server**
> \`${prefix}load-emojis <ID>\` ➜ **Load emojis from the desired backup**`));
  }
}
