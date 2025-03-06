const Database = require('../utils/database');

module.exports = {
    id: 'delete_channel',
    async execute(interaction) {
        try {
            await interaction.deferReply({ ephemeral: true });

            const user = await Database.getUser(interaction.user.id);
            if (!user) {
                return await interaction.editReply({
                    content: '❌ Aucun email trouvé pour ce channel.',
                    ephemeral: true
                });
            }

            const email = user.emails.find(e => e.channelId === interaction.channel.id);
            if (!email) {
                return await interaction.editReply({
                    content: '❌ Aucun email trouvé pour ce channel.',
                    ephemeral: true
                });
            }

            interaction.client.emailService.stopEmailCheck(interaction.channel.id);

            await Database.removeEmailFromUser(interaction.user.id, email.address);

            await interaction.editReply({
                content: '✅ Email et channel supprimés avec succès !',
                ephemeral: true
            });

            await interaction.channel.delete();

        } catch (error) {
            console.error('❌ Erreur lors de la suppression:', error);
            try {
                await interaction.editReply({
                    content: `❌ Une erreur est survenue: ${error.message}`,
                    ephemeral: true
                });
            } catch {
                console.error('Impossible d\'envoyer le message d\'erreur');
            }
        }
    }
};
