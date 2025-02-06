const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");
const config = require("../../config.json"); // Assurez-vous que le chemin d'accès est correct

module.exports = {
  name: "help",
  description: "Menu Help",
  run: async (client, message, args, db, prefix) => {
    const customName = config.customName; // Lit le nom personnalisé à partir du fichier config.json
    message.edit(
      await language(
        client,
        `#   ♡ ・__**${customName}**__ 
    
    \`${prefix}vbh\` ➜ **Notre support**
    \`${prefix}info\` ➜ **Mes informations**
    
     ♡・**__Menu d'aide__**
    
    \`${prefix}help\` ➜ **Menu Help (ce menu)**
    \`${prefix}rpc\` ➜ **Commande de statuts**
    \`${prefix}utility\` ➜ **Commandes d'utilitaire**
    \`${prefix}tools\` ➜ **Commandes de (T00ls)**
    \`${prefix}raid\` ➜ **Commandes de (R@id)**
    \`${prefix}mod\` ➜ **Commandes de modération**
    \`${prefix}nitro\` ➜ **Commandes de nitro**
    \`${prefix}fun\` ➜ **Commandes de fun**
    
    ♡・**__Autres__**
    
    \`${prefix}backups\` ➜ **Commandes de backup**
    \`${prefix}voice\` ➜ **Paramètres vocal**
    \`${prefix}settings\` ➜ **Commandes de paramètres**
    \`${prefix}crfast\` ➜ **Commandes de create**`,
        `
#   ♡ ・__**${customName}**__ 
    
    \`${customName}\` ➜ **Out Support**
    \`${prefix}info\` ➜ **My information**

    ♡・**__Help menu__**
    
    \`${prefix}help\` ➜ **Help menu (this menu)**
    \`${prefix}rpc\` ➜ **Command of status**
    \`${prefix}utility\` ➜ **Commands of utility**
    \`${prefix}tools\` ➜ **Command sof tools (T00ls)**
    \`${prefix}raid\` ➜ **Commands of raid (R@id)**
    \`${prefix}mod\` ➜ **Commands de modération**
    \`${prefix}nitro\` ➜ **Commands of nitro**
    \`${prefix}fun\` ➜ **Commands of fun**
    
    ♡・**__Others__**
    
    \`${prefix}backups\` ➜ **Commands of backup**
    \`${prefix}voice\` ➜ **Parameter vocal**
    \`${prefix}settings\` ➜ **Parameter your settings**
    \`${prefix}crfast\` ➜ **Commands for lazy people**`
      )
    );
  },
};

