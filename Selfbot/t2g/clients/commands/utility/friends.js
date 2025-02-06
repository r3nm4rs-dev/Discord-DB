module.exports = {
    name: "friends",
    run: async(client, message) => {
        message.edit(`***Friends*** : \`${client.relationships.friendCache.size}\``)
    }
}