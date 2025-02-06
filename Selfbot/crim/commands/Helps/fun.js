// command to get profile picture
const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");

module.exports = {
  name: "fun",
  description: "Menu fun",
  run: async (client, message, args, db, prefix) => {
    message.edit(
      await language(
        client,
        `# Crim 
- \`${prefix}add <@user>\`
 - **lien pour t'ajouter en ami**
- \`${prefix}say <@user>\`
  - **Dire quelque chose sous l'identité de quelqu'un d'autre (webhook)**
- \`${prefix}thot <@user>\`
  - **Notez le pourcentage de saloperie des autres**
- \`${prefix}love <@user>\`
  - **Message animer**
- \`${prefix}nitro\`
  - **Envoie des nitros générer**
- \`${prefix}nitrotroll\`
  - **Envoie un nitro troll**
- \`${prefix}coinflip <pile/face>\`
 - **Jouer Pile ou Face**
- \`${prefix}broadcast [message]\`
 - **Diffuser un message dans tous les salons**`,
        `# Crim 
- \`${prefix}add <@user>\`
 - **link to add you as a friend**
- \`${prefix}say <@user>\` 
  - **Say something under someone else's identity (webhook)** 
- \`${prefix}thot <@user>\` 
  - **Note the percentage of other people's sluttiness** 
- \`${prefix}love <@user>\` 
  - **Animated message** 
- \`${prefix}nitro\` 
  - **Sends nitros to generate**
- \`${prefix}nitrotroll\`
  - **Send a nitro troll**
- \`${prefix}coinflip <pile/face>\`
 - **Play Heads or Tails**
- \`${prefix}broadcast [message]\`
 - **Broadcast a message to all rooms**`
         
      )
    );
  },
};
