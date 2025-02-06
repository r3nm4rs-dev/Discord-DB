const Discord = require("discord.js-selfbot-v13");

module.exports = {
  name: "createchannel",
  description: "Crée un nouveau salon avec le nom spécifié.",
  run: async (client, message, args) => {
    if (!message.member.permissions.has(Discord.Permissions.FLAGS.MANAGE_CHANNELS)) {
      return message.edit("Tu n'as pas la permission de créer des salons !");
    }

    const channelName = args.join(" "); // Récupère le nom du salon à partir des arguments
    if (!channelName) {
      return message.edit("S'il te plaît, spécifie le nom du salon à créer.");
    }

    // Crée le salon avec le nom spécifié
    message.guild.channels.create(channelName, {
      type: 'GUILD_TEXT', // ou 'GUILD_VOICE' pour un salon vocal
    })
    .then(channel => {
      message.edit(`Salon créé avec succès : ${channel.toString()}`);
    })
    .catch(error => {
      console.error(error);
      message.edit("Une erreur s'est produite lors de la création du salon.");
    });
  },
};
