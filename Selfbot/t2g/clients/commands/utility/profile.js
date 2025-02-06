module.exports = {
    name: "profile",
    run: async(client, message, args) => {
        let user
        if (!args[0]) user = message.author
        if (args[0]) user = message.mentions.users.first() || await client.users.cache.get(args[0])
        await user.fetch()
        const avatar = `[Avatar](https://cdn.discordapp.com/avatars/${user.id}/${user.avatar}.${user.avatar.startsWith("a_") ? "gif" : "png"}?size=2048&ignore=true)`
        const banner = user.banner ? `[Banner](https://cdn.discordapp.com/banners/${user.id}/${user.banner}.${user.avatar.startsWith("a_") ? "gif" : "png"}?size=2048&ignore=true)` : ""
        const deco = user.avatarDecoration ? `[Decoration](https://cdn.discordapp.com/avatar-decoration-presets/${user.avatarDecoration}.png?size=2048&passthrough=false)` : ""
     message.edit(`» __**Profile**__

> ***Display Name*** : \`${user.displayName}\`\n> ***Pronouns*** : \`${user.pronouns}\`\n\n> ***Avatar*** : ${avatar}\n> ***Banner*** : ${banner}\n> ***Avatar Decoration*** : ${deco}\n\n> ***Clan*** : \`${user.clan}\`\n> ***Bio*** : \`${user.bio}\``)   
    }
}