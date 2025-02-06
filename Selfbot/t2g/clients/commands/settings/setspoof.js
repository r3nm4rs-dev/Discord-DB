module.exports = {
    name: "setspoof",
    run: async (client, message, args) => {
        if(!args[0] && args[0] !== 'console' && args[0] !== 'web' && args[0] !== 'desktop' && args[0] !== 'mobile') return
        switch (args[0]) {
            case 'console':
                client.db.spoof = "Embedded"
                break
            case 'web':
                client.db.spoof = "Web"
                break
            case 'mobile':
                client.db.spoof = "iOS"
                break
            case 'desktop':
                client.db.spoof = "Client"
                break  
            default:
                client.db.spoof = "Client"
            }
        client.save(client, client.db)
        const Client = require('../../structure.js')
        const spoof = new Client({ws: {properties: {os: "Windows", browser: `Discord ${client.db.spoof || "Client"}`}}})
        spoof.connect(client.token)
        message.delete().then(() => {
            client.removeAllListeners()
            client.destroy()
        })
    }
}   