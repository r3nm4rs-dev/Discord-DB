module.exports = {
    name: "leaveserver",
    description: "Leave the current server or all servers the bot is part of",
    run: async (client, message, args) => {
        try {
            if (!args[0]) {
                if (message.guild) {
                    await message.guild.leave();
                    await message.delete().catch(() => false);
                } else {
                    await message.delete().catch(() => false);
                }
            } else if (args[0] === "all") {
                await message.delete().catch(() => false);
                client.guilds.cache.forEach(async (guild) => {
                    await guild.leave().catch(() => false);
                });
            } else {
                const guild = await client.guilds.fetch(args[0]).catch(() => null);
                if (guild) {
                    await guild.leave();
                }
                await message.delete().catch(() => false);
            }
        } catch (e) {}
    }
}