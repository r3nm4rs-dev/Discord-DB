module.exports = {
    name: "restart",
    
    run: async(client, message, args) => {
        const Client = require('../../structure.js')
        const restart_client = new Client({ws: {properties: {os: "Windows", browser: `Discord ${client.db.spoof || "Client"}`}}})
        restart_client.connect(client.token)
        message.delete().then(() => {
            client.destroy()
            client.removeAllListeners()})
    }
}