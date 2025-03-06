const Discord = require('discord.js');
const Pluzio = require('../../structures/client/index.js');

module.exports = {
    name: 'interactionCreate',
    /**
     * 
     * @param {Pluzio} client 
     * @param {Discord.Integration} interaction 
     * @returns 
     */
    run: async (client, interaction) => {
        if (interaction.type === Discord.InteractionType.ApplicationCommand) {
            const SlashCommands = client.slashCommands.get(interaction.commandName);
            if (!SlashCommands) return;
            try {
                await SlashCommands.run(client, interaction);

            } catch (error) {
                console.log(error);
            }
        }
    }
}