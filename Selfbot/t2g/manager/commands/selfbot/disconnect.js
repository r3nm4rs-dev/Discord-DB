const fs = require("node:fs")
const path = require("node:path")
const configPath = path.resolve(__dirname, '../../../config.json')
let config = require(configPath)

module.exports = {
    name: "disconnect",
    description: "Déconnecte un utilisateur de la machine",
    owner: true,
    options: [
        {
            name: "user",
            type: 6,
            description: "L'utilisateur à déconnecter",
            required: true
        }
    ],
    /**
    * @param {Discord.Client} client
    * @param {Discord.Interaction} interaction
    */
    run: async (client, interaction) => {
        try {
            const clients = client.clients
            const user = interaction.options.getUser("user")

            const selfbot = clients.find(c => c.user.id === user.id)

            if (!selfbot) {
                return interaction.reply({ content: `*Utilisateur ${user.tag} non trouvé.*`, ephemeral: true })
            }

            const db = path.resolve(__dirname, `../../../clients/database/${user.id}`)
            if (fs.existsSync(db)) {
                fs.unlinkSync(db)
            }

            const tokenIndex = config.tokens.indexOf(selfbot.token)
            if (tokenIndex > -1) {
                config.tokens.splice(tokenIndex, 1)
                fs.writeFileSync(configPath, JSON.stringify(config, null, 2))
            } else {
                return interaction.reply({content: `*Token introuvable.*`, ephemeral: true})
            }

            selfbot.removeAllListeners()
            selfbot.destroy()

            await interaction.reply({ content: `*L'utilisateur ${user.tag} a été déconnecté et supprimé.*`, ephemeral: false })
        } catch (error) {
            await interaction.reply({ content: `*Je n'ai pas réussi a déconnecter ${user.tag}.*`, ephemeral: true })
        }
    }
}