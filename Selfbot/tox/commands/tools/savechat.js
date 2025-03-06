const fs = require("fs");
const path = require("path");

module.exports = {
  name: "savechat",
  descriptionfr: "Sauvegarde tous les messages d'un salon ou d'un DM sous forme de fichier TXT.",
  descriptionen: "Save all messages from a channel or DM as a TXT file.",
  usage: "<filename>",
  run: async (client, message, args) => {
    // Supprimer la commande après exécution
    message.delete().catch(() => false);

    // Nom du fichier spécifié par l'utilisateur ou "chat-log"
    const fileName = args[0] ? `${args[0]}.txt` : "chat-log.txt";

    let allMessages = [];
    let lastMessageId = null;

    try {
      // Récupération des messages du salon par lots
      while (true) {
        const fetchedMessages = await message.channel.messages.fetch({ limit: 100, before: lastMessageId });
        if (fetchedMessages.size === 0) break;

        // Formatage des messages pour sauvegarde
        fetchedMessages.forEach(msg => {
          const time = new Date(msg.createdTimestamp).toLocaleString("fr-FR");
          allMessages.push(`[${time}] ${msg.author.username}#${msg.author.discriminator}: ${msg.content || "(message vide)"}`);
        });

        // Mettre à jour l'ID du dernier message récupéré
        lastMessageId = fetchedMessages.last().id;
      }

      // Inverser pour avoir les messages dans l'ordre chronologique
      allMessages = allMessages.reverse();

      // Générer le fichier
      const filePath = path.join(__dirname, fileName);
      fs.writeFileSync(filePath, allMessages.join("\n"), "utf8");

      // Envoyer le fichier dans le salon
      await message.channel.send({
        content: "Voici l'historique des messages :",
        files: [{ attachment: filePath, name: fileName }]
      });

      // Supprimer le fichier local après envoi
      fs.unlinkSync(filePath);
    } catch (error) {
      console.error(error);
      return message.channel.send("Une erreur est survenue lors de la sauvegarde des messages.")
        .catch(() => false);
    }
  }
};
