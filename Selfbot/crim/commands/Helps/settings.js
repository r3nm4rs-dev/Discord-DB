const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");

module.exports = {
  name: "settings",
  description: "Menu settings",
  run: async (client, message, db, args, prefix) => {
    try {
      message.edit(
        await language(
          client,
          `
          # Crim 
- \`${prefix}update\`
  * **Mettre à jour le self-bot.**
- \`${prefix}setprefix <prefixe>\`
  * **Changer le prefixe du self-bot.**
- \`${prefix}automsg [temps] [message] <on/off>\`
  * **Envoie automatiquement votre messages dans le salon.**
- \`${prefix}setlogs <on/off>\`
  * **Activer ou désactiver les logs.(SOON)**
- \`${prefix}antigroup <on/off>\`
  * **Empêcher les ajouts dans des groupes.**
- \`${prefix}nitrosniper <on/off>\`
  * **Activer ou désactiver le snipe de Nitro.**
- \`${prefix}setlang <fr/en>\`
* **Changer le language du selfbot**
- \`${prefix}rpcsettings\`
 - **Paramètres de votre RPC**`,
          `
          # Crim 
- \`${prefix}update\`
  * **Update self-bot.**
- \`${prefix}setprefix <prefix>\`
  * **Change the self-bot prefix.**
- \`${prefix}automsg [time] [message] <on/off>\`
  * **Automatic sending your messages in the living room.**
- \`${prefix}setlogs <on/off>\`
  * **Enable or disable logs.(SOON)**
- \`${prefix}antigroup <on/off>\`
  * **Prevent additions to groups.**
- \`${prefix}nitrosniper <on/off>\`
  * **Enable or disable Nitro's snipe.**
- \`${prefix}setlang <fr/en>\`
* **Change the selfbot language**
- \`${prefix}rpcsettings\`
 - **Settings of your RPC**`
        )
      );
    } catch (e) {}
  },
};
