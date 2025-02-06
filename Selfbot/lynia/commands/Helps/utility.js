const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");

module.exports = {
  name: "utils",
  description: "Menu Help",
  run: async (client, message, args, db, prefix) => {
    const botName = db.botname || 'NEXUS';

    const menuFr = `
♡ **${botName} - Menu Utilitaires**

> \`${prefix}avatar <@user>\` ➜ **Permet de voir l'avatar de quelqu'un**
> \`${prefix}userinfo <@user>\` ➜ **Informations utilisateur**
> \`${prefix}banner <@user>\` ➜ **Montre la bannière de quelqu'un**
> \`${prefix}serverinfo <serverid>\` ➜ **Informations serveur**
> \`${prefix}ping\` ➜ **Teste de latence**
> \`${prefix}restart\` ➜ **Redémarre le bot**
> \`${prefix}notifs <on/off>\` ➜ **Activer ou désactiver les notifications**
> \`${prefix}setavatar\` ➜ **Changer l'avatar (envoyer une image)**
> \`${prefix}createwebhook\` ➜ **Créé un webhook dans le salon**
> \`${prefix}dmfriends <message>\` ➜ **Envoyer un message à tous vos amis**
> \`${prefix}leaveguild <server id>\` ➜ **Quitte un serveur**
> \`${prefix}leaveall\` ➜ **Quitte tout les serveurs**
> \`${prefix}antigroup <on/off>\` ➜ **Permet d'activer ou de désactiver l'anti-groupe**
> \`${prefix}find [ID]\` ➜ **Vous trouve un utilisateur dans les salons communs**
> \`${prefix}closedms\` ➜ **Ferme les DM's**
> \`${prefix}clear [number]\` ➜ **Supprimer un nombre de message demandé**
> \`${prefix}roleall <ID/Role>\` ➜ **Distribue un rôle à tous les membres d'un serveur**
> \`${prefix}removeroleall <ID/Role>\` ➜ **Retire le rôle à tous les membres d'un serveur**
> \`${prefix}logout\` ➜ **Se deconnecter du bot**
> \`${prefix}savechat [channel] [number]\` ➜ **Sauvegarder un nombre de messages demandé d'un salon en question sous format txt`;

    const menuEn = `
♡ **${botName} - Utility Menu**

\`${prefix}avatar <@user>\` ➜ **Allows you to see someone's avatar**
> \`${prefix}userinfo <@user>\` ➜ **User information**
> \`${prefix}banner <@user>\` ➜ **Show someone's banner**
> \`${prefix}serverinfo <serverid>\` ➜ **Server Information**
> \`${prefix}ping\` ➜ **Test the latency**
> \`${prefix}restart\` ➜ **Restart the bot**
> \`${prefix}notifs <on/off>\` ➜ **Enable or disable notifications**
> \`${prefix}setavatar\` ➜ **Change avatar (send an image)**
> \`${prefix}edituser list\` ➜ **Change user information, such as username, tag etc...**
> \`${prefix}backup list\` ➜ **Server backups**
> \`${prefix}createwebhook\` ➜ **Create a webhook in the channel**
> \`${prefix}dmfriends <message>\` ➜ **Send a message to all your friends**
> \`${prefix}joinvc <channelid>\` ➜ **Join a vocal channel**
> \`${prefix}rainbowrole <@role> [-stop]\` ➜ **Multi-color role**
> \`${prefix}leaveserver/leaveguild <server id>\` ➜ **Leave a server**
> \`${prefix}antigroup <on/off>\` ➜ **Allows you to activate or deactivate the anti-group**
> \`${prefix}create [emoji]\` ➜ **Create an emoji**
> \`${prefix}find [ID]\` ➜ **Find a user in the common voice channels**
> \`${prefix}closedms\` ➜ **Close the DM's**
> \`${prefix}clear [number]\` ➜ **Delete a requested number of messages**
> \`${prefix}savechat [channel] [number]\` ➜ **Save a number of requested messages from a given channel in txt format`;

    const response = await language(client, menuFr, menuEn);
    await message.edit(response);
  },
};
