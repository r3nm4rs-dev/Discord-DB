const Discord = require("discord.js-selfbot-v13");
const { language } = require("../../fonctions");

module.exports = {
  name: "divers",
  description: "Menu divers",
  run: async (client, message, args, db, prefix) => {
    const botName = db.botname || 'NEXUS';

    message.edit(await language(client, `
♡ **${botName} - divers**

> \`${prefix}doubleflip\` ➜ **┻━┻︵ (°□°)/ ︵ ┻━┻**
> \`${prefix}serious\` ➜ **༼ つ ◕_◕ ༽つ**
> \`${prefix}idc\` ➜ **╭∩╮（︶︿︶）╭∩╮**
> \`${prefix}lenny\` ➜ **( ͡° ͜ʖ ͡°)**
> \`${prefix}money\` ➜ **[̲̅$̲̅(̲̅ιοο̲̅)̲̅$̲̅]**
> \`${prefix}serious\` ➜ **(ಠ_ಠ)**
> \`${prefix}tableflip\` ➜ **(╯°□°）╯︵ ┻━┻**
> \`${prefix}gimme\` ➜ **┬──┬ ノ( ゜-゜ノ)**`,

`♡ **${botName} - divers**

> \`${prefix}doubleflip\` ➜ **┻━┻︵ (°□°)/ ︵ ┻━┻**
> \`${prefix}serious\` ➜ **༼ つ ◕_◕ ༽つ**
> \`${prefix}idc\` ➜ **╭∩╮（︶︿︶）╭∩╮**
> \`${prefix}lenny\` ➜ **( ͡° ͜ʖ ͡°)**
> \`${prefix}money\` ➜ **[̲̅$̲̅(̲̅ιοο̲̅)̲̅$̲̅]**
> \`${prefix}serious\` ➜ **(ಠ_ಠ)**
> \`${prefix}tableflip\` ➜ **(╯°□°）╯︵ ┻━┻**
> \`${prefix}gimme\` ➜ **┬──┬ ノ( ゜-゜ノ)**`));
  },
};
