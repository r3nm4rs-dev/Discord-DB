const Embeds = require('../utils/embeds');
const Database = require('../utils/database');

module.exports = {
    id: 'create_email',
    async execute(interaction) {
        try {
            await interaction.deferReply({ ephemeral: true });

            const user = await Database.getUser(interaction.user.id);
            const maxEmails = process.env.MAX_EMAILS || 2;
            
            if (user && user.emails && user.emails.length >= maxEmails) {
                return await interaction.editReply({
                    content: `❌ Vous avez atteint la limite de ${maxEmails} emails temporaires.`,
                    ephemeral: true
                });
            }

            const { channel, address } = await interaction.client.emailService.createEmail(interaction);

            const { embed, components } = Embeds.createEmailEmbed(await Database.getUser(interaction.user.id), address);

            await channel.send({ 
                embeds: [embed],
                components: components
            });

            await interaction.editReply({
                content: `✅ Email créé avec succès! Rendez-vous dans ${channel}`,
                ephemeral: true
            });

            const deleteAfter = 55 * 60 * 1000;
            setTimeout(() => {
                Embeds.handleChannelDeletion(channel, interaction.user);
            }, deleteAfter);

        } catch (error) {
            console.error('❌ Erreur lors de la création de l\'email:', error);
            await interaction.editReply({
                content: `❌ Une erreur est survenue: ${error.message}`,
                ephemeral: true
            });
        }
    }
};