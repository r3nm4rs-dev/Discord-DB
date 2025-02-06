// command to get profile picture
const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");

module.exports = {
  name: "rpc",
  description: "Menu status",
  run: async (client, message, db, args, prefix) => {
    try {
      message.edit(
        await language(
          client,
          `
          # Crim 
- \`${prefix}setstatus [online, idle, dnd, invisible]\`  
 - **Changer le statut**
- \`${prefix}configrpc list\`  
 - **Commande pour personnaliser votre RPC**
- \`${prefix}configspotify list\`
 - **Configuration status spotify**
- \`${prefix}setrpc \`
 - **Retire votre rich présence**
- \`${prefix}setrpc list\`
 - **Liste des rich présence pré-configuré**
- \`${prefix}spotify [text]\`  
 - **Activité spotify**
- \`${prefix}clearstatus\`  
 - **Retire l'activité**
- \`${prefix}clocktime [on/off]\`  
 - **Mets le temps actuel en activité**`,
          `
          # Crim
- \`${prefix}setstatus [online, idle, dnd, invisible]\`
 - **Change status**
- \`${prefix}configrpc list\`
 - **Command to customize your RPC**
- \`${prefix}configspotify list\`
 - **Spotify status configuration**
- \`${prefix}setrpc\`
 - **Remove your rich presence**
- \`${prefix}setrpc list\`
 - **List of pre-configured rich presence**
- \`${prefix}spotify [text]\`
 - **Spotify activity**
- \`${prefix}clearstatus\`
 - **Remove activity**
- \`${prefix}clocktime [on/off]\`
 - **Set current time to active**`
        )
      );
    } catch (e) {}
  },
};
