const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");

module.exports = {
  name: "guild",
  description: "Menu pour gérer les paramètres du serveur",
  run: async (client, message, args, db, prefix) => {
    const botName = db.botname || 'NEXUS';
    
    const lang = await language(client, 'fr', 'en'); // Change 'fr' and 'en' based on your actual language configuration

    if (lang === 'fr') {
      message.edit(`
♡ **${botName} - Gestion du serveur**

> \`${prefix}serversetbanner <lien>\` ➜ **Met à jour la bannière du serveur**
> \`${prefix}serverseticon <lien>\` ➜ **Met à jour l'icône du serveur**
> \`${prefix}serversetname <nom>\` ➜ **Modifie le nom du serveur**
> \`${prefix}serversetowner <ID>\` ➜ **Transfère la propriété du serveur**
> \`${prefix}serversetrules <règles>\` ➜ **Modifie les règles du serveur**
> \`${prefix}serversetvanity <vanityURL>\` ➜ **Met à jour le lien vanity du serveur**
      `);
    } else {
      message.edit(`
♡ **${botName} - Server Management**

> \`${prefix}serversetbanner <link>\` ➜ **Update the server banner**
> \`${prefix}serverseticon <link>\` ➜ **Update the server icon**
> \`${prefix}serversetname <name>\` ➜ **Change the server name**
> \`${prefix}serversetowner <ID>\` ➜ **Transfer server ownership**
> \`${prefix}serversetrules <rules>\` ➜ **Modify the server rules**
> \`${prefix}serversetvanity <vanityURL>\` ➜ **Update the server vanity URL**
      `);
    }
  }
}
