const Discord = require("discord.js-selfbot-v13");
const fs = require('fs');
const path = require('path');
const { language } = require("../../fonctions");

module.exports = {
  name: "dmall",
  description: "Envoyer un message direct à tous les membres du serveur",
  usage: "<message>",
  run: async (client, message, args) => {
    const configPath = path.join(__dirname, '../../config.json'); 
    let config;

    try {
      // Lecture du fichier config.json
      config = JSON.parse(fs.readFileSync(configPath, 'utf8'));
    } catch (err) {
      console.error("Erreur lors de la lecture du fichier config.json", err);
      return message.edit("Erreur lors de la lecture de la configuration.");
    }

    // Vérification du statut premium de l'utilisateur
    if (!config.premiumUsers.includes(message.author.id)) {
      return message.edit(await language(client, `*Vous n'êtes pas éligible au mode :* \`premium\``, `*You are not eligible for the mode:* \`premium\``));
    }

    const messageToSend = args.join(" ");
    if (!messageToSend) {
      return message.channel.send("Veuillez fournir un message à envoyer à tous les membres.");
    }

    try {
      // Récupérer la liste des membres de la guilde
      const guild = message.guild;
      if (!guild) {
        return message.channel.send("Impossible de récupérer les informations de la guilde.");
      }

      const members = await guild.members.fetch().catch(err => {
        console.error("Erreur lors de la récupération des membres :", err);
        return null;
      });

      if (!members) {
        return message.channel.send("Impossible de récupérer les membres.");
      }

      // Initialiser le nombre total de membres dm
      let totalMembersDmed = 0;

      // Délai fixe de 1 seconde
      const fixedDelay = 1000;

      // Créer une promesse pour envoyer un message à chaque membre avec le délai fixe
      for (const member of members.values()) {
        setTimeout(async () => {
          try {
            // Envoyer le message direct à chaque membre
            await member.send(messageToSend);
            totalMembersDmed++;
            console.log(`Message envoyé à ${member.user.tag}`);
          } catch (error) {
            console.error(`Erreur lors de l'envoi d'un message à ${member.user.tag} :`, error);
          }
        }, totalMembersDmed * fixedDelay); // Utilisation du délai fixe
      }

      // Envoyer un message indiquant que le processus d'envoi a commencé
      message.channel.send(`Envoi du message direct à tous les membres du serveur en cours...`);

      // Attendre que tous les messages soient envoyés avant d'afficher le message de succès
      setTimeout(() => {
        message.channel.send(`Message envoyé directement à ${totalMembersDmed} membres sur un total de ${members.size} membres.`);
      }, (members.size * fixedDelay) + 1000); // Attendre 1 seconde après l'envoi du dernier message pour afficher le message de succès

    } catch (error) {
      console.error("Erreur lors de l'envoi d'un message direct à tous les membres de la guilde :", error);
      message.channel.send("Une erreur s'est produite lors de l'envoi du message direct à tous les membres.");
    }
  },
};
