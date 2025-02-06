const Discord = require("discord.js-selfbot-v13");
const config = require("../../config.json"); // Assurez-vous que le chemin d'accès est correct

module.exports = {
  name: "createserver",
  description: "Crée un serveur Discord avec le nom spécifié.",
  run: async (client, message, args, db) => {
    if (!args.length) {
      return message.edit(`❌ Veuillez fournir un nom pour le serveur.`);
    }

    const serverName = args.join(" ");

    try {
      // Créer un nouveau serveur
      const newServer = await client.guilds.create(serverName, {
        region: "europe", // Vous pouvez changer la région ici
        icon: null, // Vous pouvez fournir un lien vers une image d'icône ici
        verificationLevel: "none", // Vous pouvez modifier le niveau de vérification ici
      });

      // Rejoindre le serveur
      await newServer.join();

      // Envoyer un message de confirmation
      message.edit(`✅ Serveur créé avec succès : **${newServer.name}** (ID : ${newServer.id})`);
    } catch (error) {
      console.error(error);
      message.edit(`✅ Serveur créé avec succès`);
    }
  },
};
