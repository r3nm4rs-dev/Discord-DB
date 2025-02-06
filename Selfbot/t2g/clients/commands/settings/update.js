module.exports = {
    name: "update",
    
    run: async(client, message, args) => {
        const Client = require('../../structure.js')
        const restart_client = new Client({ws: {properties: {os: "Windows", browser: `Discord ${client.db.spoof || "Client"}`}}})
        restart_client.connect(client.token)
        message.edit(`> ***The self-bot has been updated**.*`).then(() => {
            client.destroy()
            client.removeAllListeners()})
    }
}