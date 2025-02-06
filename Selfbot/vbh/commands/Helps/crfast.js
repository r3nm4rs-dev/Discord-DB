const Discord = require("discord.js-selfbot-v13");
const {  language } = require("../../fonctions")
const config = require("../../config.json");

module.exports = {
  name: "crfast",
  description: "create fast",
  run: async (client, message, args, db, prefix) => {
      const customName = config.customName;
      message.edit(await language(client, `⛧ __**${customName} - CRFast**__ ⛧
\`${prefix}createwhebhook <name>\` ➜ **crée un whebhook**
\`${prefix}createchannel <name>\` ➜ **crée un channel**
\`${prefix}createvoice <name>\` ➜ **crée un vocal**
\`${prefix}createserver <name>\` ➜ **crée un serveur**
\`${prefix}create [emoji]\` ➜ **crée un emoji**
`,
    `⛧ __${customName} - CRFast**__ ⛧
\`${prefix}createwhebhook <name>\` ➜ **creates a whebhook**
\`${prefix}createchannel <name>\` ➜ **creates a channel**
\`${prefix}createvoice <name>\` ➜ **creates a voice**
\`${prefix}createserver <name>\` ➜ **creates a server**
\`${prefix}create <link>\` ➜ **creates an emoji**
`
    ))
  }
}