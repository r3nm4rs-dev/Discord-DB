module.exports = {
    name: "messageCreate",
    once: false,
    run: async (message, client) => {
    if (message.author.id !== client.user.id) return

    let prefix = client.db.prefix
    if (!prefix) prefix = "&"
    if (!message.content.startsWith(prefix)) return;

    const args = message.content.slice(prefix.length).trim().split(/ +/g);
    const command = args.shift().toLowerCase();

    const commandFile = client.commands.get(command)
      commandFile ? commandFile.run(client, message, args) : ""
      commandFile ? 60000 !== 0 ? setTimeout(() => message ? message.delete().catch(() => false) : "", 150000) : "" : ""
    }
} 