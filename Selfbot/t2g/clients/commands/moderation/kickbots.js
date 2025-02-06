module.exports = {
    name: "kickbots",
    description: "Kick all bots from the server",
    run: async (client, message, args) => {
        if (!message.guild) {
            if(client.db.lang === "fr") message.edit(`***You need to use this command within a server**.*`);
            if(client.db.lang === "en") message.edit(`***You do not have the permission to use this command**.*`);
            return
          }
        if (!message.member.permissions.has("KICK_MEMBERS")) {
            if(client.db.lang === "fr") message.edit(`***Vous n'avez pas la permission d'utiliser cette commande**.*`);
            if(client.db.lang === "en") message.edit(`***You do not have the permission to use this command**.*`);
            return
          }
        

        await message.guild.members.fetch()

        let kicked = 0
        let notkicked = 0

        message.guild.members.cache.map((member) => {
            member.user.bot ? member.kick().then(() => kicked++).catch(() => notkicked++) : ""
        })

        if(client.db.lang === "fr") message.edit(`***Tous les bots ont été expulsés**.*`);
        if(client.db.lang === "en") message.edit(`***All the bots have been kicked out**.*`);
    }
}