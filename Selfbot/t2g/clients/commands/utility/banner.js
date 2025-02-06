module.exports = {
    name: "banner",
    run: async(client, message, args) => {
        let user;
        if (!args[0]) user = message.author
        if (args[0]) user = message.mentions.users.first() || await client.users.cache.get(args[0])
        if (!user) user = message.author
        await user.fetch()
        if(!user.banner) return message.edit(client.db.language === "fr" ? `***L'utilisateur n'a pas de bannière***` : `***The user doesn't have a banner***`)
            const extension = user.avatar.startsWith("a_") ? "gif" : "png"
        const link = `https://cdn.discordapp.com/banners/${user.id}/${user.banner}.${extension}?size=2048&ignore=true` 
            let msg = client.db.lang === "fr" ? `***Voici la bannière de [${user.tag}](${link})***` : `***Here's the banner of [${user.tag}](${link})***`
        message.edit(msg)
    }
}