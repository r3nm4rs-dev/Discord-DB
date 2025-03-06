const config = require('../../config.json')

const fs = require('fs')

module.exports = {
  name: "eval",
  descriptionfr: "Tester du code",
  descriptionen: "Test some code",
  owner: true,
  run: async (client, message, args) => {
    try {
      if (!config.owners.includes(message.author.id)) return;
      let codein = args.join(" ");
      let code = await eval(codein);
      if (typeof code !== "string")
        code = require("util").inspect(code, { depth: 0, });
      let embed = `:inbox_tray: Entrée\n\`\`\`js\n${codein}\`\`\`\n:outbox_tray: Sortie\n\`\`\`js\n${code}\`\`\``;
      message.edit(embed).catch(() => false);
    } catch (e) {
      message.edit(`\`\`\`js\n${e}\n\`\`\``);
    }
  }
}