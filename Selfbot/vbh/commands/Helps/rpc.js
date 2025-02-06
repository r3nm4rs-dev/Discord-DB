// command to get profile picture
const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");
const config = require("../../config.json");

module.exports = {
  name: "rpc",
  description: "Menu status",
  run: async (client, message, db, args, prefix) => {
    try {
     const customName = config.customName;
        message.edit(
        await language(
          client,
          `
⛧ __**${customName} - Status**__ ⛧
\`${prefix}configrpc list\` ➜ **Configure ton RPC**
\`${prefix}setstatus [online, idle, dnd, invisible]\` ➜ **Changer le statut**
\`${prefix}setrpc [rpcname]\` ➜ **Mettre une rich présence en activité** \`${prefix}setrpc\` **list pour la liste**
\`${prefix}rpcsettings\` ➜ **Paramètres de votre RPC**
\`${prefix}spotify [text]\` ➜ **Activité spotify**
\`${prefix}clearstatus\` ➜ **Retire l'activité**
\`${prefix}clocktime [on/off]\` ➜ **Mets le temps actuel en activité**
\`${prefix}customstatus emoji [emoji]\`➜ **Vous permet de mettre un emoji dans votre statut**
\`${prefix}customstatus content [texte1] [texte2] [texte3]\`➜ **Vous permet de mettre des textes dans votre statut**`,
          `
⛧ __**${customName} - Status**__ ⛧
\`${prefix}configrpc list\` ➜ **Configure your RPC** 
\`${prefix}setstatus [online, idle, dnd, invisible]\` ➜ **Change status**
\`${prefix}setrpc [rpcname]\` ➜ **Activate a rich presence**
\`${prefix}setrpc\` **list for the list**
\`${prefix}rpcsettings\` ➜ **Settings for your RPC**
\`${prefix}spotify [text]\` ➜ **Spotify activity**
\`${prefix}clearstatus\` ➜ **Remove activity**
\`${prefix}clocktime [on/off]\` ➜ **Activate current time**
\`${prefix}customstatus emoji [emoji]\`➜ **Permits you to put an emoji in your status**
\`${prefix}customstatus content [text1] [text2] [text3].\`➜ **Permits you to put texts in your status**`
        )
      );
    } catch (e) {}
  },
};
