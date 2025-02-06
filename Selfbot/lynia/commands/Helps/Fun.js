const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");

module.exports = {
  name: "fun",
  description: "Menu fun",
  run: async (client, message, args, db, prefix) => {
    const botName = db.botname || 'NEXUS';

    const helpMessage = await language(client, `
♡ **${botName} - fun**

> \`${prefix}blague\` ➜ **Affiche une blague aléatoire**
> \`${prefix}say <@user>\` ➜ **Dire quelque chose sous l'identité de quelqu'un d'autre (webhook)**
> \`${prefix}thot <@user>\` ➜ **Notez le pourcentage de saloperie des autres**
> \`${prefix}money\` ➜ **Envoie un billet**
> \`${prefix}branlette\` ➜ **Branle quelqu'un**
> \`${prefix}coinflip <pile/face>\` ➜ **Jouer Pile ou Face**
> \`${prefix}broadcast [message]\` ➜ **Diffuser un message dans tous les salons**`,

    `
♡ **${botName} - fun**

> \`${prefix}blague\` ➜ **Display a random joke**
> \`${prefix}add <@user>\` ➜ **Link to add you as a friend**
> \`${prefix}karma\` ➜ **Karma a user**
> \`${prefix}say <@user>\` ➜ **Say something under someone else's identity (webhook)**
> \`${prefix}thot <@user>\` ➜ **Note the percentage of other people's sluttiness**
> \`${prefix}love <@user>\` ➜ **Animated message**
> \`${prefix}money\` ➜ **Send a bill**
> \`${prefix}branlette\` ➜ **Jerk off someone**
> \`${prefix}coinflip <pile/face>\` ➜ **Play Heads or Tails**
> \`${prefix}broadcast [message]\` ➜ **Broadcast a message to all rooms**
> \`${prefix}insulte\` ➜ **Generate a random insult**`);

    message.edit(helpMessage);
  }
};
