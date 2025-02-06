const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");
const config = require("../../config.json");

module.exports = {
  name: "fun",
  description: "Menu fun",
  run: async (client, message, db, args, prefix) => {
    try {
      const customName = config.customName;
        message.edit(
        await language(
          client,
          `
⛧ __**${customName} - Fun**__ ⛧
\`${prefix}add <@user> [message]\` ➜ **lien pour t'ajoutez en ami**
\`${prefix}say <@user> [message]\` ➜ **Dire une chose sous l'identité d'autrui (webhook)**
\`${prefix}thot <@user>\` ➜ **Note le pourçentage de saloperie d'autrui**
\`${prefix}love <@user>\` ➜ **Message animé**
\`${prefix}noadd [delete]\` ➜ **Empêche les gens d'ajouter des personnes au groupe**
\`${prefix}noleave [delete]\` ➜ **Ré-ajoute les gens qui quittent le groupe (vos amis seulement)**
\`${prefix}coinflip\` ➜ **Jouer Pile ou Face**`,

          `⛧ __**${customName} - Fun**__ ⛧
\`${prefix}add <@user> [message]\` ➜ **link to add yourself as friends**
\`${prefix}say <@user> [message]\` ➜ **Saying something under someone else's identity (webhook)**
\`${prefix}thot <@user>\` ➜ **Note the percentage of other people's filth**
\`${prefix}love <@user>\` ➜ **Animated message**
\`${prefix}noadd [delete]\` ➜ **Prevents people from adding people to the group**
\`${prefix}noleave [delete]\` ➜ **Re-add people who leave the group (your friends only)**
\`${prefix}coinflip\` ➜ **Play Heads or Tails**`
        )
      );
    } catch (e) {}
  },
};
