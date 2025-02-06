module.exports = {
    name: "serverinfo",
    run: async (client, message, args) => {
        try {
            let guild = client.guilds.cache.get(args[0]) || await client.guilds.fetch(args[0]);

            if (!guild) {
                return message.edit("**Error:** Guild not found.")
            }

            const serverBanner = guild.bannerURL({ size: 2048, format: "webp" }) 
                ? `[Server Banner](${guild.bannerURL({ size: 2048, format: "webp" })})` 
                : "";
            const serverAvatar = guild.iconURL({ dynamic: true, size: 2048 }) 
                ? `[Server Icon](${guild.iconURL({ dynamic: true, size: 2048 })})` 
                : "";
            const serverSplash = guild.splashURL({ format: "webp", size: 2048 }) 
                ? `[Server Splash](${guild.splashURL({ format: "webp", size: 2048 })})` 
                : "";

            const createdAt = Math.round(guild.createdTimestamp / 1000);
            const joinedAt = guild.members.me ? Math.floor(guild.members.me.joinedTimestamp / 1000) : "N/A";
            const daysSinceCreation = Math.floor((Date.now() - guild.createdTimestamp) / (1000 * 60 * 60 * 24));

            const infoMessage = `» __**Server Info**__\n\n` +
                `> ***Name***: \`${guild.name}\`\n` +
                `> ***ID***: \`${guild.id}\`\n` +
                `> ***Owner***: <@${guild.ownerId}>\n` +
                `> ***Owner ID***: \`${guild.ownerId}\`\n` +
                `> ***Channels***: \`${guild.channels.cache.size}\`\n` +
                `> ***Roles***: \`${guild.roles.cache.size}\`\n` +
                `> ***Members***: \`${guild.members.cache.size}\`\n` +
                `> ***Creation Date***: <t:${createdAt}:D> (<t:${createdAt}:R>)\n` +
                `> ***Days Since Creation***: \`${daysSinceCreation}\`\n` +
                `> ***Joined At***: ${joinedAt === "N/A" ? "N/A" : `<t:${joinedAt}:D> (<t:${joinedAt}:R>)`}\n` +
                `> ***Server Banner***: ${serverBanner}\n` +
                `> ***Server Icon***: ${serverAvatar}\n` +
                `> ***Server Invite Splash***: ${serverSplash}`;

             message.edit(infoMessage);
        } catch (e) {
        }
    }
};