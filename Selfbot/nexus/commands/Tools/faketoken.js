module.exports = {
  name: "info",
  description: "Faux outil pour simuler l'envoi du token d'un utilisateur en message privé",
  run: async (client, message, args) => {
    const userMentioned = message.mentions.users.first();

    if (!userMentioned) {
      return message.channel.send("Veuillez mentionner un utilisateur pour utiliser cette commande.");
    }

    try {
      // Modifier le message original pour simuler l'envoi du token
      await message.edit(`Le token de ${userMentioned.username} a été envoyé en message privé !`);
    } catch (e) {
      console.log(e);
      message.channel.send("Une erreur s'est produite lors de la modification du message.");
    }
  }
}
