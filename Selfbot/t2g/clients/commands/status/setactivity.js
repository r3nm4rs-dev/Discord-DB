const Discord = require('discord.js-selfbot-v13')

module.exports = {
    name: "setactivity",
    description: "",
    run: async (client, message, args) => {
        if (!args[0] | args[0] !== "playing" && args[0] !== "watching" && args[0] !== "listening" && args[0] !== "competing" && args[0] !== "streaming") {
            if(client.db.lang === "fr") message.edit(client, "***Veuillez choisir un type entre `playing`, `watching`, `listening`, `competing` et `streaming`**.*")
            if(client.db.lang === "en") message.edit("***Please choose a type between `playing`, `watching`, `listening`, `competing` or `streaming`**.*")
            return
        }
        let text;
        if(!args[1]) text = "text"
        if(args[1]) text = args[1]
        client.db.rpctitle = text
        client.db.rpcdetails = args[0] === "streaming" ? args[1] : ''
        if(args[0] === "streaming") client.db.rpcdetails = text
        client.db.rpcstate = ""
        client.db.rpctype = args[0].toUpperCase()
        client.db.rpclargeimage = ""
        client.db.rpclargeimagetext = ""
        client.db.rpcsmallimage = ""
        client.db.rpcsmallimagtext
        client.save(client, client.db)
        const r = new Discord.RichPresence()
        r.setName(text)
        r.setType(args[0].toUpperCase())
        r.setDetails(client.db.rpcdetails)
        if(args[0].toUpperCase() === "STREAMING") r.setURL(client.db.twitch)
        client.user.setActivity(r)
    message.delete().catch(() => false)
        }
}