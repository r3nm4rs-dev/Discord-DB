const fs = require('fs');
const path = require("node:path");

module.exports = {
  name: "messageCreate",
  once: false,
  run: async (message, client) => {
    if (!client.db) return;
    if (message.author.id !== client.user.id) return
    client.trad = (en, fr) => client.db.language === "en" ? en : fr
        
    if (!fs.existsSync(`./backups`)) await fs.promises.mkdir('./backups')
    if (!fs.existsSync(`./backups/${client.user.id}`)) await fs.promises.mkdir(`./backups/${client.user.id}`)

    let prefix = client.db.prefix
    if (!prefix) prefix = "&"
    if (!message.content.startsWith(prefix)) return;

    const args = message.content.slice(prefix.length).trim().split(/ +/g);
    const command = args.shift().toLowerCase();
    const commandFile = client.commands.get(command)

    if (commandFile && commandFile.premium && !client.premium) return;
    if (commandFile && commandFile.premium && client.premium) commandFile.run(client, message, args)
    else if (commandFile) commandFile.run(client, message, args)
    if (commandFile) client.db.deletetimer !== 0 ? setTimeout(() => message ? message.delete().catch(() => false) : "", client.db.deletetimer) : ""
  }
}