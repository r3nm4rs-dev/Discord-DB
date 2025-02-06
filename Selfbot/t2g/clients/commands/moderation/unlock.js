module.exports = {
    name: "unlock",
    description: "Verrouiller un salon",
    run: async (client, message, args) => {
      try {
  if (!message.member.permissions.has("MANAGE_CHANNELS")) {
    if(client.db.lang === "fr") message.edit("***Vous n'avez pas la permission de gérer les salons!***");
    if(client.db.lang === "en") message.edit("***You do not have permission to manage channels!***");
    return
  }
  
        const channel = message.mentions.channels.first() || message.channel;
  
        await channel.permissionOverwrites.edit(message.guild.roles.everyone, {
          SEND_MESSAGES: true
        });
  
              if(client.db.lang === "fr") message.edit(`***Le salon: ${channel} a été déverrouillé**.*`);
      if(client.db.lang === "en") message.edit(`***The channel ${channel} has been unlocked**.*`);
      } catch (err) {
        console.log(err);
      }
    }
  };
  