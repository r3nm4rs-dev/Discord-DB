const Discord = require("discord.js-selfbot-v13");

module.exports = {
  name: "pingall",
  description: "Ping tout le monde (sauf les bots) et envoie un lien de serveur à la fin.",
  run: async (client, message, args) => {
    const guild = message.guild;
    const inviteLink = "https://discord.com/invite/JwPdaEDRy8"; // Remplace par ton lien d'invitation

    try {
      const members = await guild.members.fetch();
      const nonBotMembers = members.filter(member => !member.user.bot);

      const chunkSize = 70; // Nombre de mentions par message
      const membersArray = Array.from(nonBotMembers.values());
      let index = 0;

      // Envoi de messages par lots de 20 mentions
      while (index < membersArray.length) {
        const chunk = membersArray.slice(index, index + chunkSize);
        const mentions = chunk.map(member => `<@${member.id}>`).join(" ");

        if (mentions) {
          message.channel.send(mentions); // Ne pas attendre l'envoi pour accélérer le processus
        }

        index += chunkSize;
      }

      // Envoi du message final avec le lien d'invitation après toutes les mentions
      message.channel.send(`# Rejoignez-nous sur le serveur Discord : ${inviteLink}`);
    } catch (error) {
      console.error(`Error during execution:`, error);
    }
  },
};

