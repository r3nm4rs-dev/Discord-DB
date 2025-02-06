const Discord = require("discord.js-selfbot-v13");

module.exports = {
  name: "resetprofil",
  description: "Réinitialise le profil de l'utilisateur",
  run: async (client, message, args) => {
    try {
      // Réinitialise le statut de l'utilisateur à "online" sans jeu ou activité
      await client.user.setStatus('online');
      await client.user.setActivity(null);

      // Si l'utilisateur a une bannière, la supprime
      
        await client.user.setBanner(null);
        const getBannerOrReturnNull = user => user.banner || null;
       
      

      // Réinitialise la description de l'utilisateur
      client.user.setAboutMe(null);

      // Réinitialise la photo de profil à l'image par défaut
      await client.user.setAvatar(null);

      // Envoie un message de confirmation à l'utilisateur
      message.edit("**Votre profil a été réinitialisé avec succès.**");
    } catch (error) {
      console.error(error);
      message.edit("**Échec de la réinitialisation du profil. Veuillez réessayer ultérieurement.**");
    }
  },
};

