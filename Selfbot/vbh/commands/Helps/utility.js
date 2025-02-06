const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");
const config = require("../../config.json");

module.exports = {
  name: "utility",
  description: "Menu Help",
  run: async (client, message, args, db, prefix) => {
    const customName = config.customName;
      message.edit(
      await language(
        client,
        `⛧ __**${customName} - Utiles**__ ⛧
\`${prefix}avatar <@user>\` ➜ **Permet de voir l'avatar de quelqu'un**
\`${prefix}userinfo <@user>\` ➜ **Informations utilisateur**
\`${prefix}banner <@user>\` ➜ **Montre la bannière de quelqu'un**
\`${prefix}serverinfo <serverid>\` ➜ **Informations serveur**
\`${prefix}ping\` ➜ **Teste de latence**
\`${prefix}restart\` ➜ **Redémarre le bot**
\`${prefix}notifs <on/off>\` ➜ **Activer ou désactiver les notifications**
\`${prefix}setavatar\` ➜ **Changer l'avatar (envoyer une image)**
\`${prefix}edituser list\` ➜ **Changer les informations utilisateurs, tel le nom d'utilisateur, tag etc...**
\`${prefix}dmfriends <message>\` ➜ **Envoyer un message à tout vos amis**
\`${prefix}joinvc <channelid>\` ➜ **Rejoindre un salon vocal**
\`${prefix}rainbowrole <@role> [-stop]\` ➜ **Rôle multi-couleur**
\`${prefix}leaveserver/leaveguild <server id>\` ➜ **Quitte un serveur**
\`${prefix}antigroup <on/off>\` ➜ **Permet d'activer ou de désactiver l'anti-groupe**
\`${prefix}find [ID]\` ➜ **Vous trouve un utilisateur dans les salons communs**
\`${prefix}closedms\` ➜ **Ferme les DM's**
\`${prefix}clear [number]\` ➜ **Supprimer un nombre de message demandé.**
\`${prefix}savechat [channel] [number]\` ➜ **Sauvegarder un nombre de message demandé d'un salon en question sous format txt.**
\`${prefix}notes add/list/del\` ➜ **Notes vos messages dans un blocknotes.**
\`${prefix}search\` ➜ **Effectuer une recherche sur google.**
\`${prefix}calcul\` ➜ **Effectuer un calcul mathématiques.**`,
        `⛧ __**${customName} - Utility**__ ⛧
\`${prefix}avatar <@user>\` ➜ **Allows you to see someone's avatar**
\`${prefix}userinfo <@user>\` ➜ **User information**
\`${prefix}banner <@user>\` ➜ **Show someone's banner**
\`${prefix}serverinfo <serverid>\` ➜ **Server Information**
\`${prefix}ping\`➜ **Test the latency**
\`${prefix}restart\` ➜ **Restart the bot**
\`${prefix}notifs <on/off>\` ➜ **Enable or disable notifications**
\`${prefix}setavatar\` ➜ **Change avatar (send an image)**
\`${prefix}edituser list\` ➜ **Change user information, such as username, tag etc...**
\`${prefix}createwebhook\` ➜ **Created a webhook in the channel**
\`${prefix}dmfriends <message>\` ➜ **Send a message to all your friends**
\`${prefix}joinvc <channelid>\` ➜ **Join a vocal salon**
\`${prefix}rainbowrole <@role> [-stop]\` ➜ **Multi-color role**
\`${prefix}leaveserver/leaveguild <server id>\` ➜ **Leave a server**
\`${prefix}antigroup <on/off>\` ➜ **Allows you to activate or deactivate the anti-group**
\`${prefix}create [emoji]\` ➜ **Create an emoji**
\`${prefix}antijoin <on/off>\` ➜ **Block access to the current voice**
\`${prefix}find [ID]\` ➜ **You find a user in the common voice chats**
\`${prefix}closedms\` ➜ **Close the DM's**
\`${prefix}clear [number]\` ➜ **Delete a requested number of messages.**
\`${prefix}savechat [channel] [number]\` ➜ **Save a number of requested messages from a given salon in txt format.**
\`${prefix}notes add/list/del\` ➜ **Note your messages in your own notes**
\`${prefix}search\` ➜ **Perform a search on google**
\`${prefix}calculation\` ➜ **Perform a mathematical calculation.**`
      )
    );
  },
};
