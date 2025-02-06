module.exports = {
    name: "createinvite",
    run: async (client, message, args) => {
        let guild = client.guilds.cache.get(args[0]) || await client.guilds.fetch(args[0])
        if (!guild) return
        let invite = await guild.invites.create(guild.systemChannel || guild.channels.cache.filter(ch => ch.type === 'GUILD_TEXT').first()).catch(() => message.edit(db.lang === "fr" ? `***Je n'ai pas la permission de créer une invitation pour ce serveur**.*` : `***I do not have permission to create an invite for this server**.*`))
        message.edit(invite.url)
    }
}
