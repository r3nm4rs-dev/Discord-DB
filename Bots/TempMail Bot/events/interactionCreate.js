const { Events } = require('discord.js');

module.exports = {
    name: Events.InteractionCreate,
    async execute(interaction) {
        try {
            if (interaction.isChatInputCommand()) {
                const command = interaction.client.commands.get(interaction.commandName);
                if (!command) {
                    console.error(`❌ Aucune commande correspondante ${interaction.commandName} n'a été trouvée.`);
                    return;
                }

                try {
                    await command.execute(interaction);
                } catch (error) {
                    console.error(`❌ Erreur lors de l'exécution de la commande ${interaction.commandName}:`, error);
                    const errorMessage = {
                        content: '❌ Une erreur est survenue lors de l\'exécution de cette commande.',
                        ephemeral: true
                    };

                    if (interaction.replied || interaction.deferred) {
                        await interaction.followUp(errorMessage);
                    } else {
                        await interaction.reply(errorMessage);
                    }
                }
            }
            
            else if (interaction.isButton()) {
                const button = interaction.client.buttons.get(interaction.customId);
                if (!button) {
                    console.error(`❌ Aucun gestionnaire pour le bouton ${interaction.customId} n'a été trouvé.`);
                    return;
                }

                try {
                    await button.execute(interaction);
                } catch (error) {
                    console.error(`❌ Erreur lors de l'exécution du bouton ${interaction.customId}:`, error);
                    const errorMessage = {
                        content: '❌ Une erreur est survenue lors de l\'exécution de ce bouton.',
                        ephemeral: true
                    };

                    if (interaction.replied || interaction.deferred) {
                        await interaction.followUp(errorMessage);
                    } else {
                        await interaction.reply(errorMessage);
                    }
                }
            }
        } catch (error) {
            console.error('❌ Erreur lors du traitement de l\'interaction:', error);
        }
    }
};