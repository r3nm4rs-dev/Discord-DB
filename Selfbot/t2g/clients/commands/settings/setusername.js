module.exports = {
    name: "setusername",
    run: async(client, message, args) => {
        if(!args[0]) client.db.rpc.twitch = 'https://twitch.tv/b2discord'
        if(args[0].includes('https://twitch.tv/')) return client.db.rpc.twitch = args[0]
        if(args[0].includes('twitch.tv/')) return client.db.rpc.twitch = 'https://' + args[0]
        else client.db.rpc.twitch = "https://twitch.tv/" + args[0]
        message.delete()
    }
}