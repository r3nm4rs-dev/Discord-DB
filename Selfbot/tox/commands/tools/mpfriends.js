
const fs = require('fs')

module.exports = {
    name: "mpfriends",
    descriptionfr: "Envoie un message à tous tes amis",
    descriptionen: "Send a dm to all your friends",
    usage: "<text>",
    run: async (client, message, args, db, prefix) => {
        if (!args[0]) return message.edit(client.trad("Please provide a message to send", "Veuillez préciser un message à envoyer"))
        
        await client.relationships.fetch()
        message.edit(client.trad(`DM all \`${client.relationships.friendCache.size}\` friends...`, `MP all \`${client.relationships.friendCache.size}\` amis...`))
        client.relationships.friendCache.forEach(f => f?.send(args.join(" ")))       
    }
}