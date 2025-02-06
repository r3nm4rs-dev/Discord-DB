const Discord = require("discord.js-selfbot-v13");

module.exports = {
  name: "owner",
  description: "Affiche la liste des commandes disponibles.",
  run: async (client, message, args, db, prefix) => {
    const helpMessage = `
\`❓\` **Liste des commandes disponibles :**

> \`${prefix}premium\` ➜ **Ajoute un membre premium**
> \`${prefix}delpremium <utilisateur>\` ➜ **Supprime un utilisateur de la liste des membres premium.**
    `;

    message.edit(helpMessage);
  },
};
