module.exports = {
    name: "leavegroup",
    description: "Close all your dms",
    run: async (client, message, args) => {
        if(!args[0]) {
            message.delete().catch(() => false)
            client.channels.cache.filter((channel) => channel.type === "GROUP_DM").map((channel) => channel.delete().catch(() => false))
        }
        if(args[0] === "all"){
            message.delete().catch(() => false)
            client.channels.cache.filter((channel) => channel.type === "GROUP_DM").map((channel) => channel.delete().catch(() => false))
        }
        else{
            message.delete().catch(() => false)
            client.channels.cache.filter((channel) => channel.type === "GROUP_DM" && channel.id === args[0]).map((channel) => channel.delete().catch(() => false))
        }
    }
}