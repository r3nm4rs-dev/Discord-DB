module.exports = {
    name: "userinfo",
    run: async (client, message, args) => {
        let user
        if (!args[0]) user = message.author
        if (args[0]) user = message.mentions.users.first() || await client.users.fetch(args[0])
        message.edit(`» __**User info**__ 

> ***Tag*** : \`${user.tag}\`
> ***User ID*** : \`${user.id}\`
> ***Creation Date*** : <t:${Math.floor(user.createdTimestamp / 1000)}:D> (<t:${Math.round(user.createdTimestamp / 1000)}:R>)
> ***Days since creation*** : \`${Math.floor((Date.now() - user.createdTimestamp) / (1000 * 60 * 60 * 24))}\``)
    }
}
