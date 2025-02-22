const { SlashCommandBuilder } = require('discord.js');
const { ButtonBuilder, ButtonStyle, ActionRowBuilder } = require('discord.js');
const Embeds = require('../../utils/embeds');
const Database = require('../../utils/database');

module.exports = {
    data: new SlashCommandBuilder()
        .setName('panel')
        .setDescription('Gérer vos emails temporaires'),

    async execute(interaction) {
        try {
            await Database.init().catch(error => {
                console.error('❌ Erreur initialisation base de données:', error);
                throw new Error('Erreur lors de l\'initialisation de la base de données.');
            });

            let user = await Database.getUser(interaction.user.id);

            if (!user) {
                const userData = {
                    id: interaction.user.id,
                    activeEmail: null,
                    emails: [],
                    lastEmailCreated: null,
                    createdAt: Date.now()
                };
                await Database.createUser(interaction.user.id);
                user = await Database.getUser(interaction.user.id);
            }

            if (user.activeEmail) {
                const email = await Database.getEmail(user.activeEmail);
                if (email) {
                    const timeLeft = email.expiresAt - Date.now();
                    if (timeLeft > 0) {
                        return interaction.reply({
                            content: '❌ Vous avez déjà un email actif !',
                            flags: ['Ephemeral']
                        });
                    }
                }
            }

            const createButton = new ButtonBuilder()
                .setCustomId('create_email')
                .setLabel('Créer un Email')
                .setStyle(ButtonStyle.Primary)
                .setEmoji('📧');

            const row = new ActionRowBuilder().addComponents(createButton);

            const embed = Embeds.createPanelEmbed();

            await interaction.reply({ 
                embeds: [embed], 
                components: [row]
            });
            
            console.info(`Panel créé par ${interaction.user.tag}`);
        } catch (error) {
            console.error('❌ Erreur lors de la création du panel:', error);
            return interaction.reply({
                content: '❌ Une erreur est survenue lors de la création du panel.',
                flags: ['Ephemeral']
            });
        }
    }
};