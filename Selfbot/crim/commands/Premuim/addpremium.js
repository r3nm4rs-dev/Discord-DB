const Discord = require("discord.js-selfbot-v13");
const fs = require('fs');
const path = require('path');

module.exports = {
  name: "addpremium",
  description: "Ajoute un utilisateur à la liste des membres premium.",
  run: async (client, message, args, db, prefix) => {
    
    const configPath = path.join(__dirname, '../../config.json');
    const configData = fs.readFileSync(configPath, 'utf8');
    const config = JSON.parse(configData);

   
    if (!config.owner.includes(message.author.id)) {
      return message.edit(`\`🚫\` Tu n'as pas l'accès à cette commande`);
    }

    if (!args.length) {
      return message.edit(`\`❗\` Veuillez mentionner l'utilisateur`);
    }

    const mention = args[0];
    const userId = mention.replace(/<@!?(\d+)>/, '$1');

    fs.readFile(configPath, 'utf8', (err, data) => {
      if (err) {
        console.error("Erreur lors de la lecture du fichier config.json", err);
        return;
      }

      const config = JSON.parse(data);

      if (!config.premiumUsers) {
        config.premiumUsers = [];
      }

      if (!config.premiumUsers.includes(userId)) {
        config.premiumUsers.push(userId);
      } else {
        return message.edit(`\`❌\` *L'utilisateur :* <@${userId}> est __déjà__ dans la __liste__ des **membres premium**`);
      }

      fs.writeFile(configPath, JSON.stringify(config, null, 2), 'utf8', (err) => {
        if (err) {
          console.error("Erreur lors de l'écriture dans le fichier config.json", err);
          return;
        }

        message.edit(`\`✅\` **L'utilisateur :** <@${userId}> à été __ajouté__ à la __liste__ des **membres premium**`);
      });
    });
  },
};

