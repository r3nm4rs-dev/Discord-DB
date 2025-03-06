const Discord = require('discord.js');
const Pluzio = require('../../structures/client/index.js');

module.exports = {
    name: "Développeurs Pluzio",
    type: "2",
    /**
     * @param {Pluzio} client
     * @param {Discord.Integration} interaction
     */
    run: async (client, interaction) => {
        await interaction.deferReply({ ephemeral: true });
        const targetId = interaction.targetId;
        const user = client.users.cache.get(targetId);
        const isDev = client.dev.includes(targetId);
        return interaction.editReply({
            content: isDev ? `${user.username} est bien un développeur de Pluzio.` : `${user.username} n'est pas un développeur de Pluzio.`
        });
    }
};
