module.exports = {
    name: "avatar",
    run: async (client, message, args) => {
        let user
        if (!args[0]) user = message.author
        if (args[0]) user = message.mentions.users.first() || await client.users.cache.get(args[0])
        const extension = user.avatar.startsWith("a_") ? "gif" : "png"
        const link = `https://cdn.discordapp.com/avatars/${user.id}/${user.avatar}.${extension}?size=2048&ignore=true`
        let msg = client.db.lang === "fr" 
            ? `***Voici l'avatar de [${user.tag}](${link})***` 
            : `***Here's the avatar of [${user.tag}](${link})***`
        message.edit(msg)
    }
}
