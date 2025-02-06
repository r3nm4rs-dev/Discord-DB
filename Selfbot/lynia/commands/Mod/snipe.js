module.exports = {
  name: "snipe",
  description: "Affiche le dernier message supprimé dans le canal",
  run: async (client, message, args, deletedMessages) => {
    try {
      const snipedMessage = deletedMessages.get(message.channel.id);

      if (!snipedMessage) {
        return message.edit("Il n'y a pas de message supprimé à afficher.");
      }

      message.edit(`**Auteur:** ${snipedMessage.author}\n**Message:** ${snipedMessage.content}\n**Temps:** <t:${Math.floor(snipedMessage.time / 1000)}:R>`);
    } catch (error) {
      console.error("Erreur lors de l'affichage du message snipé", error);
      message.edit("Une erreur s'est produite lors de l'affichage du message snipé.");
    }
  },
};