const Discord = require("discord.js-selfbot-v13");

module.exports = {
  name: "pingall",
  description: "Mentionner tous les membres du serveur",
  run: async (client, message, args) => {
    // ID du serveur où la commande est limitée à l'owner
    const restrictedServerId = "1265595157819166730";

    // Si c'est le serveur restreint
    if (message.guild.id === restrictedServerId) {
      // Vérifier si l'utilisateur est l'owner du serveur
      const guildOwner = message.guild.ownerId;

      if (message.author.id !== guildOwner) {
        return message.channel.send("Seul l'owner du serveur peut utiliser cette commande ici.");
      }
    }

    // Récupérer les membres et les mentionner
    const members = await message.guild.members.fetch();
    const memberTags = members.map(member => `<@${member.user.id}>`);

    let chunkSize = 2000; // Discord limite les messages à environ 2000 caractères
    let messageChunks = [];
    let tempMessage = "";

    memberTags.forEach(tag => {
      if (tempMessage.length + tag.length + 1 > chunkSize) {
        messageChunks.push(tempMessage);
        tempMessage = "";
      }
      tempMessage += `${tag} `;
    });

    if (tempMessage) messageChunks.push(tempMessage);

    messageChunks.forEach(chunk => {
      message.channel.send(chunk).catch(console.error);
    });
  },
};
