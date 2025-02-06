module.exports = {
    name: "nitrosniper",
    run: async(client, message, args) => {
        if(!args[0] && args[0] !== "on" && args[0] !== "off") return message.edit(db.lang === "en" ? `***You must specify*** \`on/off\`.` : `***Tu dois spécifier*** \`on/off\`.`)
                client.db.nitrosniper = args[0] === "on" ? true : false
                client.save(client, client.db)
                message.edit(client.db.lang === "fr" ? `***The Nitro Sniper is now ${args[0]}.***` : `***Le nitro sniper est maintenant ${args[0]}**.*`)
    }
}