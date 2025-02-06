const Discord = require("discord.js-selfbot-v13");

module.exports = {
  name: "lock",
  description: "Verrouille le canal pour empêcher les messages.",
  run: async (client, message, args, db, prefix) => {
    
    if (!message.member.permissions.has(Discord.Permissions.FLAGS.MANAGE_CHANNELS)) {
      return message.edit("Vous n'avez pas la permission administrateur.");
    }

    try {
      
      await message.channel.permissionOverwrites.edit(message.guild.roles.everyone, {
        SEND_MESSAGES: false
      });

      
      message.edit(`Les membres ne peuvent plus parler dans <#${message.channel.id}>.`);
    } catch (error) {
      console.error("Erreur lors du verrouillage du canal :", error);
      message.edit("Une erreur s'est produite lors du verrouillage du canal.");
    }
  },
};
