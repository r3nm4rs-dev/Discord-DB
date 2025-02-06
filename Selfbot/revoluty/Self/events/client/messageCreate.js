module.exports = {
    name: "messageCreate",
    once: false,
    run: async (client, message) => {
        if (message.author.bot) return;
        let prefix = await client.db.get(`prefix_${client.user.id}`) || client.config.prefix
        client.prefix = prefix
        let lang = await client.db.get(`lang_${client.user.id}`) || "fr";
        let langdb = await client.lang.get(lang);
        if (!message.content.startsWith(prefix)) return;
        const escapeRegex = (str) => {
            if (typeof str !== 'string') {
                console.error(`Expected a string but got ${typeof str}:`, str);
                return '';
            }
            return str.replace(/[.*+?^${}()|[\]\\]/g, "\\$&");
        };

        const prefixRegex = new RegExp(`^(<@!?${client.user.id}>|${escapeRegex(prefix)})\\s*`);
        if (!prefixRegex.test(message.content)) return;

        const [, matchedPrefix] = message.content.match(prefixRegex);
        const args = message.content.slice(matchedPrefix.length).trim().split(/ +/g);
        const commandName = args.shift()?.toLowerCase().normalize();
        if (!commandName) return;
        const cmd = client.commands.get(commandName) || client.aliases.get(commandName);
        if (!cmd) return;

        // si la commande est premium et que l user n a pas le premium en true dans son fichier config return 
        if (cmd.premium && client.config.premium !== true) {
            return;
        }
        cmd.run(client, message, args);

    }
}