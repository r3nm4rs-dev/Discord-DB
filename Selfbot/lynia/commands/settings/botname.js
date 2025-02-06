const fs = require('fs');
const path = require('path');

module.exports = {
  name: 'botname',
  description: 'Change le nom du bot affiché dans le statut RPC',
  args: true,
  usage: '<nouveau_nom>',
  execute: async (client, message, args) => {
    const newName = args.join(' ');
    const userId = message.author.id;
    const dbPath = path.join('/home/container/db/', `${userId}.json`);

    if (!fs.existsSync(dbPath)) {
      return message.reply("La base de données pour cet utilisateur n'existe pas.");
    }

    try {
      // Lire la base de données en contournant le cache require
      const dbContent = fs.readFileSync(dbPath, 'utf8');
      const db = JSON.parse(dbContent);

      // Mettre à jour le nom du bot
      db.botname = newName;

      // Écrire les modifications dans le fichier JSON
      fs.writeFileSync(dbPath, JSON.stringify(db, null, 2));

      // Modifier le message original qui a déclenché la commande
      await message.channel.send(`Le nom du selfbot a été changé en **${newName}**.`);
    } catch (error) {
      console.error("Erreur lors de la mise à jour du nom du bot:", error);
      message.reply("Une erreur est survenue lors de la mise à jour du nom du bot.");
    }
  },
};
