const { SlashCommandBuilder, PermissionFlagsBits } = require('discord.js');
const Database = require('../../utils/database');
const fs = require('fs').promises;
const path = require('path');

module.exports = {
    data: new SlashCommandBuilder()
        .setName('config')
        .setDescription('Configure le bot')
        .setDefaultMemberPermissions(PermissionFlagsBits.Administrator)
        .addSubcommand(subcommand =>
            subcommand
                .setName('maxemails')
                .setDescription('Définit le nombre maximum d\'emails par utilisateur')
                .addIntegerOption(option =>
                    option
                        .setName('max')
                        .setDescription('Le nombre maximum d\'emails')
                        .setRequired(true)
                        .setMinValue(1)
                        .setMaxValue(5)
                )
        ),

    async execute(interaction) {
        try {
            const subcommand = interaction.options.getSubcommand();

            if (subcommand === 'maxemails') {
                await this.setMaxEmails(interaction);
            } else {
                await interaction.reply({
                    content: '❌ Commande inconnue',
                    ephemeral: true
                });
            }
        } catch (error) {
            console.error('❌ Erreur config:', error);
            await interaction.reply({
                content: '❌ Une erreur est survenue',
                ephemeral: true
            });
        }
    },

    async setMaxEmails(interaction) {
        const max = interaction.options.getInteger('max');

        try {
            await Database.setConfig('maxEmails', max);
            
            process.env.MAX_EMAILS = max.toString();

            const envPath = path.join(process.cwd(), '.env');
            const envContent = await fs.readFile(envPath, 'utf-8');
            
            if (envContent.includes('MAX_EMAILS=')) {
                const updatedContent = envContent.replace(
                    /MAX_EMAILS=.*/,
                    `MAX_EMAILS=${max}`
                );
                await fs.writeFile(envPath, updatedContent);
            } else {
                await fs.writeFile(envPath, `${envContent}\nMAX_EMAILS=${max}`);
            }

            await interaction.reply({
                content: `✅ Nombre maximum d'emails par utilisateur défini sur \`${max}\``,
                ephemeral: true
            });
        } catch (error) {
            console.error('❌ Erreur setMaxEmails:', error);
            await interaction.reply({
                content: '❌ Erreur lors de la définition du nombre maximum d\'emails',
                ephemeral: true
            });
        }
    }
};