const { language } = require("../../fonctions");

module.exports = {
  name: "fun2",
  description: "Menu fun",
  run: async (client, message, args, db, prefix) => {
    const botName = db.botname || 'NEXUS';

    message.edit(
      await language(
        client,
        `♡ **${botName} - Fun**

> \`${prefix}dadjoke\` ➜ **Obtenez une blague de papa aléatoire !**
> \`${prefix}mock\` ➜ **Parodie le texte que vous fournissez !**
> \`${prefix}meme\` ➜ **Affiche un mème aléatoire.**
> \`${prefix}rizz\` ➜ **Envoyez un message séduisant avec une touche de riz ! 🍚**
> \`${prefix}pizza\` ➜ **Envoie une pizza à quelqu'un ! 🍕**
      `
      )
    );
  },
};
