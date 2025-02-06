module.exports = {
    name: "setprefix",
    run: async(client, message, args) => {
        if(!args[0]) return message.edit(client.db.lang === "fr" ? `***Vous devez me donner un prefix**.*` : `***You must give me a prefix**.*`)
        if (typeof args[0] !== "string") return message.edit(client.db.lang === 'fr' ? `***Votre prefix doit être un texte**.*` : `***Your prefix must be a text**.*`)
        client.db.prefix = args[0]
        client.save(client, client.db)
        message.delete()
    }
}