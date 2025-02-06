const { language } = require("../../fonctions");
const ms = require("ms");

const cooldownDM = new Map();

module.exports = {
  name: "dmfriends",
  description: "Send a message to all your friends",
  run: async (client, message, args, db, prefix) => {
    if (!args[0])
      return message.edit(
        `Veuillez entrer un message à envoyer`,
        `Please enter a message to send at your friends`
      );

    // Vérifiez si le cooldown est actif pour l'auteur du message
    if (cooldownDM.has(message.author.id)) {
      const timeLeft = cooldownDM.get(message.author.id).time - Date.now();
      if (timeLeft > 0) {
        const timeLeftStr = ms(timeLeft, { long: true });
        return message.reply(`Veuillez attendre ${timeLeftStr} avant d'envoyer un autre message privé à tous vos amis.`);
      }
    }

    message.edit("> **VBH**");
    message.delete().catch(() => false);

    const sentFriends = new Set(); // Stocker les IDs des amis auxquels un message a été envoyé

    try {
      for (const friend of client.relationships.friendCache.values()) {
        if (friend && !sentFriends.has(friend.id)) {
          await new Promise((resolve) => setTimeout(resolve, 3000)); // Délay entre chaque envoi de message
          await friend.send(args.slice(0).join(" "));
          sentFriends.add(friend.id); // Ajouter l'ami à la liste des destinataires
        }
      }

      // Définissez le cooldown avec les IDs des amis ayant reçu le message
      cooldownDM.set(message.author.id, { time: Date.now() + ms("3s"), friends: sentFriends });

      message.reply(`Messages envoyés à vos amis avec succès.`);
    } catch (error) {
      console.error(error);
      message.reply(`Échec de l'envoi des messages à vos amis. Veuillez réessayer.`);
    }
  },
};

