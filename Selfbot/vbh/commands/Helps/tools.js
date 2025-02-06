const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");
const config = require("../../config.json");

module.exports = {
  name: "tools",
  description: "Menu Help",
  run: async (client, message, args, db, prefix) => {
    const customName = config.customName;
      message.edit(
      await language(
        client,
        `
⛧ __**${customName} - Tools**__ ⛧
*Vaut mieux être seul que mal accompagné.*
\`${prefix}closedms\` ➜ **Fermez tous vos dms**
\`${prefix}emoji\` ➜ **Crée un emoji**
\`${prefix}find\` ➜ **Rechercher un utilisateur en vocal dans tous les serveurs**
\`${prefix}grplocker\` ➜ **Vérouille le groupe**
\`${prefix}ipinfo\` ➜ **Obtenir des informations sur une adresse IP**
\`${prefix}raimbowrole\` ➜ **Créez un rôle arc-en-ciel**
\`${prefix}leaveguildall\` ➜ **Quitte tout les serveurs ou tu est présent**
\`${prefix}resetprofil\` ➜ **Reset le profil de ton compte**
\`${prefix}robuser\` ➜ **Voler le profil d'un utilisateur**
\`${prefix}panel\` ➜ **Crée un panel pour utiliser les commandes en sécurité**
\`${prefix}crown\` ➜ **Voir qui a la couronne du serveur preciser**`,
        `⛧ __**${customName} - Tools**__ ⛧
*Better to be alone than in bad company.*
\`${prefix}closedms\` ➜ **Close all your dms**
\`${prefix}emoji\` ➜ **Create an emoji**
\`${prefix}find\` ➜ **Search for a user by voice in all servers**
\`${prefix}grplocker\` ➜ **Lock the group**
\`${prefix}ipinfo\` ➜ **Get information about an IP address**
\`${prefix}raimbowrole\` ➜ **Make a rainbow role**
\`${prefix}leaveguildall\` ➜ **Leaves all servers where you are present**
\`${prefix}resetprofil\` ➜ **Reset your account profile**
\`${prefix}robuser\` ➜ **Steal a user's profile**
\`${prefix}panel\` ➜ Create a panel to use security commands**
\`${prefix}crown\` ➜ **See who has the server crown specify**`
      )
    );
  },
};
