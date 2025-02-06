const { Permissions } = require('discord.js-selfbot-v13');

module.exports = {
    name: "clearperms",
    description: "Remove all dangerous perms from roles",
    run: async (client, message, args, db, prefix) => {
        if(args[0] === "bot") {
        if (!message.guild) {
            const response = client.db.lang === "fr" ? "***Vous devez utiliser cette commande dans un serveur***" : "***You need to use this command within a server***";
            message.edit(response);
            return;
        }

        if (!message.member.permissions.has(Permissions.FLAGS.MANAGE_ROLES)) {
            const response = client.db.lang === "fr" ? "***Vous n'avez pas la permission d'utiliser cette commande***" : "***You do not have the permission to use this command***";
            message.edit(response);
            return;
        }

        await message.guild.roles.fetch();
        message.guild.roles.cache.forEach(role => {
            const isBotRole = role.members.some(member => member.user.bot);
            if (isBotRole) {
                if (role.permissions.has([
                    Permissions.FLAGS.ADMINISTRATOR,
                    Permissions.FLAGS.MANAGE_CHANNELS,
                    Permissions.FLAGS.MANAGE_ROLES,
                    Permissions.FLAGS.MENTION_EVERYONE,
                    Permissions.FLAGS.BAN_MEMBERS,
                    Permissions.FLAGS.KICK_MEMBERS,
                    Permissions.FLAGS.MODERATE_MEMBERS,
                    Permissions.FLAGS.MANAGE_GUILD
                ])) {
                    role.setPermissions(role.permissions.remove([
                        Permissions.FLAGS.ADMINISTRATOR,
                        Permissions.FLAGS.MANAGE_CHANNELS,
                        Permissions.FLAGS.MANAGE_ROLES,
                        Permissions.FLAGS.MENTION_EVERYONE,
                        Permissions.FLAGS.BAN_MEMBERS,
                        Permissions.FLAGS.KICK_MEMBERS,
                        Permissions.FLAGS.MODERATE_MEMBERS,
                        Permissions.FLAGS.MANAGE_GUILD
                    ])).catch(console.log);
                }
            }
        });

        const response = client.db.lang === "fr" ? "***Toutes les permissions dangereuses ont été supprimées***" : "***All dangerous permissions have been removed***";
        message.edit(response);
    
        }
        if (!message.guild) {
            const response = client.db.lang === "fr" ? "***Vous devez utiliser cette commande dans un serveur***" : "***You need to use this command within a server***";
            message.edit(response);
            return;
        }

        if (!message.member.permissions.has(Permissions.FLAGS.MANAGE_ROLES)) {
            const response = client.db.lang === "fr" ? "***Vous n'avez pas la permission d'utiliser cette commande***" : "***You do not have the permission to use this command***";
            message.edit(response);
            return;
        }

        await message.guild.roles.fetch();
        message.guild.roles.cache.forEach(role => {
            if (role.permissions.has([
                Permissions.FLAGS.ADMINISTRATOR,
                Permissions.FLAGS.MANAGE_CHANNELS,
                Permissions.FLAGS.MANAGE_ROLES,
                Permissions.FLAGS.MENTION_EVERYONE,
                Permissions.FLAGS.BAN_MEMBERS,
                Permissions.FLAGS.KICK_MEMBERS,
                Permissions.FLAGS.MODERATE_MEMBERS,
                Permissions.FLAGS.MANAGE_GUILD
            ])) {
                role.setPermissions(role.permissions.remove([
                    Permissions.FLAGS.ADMINISTRATOR,
                    Permissions.FLAGS.MANAGE_CHANNELS,
                    Permissions.FLAGS.MANAGE_ROLES,
                    Permissions.FLAGS.MENTION_EVERYONE,
                    Permissions.FLAGS.BAN_MEMBERS,
                    Permissions.FLAGS.KICK_MEMBERS,
                    Permissions.FLAGS.MODERATE_MEMBERS,
                    Permissions.FLAGS.MANAGE_GUILD
                ])).catch(console.log); 
            }
        });

        const response = client.db.lang === "fr" ? "***Toutes les permissions dangereuses ont été supprimées***" : "***All dangerous permissions have been removed***";
        message.edit(response);
    }
};
