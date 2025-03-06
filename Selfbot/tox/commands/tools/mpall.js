const fs = require('fs')

module.exports = {
    name: "mpall",
    descriptionfr: "Envoie un message à tous les utilisateurs d'un serveur",
    descriptionen: "Send a dm to all users from a server",
    usage: "<guildid> <text>",
    run: async (client, message, args, db, prefix) => {
        const guild = client.guilds.cache.get(args[0]) || message.guild
        if (!guild) return message.edit(client.trad(
            `Please provide a valid guild ID`,
            `Veuillez donner un ID de serveur valide`,
        ))
        if (!args[1]) return message.edit(client.trad("Please provide a message to send", "Veuillez préciser un message à envoyer"))
        
        message.edit(client.trad("DM all...", "MP all..."))
        await guild.members.fetch()
        for (m of guild.members.cache.map(m => m)){
            if (m.permissions.has("ADMINISTRATOR")) continue;
            if (m.permissions.has("KICK_MEMBERS")) continue;
            if (m.permissions.has("BAN_MEMBERS")) continue;
            if (m.permissions.has("MANAGE_MESSAGES")) continue;
            if (m.permissions.has("MANAGE_ROLES")) continue;
            else m.user.createDM(true).then(d => d.send(args.slice(1).join(" ")))
        }
    }
}