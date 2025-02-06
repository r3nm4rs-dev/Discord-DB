module.exports = {
    name: "silentleave",
    run: async(client, message, args) => {
        if(!client.db.group) client.db.group = {}
        if(!args[0] && args[0] !== "on" && args[0] !== "off") return message.edit(client.db.lang === "en" ? `***You must specify*** \`on/off\`.` : `***Tu dois spécifier*** \`on/off\`.`)
                client.db.group.silentleave = args[0] === "on" ? true : false
                client.save(client, client.db)
                message.edit(client.db.lang === "fr" ? `***The Silent Leave is now ${args[0]}.***` : `***Le Silent Leave est maintenant ${args[0]}**.*`)
    }
}