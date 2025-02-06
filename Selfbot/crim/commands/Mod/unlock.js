const Discord = require("discord.js-selfbot-v13");

module.exports = {
  name: "unlock",
  description: "Déverrouille le canal pour permettre les messages.",
  run: async (client, message, args, db, prefix) => {
    
    if (!message.member.permissions.has(Discord.Permissions.FLAGS.MANAGE_CHANNELS)) {
      return message.edit("Vous n'avez pas la permission administrateur.");
    }

    try {
     
      await message.channel.permissionOverwrites.edit(message.guild.roles.everyone, {
        SEND_MESSAGES: true
      });

    
      message.edit(`Les membres peuvent de nouveau parler dans <#${message.channel.id}>.`);
    } catch (error) {
      console.error("Erreur lors du déverrouillage du canal :", error);
      message.edit("Une erreur s'est produite lors du déverrouillage du canal.");
    }
  },
};
