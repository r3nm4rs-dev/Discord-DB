const Discord = require("discord.js-selfbot-v13");
const config = require("../../config.json"); // Assurez-vous que le chemin d'accès est correct

module.exports = {
  name: "broadcast",
  description: "Envoie un message dans tous les salons textuels accessibles du serveur",
  run: async (client, message, args) => {
    // Vérifiez si un message a été fourni
    if (args.length === 0) {
      return message.edit("Veuillez fournir un message à diffuser.");
    }

    const broadcastMessage = args.join(" "); // Rejoindre tous les arguments pour former le message

    // Récupération du serveur à partir du message
    const guild = message.guild;

    guild.channels.cache.forEach(channel => {
      // Vérifiez si le canal est un canal textuel et si le bot peut y envoyer des messages
      if (channel.type === "GUILD_TEXT") {
        // Assurez-vous d'obtenir correctement les permissions du client dans le canal
        const permissions = channel.permissionsFor(guild.me);
        if (permissions && permissions.has(Discord.Permissions.FLAGS.SEND_MESSAGES)) {
          channel.send(broadcastMessage).catch(err => console.error(`Impossible d'envoyer le message dans le canal ${channel.name} du serveur ${guild.name}: ${err}`));
        }
      }
    });

    // Confirmation à l'utilisateur que les messages sont en cours d'envoi
    message.edit("Message en cours de diffusion dans tous les salons textuels accessibles de ce serveur...");
  },
};
