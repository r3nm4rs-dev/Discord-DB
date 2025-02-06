const { language } = require("../../fonctions");
const fs = require('fs');

module.exports = {
    name: "serverinfo",
    description: "Display the info of a server",
    run: async (client, message, args) => {
        try {
            // Vérification si le message provient d'un serveur
            if (!message.guild) {
                return message.channel.send("Cette commande ne peut être utilisée que dans un serveur.");
            }

            const guild = message.guild; // Utiliser directement le serveur du message

            // Vérification que le bot a accès aux membres de la guilde
            await guild.members.fetch(); // Récupérer tous les membres de la guilde

            const dbFilePath = `./db/${message.author.id}.json`;
            const db = JSON.parse(fs.readFileSync(dbFilePath));
            const botName = db.botname || "Bot"; // Fallback to "Bot" if botname is not defined

            message.edit(await language(client, `**♡ ${botName} - Serveur Infos ♡**

> Nom: ${guild.name}
> ID: ${guild.id}
> Propriétaire: <@${guild.ownerId}>
> ID du propriétaire: ${guild.ownerId}
> Salons: ${guild.channels.cache.size}
> Rôles: ${guild.roles.cache.size} 
> Membres: ${guild.memberCount}
> Date de création: <t:${Math.round(guild.createdTimestamp / 1000)}> <t:${Math.round(guild.createdTimestamp / 1000)}:R> 
> Jours depuis la création: ${Math.round((Date.now() - guild.createdTimestamp) / (1000 * 60 * 60 * 24))}
> Sur le serveur depuis: <t:${Math.round(guild.members.me.joinedTimestamp)}> <t:${Math.round(guild.members.me.joinedTimestamp)}:R>
> Bannière du serveur: ${guild.banner ? guild.bannerURL({ size: 1024, format: "webp" }) : "Pas de bannière"}
> Photo du serveur: ${guild.icon ? guild.iconURL({ dynamic: true }) : "Pas d'icône"}
> Bannière d'invitation: ${guild.splash ? guild.splashURL({ format: "webp", size: 1024 }) : "Pas de bannière"}`,
                `**♡  ${botName} - Server Infos ♡**

> Name: ${guild.name}
> ID: ${guild.id}
> Founder: <@${guild.ownerId}>
> Founder ID: ${guild.ownerId}
> Channels: ${guild.channels.cache.size}
> Roles: ${guild.roles.cache.size} 
> Members: ${guild.memberCount}
> Creation date: <t:${Math.round(guild.createdTimestamp / 1000)}> <t:${Math.round(guild.createdTimestamp / 1000)}:R> 
> Date since the creation: ${Math.round((Date.now() - guild.createdTimestamp) / (1000 * 60 * 60 * 24))}
> In the server from: <t:${Math.round(guild.members.me.joinedTimestamp)}> <t:${Math.round(guild.members.me.joinedTimestamp)}:R>
> Server banner: ${guild.banner ? guild.bannerURL({ size: 1024, format: "webp" }) : "No banner"}
> Server icon: ${guild.icon ? guild.iconURL({ dynamic: true }) : "No icon"}
> Splash Banner: ${guild.splash ? guild.splashURL({ format: "webp", size: 1024 }) : "No Banner"}`));
        } catch (e) {
            console.error(e);
            message.channel.send("Une erreur s'est produite lors de l'exécution de la commande. Vérifiez la console pour plus d'informations.");
        }
    }
};
