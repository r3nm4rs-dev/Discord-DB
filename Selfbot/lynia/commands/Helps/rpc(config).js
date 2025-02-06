const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");

module.exports = {
  name: "configrpc",
  description: "Menu SetRPC",
  run: async (client, message, args, db, prefix) => {
    const botName = db.botname || 'NEXUS V3';

    message.edit(await language(client, `
♡ **${botName} - ConfigRPC Commandes**

> \`${prefix}setrpc bouton1 <texte>\` ➜ **Changer le texte du bouton 1** 
> \`${prefix}setrpc bouton1link <lien>\` ➜ **Changer le lien du bouton 1** 
> \`${prefix}setrpc bouton2 <texte>\` ➜ **Changer le texte du bouton 2** 
> \`${prefix}setrpc bouton2link <lien>\` ➜ **Changer le lien du bouton 2** 
> \`${prefix}setrpc smallimage <url>\` ➜ **Changer l'URL de l'image petite** 
> \`${prefix}setrpc largeimage <url>\` ➜ **Changer l'URL de l'image grande** 
> \`${prefix}setrpc details <détails>\` ➜ **Changer les détails du RPC** 
> \`${prefix}setrpc state <état>\` ➜ **Changer l'état du RPC** 
> \`${prefix}setrpc type <type>\` ➜ **Changer le type du RPC (STREAMING, PLAYING, COMPETING, WATCHING, LISTENING)**
> \`${prefix}setrpc platform <desktop/xbox/ps5/ps4>\` ➜ **Change la platforme de RPC**「premium」
> \`${prefix}setrpc title <titre>\` ➜ **Changer le titre du RPC** 
> \`${prefix}setrpc smallimagetexte <texte>\` ➜ **Changer le texte de l'image petite** 
> \`${prefix}setrpc largeimagetexte <texte>\` ➜ **Changer le texte de l'image grande** 
> \`${prefix}setrpc timerpc <temps>\` ➜ **Mettre le temps du RPC**
----
> \`${prefix}setrpc vsc\` ➜ **Affiche une activité sur Visual Studio Code**
> \`${prefix}setrpc valorant\` ➜ **Affiche une activité sur *VALORANT**
> \`${prefix}setrpc roblox\` ➜ **Affiche une activité sur Roblox**
> \`${prefix}setrpc fortnite\` ➜ **Affiche une activité sur Fortnite**
> \`${prefix}setrpc cod\` ➜ **Affiche une activité sur Call of Duty**
> \`${prefix}setrpc fivem\` ➜ **Affiche une activité sur FiveM**
> \`${prefix}setrpc minecraft\` ➜ **Affiche une activité sur Minecraft**
----
> \`${prefix}rpc <on/off>\` ➜ **Active/Désactive le Rich Presence**
> \`${prefix}settingsrpc\` ➜ **Montre vos paramètres de Rich Presence**`));
  }
};
