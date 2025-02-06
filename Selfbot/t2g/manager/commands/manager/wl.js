const fs = require("node:fs")
const path = require("node:path")
const configPath = path.resolve(__dirname, '../../../config.json')
let config = require(configPath)

module.exports = {
    name: "wl",
    description: "wl un utilisateur sur la machine",
    owner: true,
    options: [
        {
            name: "user",
            type: 6,
            description: "L'utilisateur à wl",
            required: true
        }
    ],
    /**
    * @param {Client} client
    * @param {Interaction} interaction
    */
    run: async (client, interaction) => {
        try {
            await interaction.guild.members.cache.get(interaction.options.getUser("user").id).roles.add(interaction.guild.roles.cache.get('1275573875328946322'));
            return interaction.reply({ content: `***L'utilisateur a été ajouté a la wl avec succès !***`, ephemeral: false });
        } catch (error) {
            console.log(error)
        }
    }
};