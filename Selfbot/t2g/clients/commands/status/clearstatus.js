module.exports = {
    name: "clearstatus",
    description: "Clear the status",
    run: async (client, message) => {
        try{
            client.user.setActivity('', {
                type: "PLAYING"
            })
            client.save(client, client.db)
            message.delete()
}catch(e){
    console.log(e)
}
    }
}