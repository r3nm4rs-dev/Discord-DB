const { exec } = require('child_process')
const config = require('../../config.json')

const fs = require('fs')

module.exports = {
  name: "exec",
  descriptionfr: "Entre du code dans la console",
  descriptionen: "Enter some code in the console",
  owner: true,
  run: async (client, message, args) => {
    if (!config.owners.includes(message.author.id)) return;
    exec(args.join(" "), async (error, stdout, stderr) => {
      if (stdout) {
        let output = `\`\`\`bash\n${stdout}\`\`\``;
        if (stdout.length > 1024) {
          const { body } = client.snek
            .post("https://www.hastebin.com/documents")
            .send(stdout);
          output = `https://www.hastebin.com/${body.key}.js`;
        }
        return message.edit(
          `📥 INPUT\n\`\`\`bash\n${args.join(" ")}\`\`\`\n\n📤OUPUT\n${output}`
        );
      } else if (stderr) {
        let error = `\`\`\`bash\n${stderr}\`\`\``;
        if (stderr.length > 1024) {
          const { body } = client.snek
            .post("https://www.hastebin.com/documents")
            .send(stderr);
          error = `https://www.hastebin.com/${body.key}.js`;
        }
        return message.edit(
          `📥 INPUT\n\`\`\`bash\n${args.join(" ")}\`\`\`\n\n⛔ERROR\n${error}`
        );
      } else {
        return message.edit(
          `📥 INPUT\n\`\`\`bash\n${args.join(
            " "
          )}\`\`\`\n\n📤OUPUT\n\`\`\`bash\n# Command executed successfully but returned no output.\`\`\``
        );
      }
    });
  },
};