const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");

module.exports = {
  name: "tools",
  description: "Menu Help",
  run: async (client, message, args, db, prefix) => {
    message.edit(
      await language(
        client,
        `
        # Crim 
- \`${prefix}ipinfo [ip]\`
 - **Obtenir des informations sur une adresse IP**
- \`${prefix}leaveguild\`
 - **Quitte tous les serveurs discords**
- \`${prefix}dmfriends [message]\`
 - **Envoie un message priver a tous t'est amis**
- \`${prefix}robuser <@user>\`
 - **Modifie ton profil comme l'utilisateur**
- \`${prefix}username [user]\`
 - **Recherche l'user sur des réseaux sociaux**
- \`${prefix}spam [nombre]\`
 - **Spam un message**
- \`${prefix}paypal [username]\`
 - **Envoie ton lien paypal**`,
        `# Crim
- \`${prefix}ipinfo\`
 - **Get information about an IP address**
- \`${prefix}leaveguild\`
 - **Exit all discord servers**
- \`${prefix}dmfriends [message]\`
 - **Send a private message to all your friends**
- \`${prefix}robuser <@user>\`
 - **Edit your profile like the user**
- \`${prefix}username [user]\`
 - **Search for the user on social networks**
- \`${prefix}spam\`
 - **Spam a message**
- \`${prefix}paypal [username]\`
 - **Send your paypal link**`
      )
    );
  },
};
