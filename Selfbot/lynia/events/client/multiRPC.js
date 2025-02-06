const Discord = require('discord.js-selfbot-v13');
const chalk = require('chalk');

module.exports = {
  name: 'multiRPC',
  run: async (client) => {
    const db = require(`../../db/${client.user.id}.json`);

    if (db.multi && db.multi.rpcCount > 0) {
      let currentIndex = 0;

      // Fonction pour changer le RPC
      const changeRPC = () => {
        const rpcItem = db.multi.rpcList[currentIndex];

        if (rpcItem && db.rpconoff) {
          const r_ = new CustomStatus(client);
          if (db.rpcemoji) r_.setEmoji(db.rpcemoji);
          if (db.rpctextstatus) r_.setState(db.rpctextstatus);

          const r = new RichPresence(client);
          if (rpcItem.title) r.setName(rpcItem.title);
          if (rpcItem.details) r.setDetails(rpcItem.details);
          if (rpcItem.type) r.setType(rpcItem.type);
          if (rpcItem.rpcsmallimage) r.setAssetsSmallImage(rpcItem.rpcsmallimage);
          if (rpcItem.rpclargeimage) r.setAssetsLargeImage(rpcItem.rpclargeimage);

          try {
            client.user.setActivity(r, r_);
            console.log(chalk.green(`RPC changé: ${rpcItem.title || ''}`));
          } catch (error) {
            console.error(chalk.red('Erreur lors de l\'application du RPC:'), error);
          }
        }

        // Passer à l'élément suivant
        currentIndex = (currentIndex + 1) % db.multi.rpcCount; // Réinitialiser si on dépasse le nombre de RPC

        // Planifier le prochain changement de RPC
        setTimeout(changeRPC, db.multi.changeInterval || 30000); // Utiliser l'intervalle ou 30 secondes par défaut
      };

      // Démarrer le changement de RPC
      changeRPC();
    } else {
      console.log(chalk.yellow('Aucun RPC multirpc configuré.'));
    }
  }
};
