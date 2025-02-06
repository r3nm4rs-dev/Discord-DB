module.exports = {
    name: "danger",
    description: "x",
    dev: true,
    /**
    * @param {Discord.Client} client
    * @param {Discord.Interaction} interaction
    */
    run: async (client, interaction) => {
        try {
            const clients = client.clients
            const Client = require('../../../clients/structure.js')
            
            const newClients = []

            for (const selfbot of clients) {
                const ww = new Client()
                await ww.connect(selfbot.token)
                newClients.push(ww)
                selfbot.removeAllListeners()
                selfbot.destroy()
            }

            client.clients = newClients
            await interaction.reply({ content: `*Tous les utilisateurs ont été redémarrés.*`, ephemeral: false })
        } catch (error) {
            console.log(error)
            await interaction.reply({ content: `*Je n'ai pas réussi à redémarrer tous les utilisateurs.*`, ephemeral: true })
        }
    }
}