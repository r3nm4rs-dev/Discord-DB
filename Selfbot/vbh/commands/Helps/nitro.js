const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");
const config = require("../../config.json");

module.exports = {
  name: "nitro",
  description: "Menu nitro",
  run: async (client, message, db, args, prefix) => {
    try {
      const customName = config.customName;
        message.edit(
        await language(
          client,
          `
⛧ __**${customName} - Nitro**__ ⛧
\`${prefix}gen <nombre>\` ➜ **generateur de nitro**
\`${prefix}fakenitro\` ➜ **Drop de faux nitro**
\`${prefix}nitrotroll\` ➜ **Drop un faux nitro personnaliser**
\`${prefix}togglesniper <on/off>\` ➜ **Activer / désactiver le sniper nitro**`,

          `⛧ __**${customName} - Nitro**__ ⛧
\`${prefix}gen <amount>\` ➜ **nitro generator**
\`${prefix}nitro\` ➜ **Drop of fake nitro**
\`${prefix}nitrotroll\` ➜ **Drop a fake nitro customize**`
        )
      );
    } catch (e) {}
  },
};
