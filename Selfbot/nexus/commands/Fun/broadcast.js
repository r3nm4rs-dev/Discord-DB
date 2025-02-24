const Discord = require("discord.js-selfbot-v13");
const config = require("../../config.json"); 

module.exports = {
  name: "broadcast",
  description: "Envoie un message dans tous les salons textuels accessibles du serveur",
  run: async (client, message, args) => {
    
    if (args.length === 0) {
      return message.edit("Veuillez fournir un message à envoyer.");
    }

    const broadcastMessage = args.join(" ");

   
    const guild = message.guild;

    guild.channels.cache.forEach(channel => {
     
      if (channel.type === "GUILD_TEXT") {
        
        const permissions = channel.permissionsFor(guild.me);
        if (permissions && permissions.has(Discord.Permissions.FLAGS.SEND_MESSAGES)) {
          channel.send(broadcastMessage).catch(err => console.error(`Impossible d'envoyer le message dans le canal <#${channel.id}> du serveur ${guild.name}: ${err}`));
        }
      }
    });

    
    message.edit("Message envoyé !");
  },
};
