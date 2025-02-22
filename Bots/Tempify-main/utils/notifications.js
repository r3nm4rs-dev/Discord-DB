const { EmbedBuilder, ButtonBuilder, ButtonStyle, ActionRowBuilder } = require('discord.js');
const Embeds = require('./embeds');

class Notifications {
    constructor(client) {
        this.client = client;
        this.notifications = new Map();
    }

    async sendEmailNotification(channel, email, userId) {
        try {
            const embed = Embeds.createReceivedEmailEmbed(email);
            const row = new ActionRowBuilder()
                .addComponents(
                    new ButtonBuilder()
                        .setCustomId('refresh_emails')
                        .setLabel('🔄 Actualiser')
                        .setStyle(ButtonStyle.Primary),
                    new ButtonBuilder()
                        .setCustomId('delete_email')
                        .setLabel('🗑️ Supprimer')
                        .setStyle(ButtonStyle.Danger)
                );

            const message = await channel.send({
                content: `🔔 **NOUVEL EMAIL** 🔔\n<@${userId}>, vous avez reçu un nouveau message !\n━━━━━━━━━━━━━━━━`,
                embeds: [embed],
                components: [row]
            });

            setTimeout(() => {
                message.delete().catch(() => {});
            }, 24 * 60 * 60 * 1000);

            return true;
        } catch (error) {
            console.error('❌ Erreur lors de l\'envoi de la notification:', error);
            return false;
        }
    }

    async sendExpirationWarning(channel, userId, expiresIn) {
        try {
            const embed = new EmbedBuilder()
                .setColor(0xFEE75C)
                .setTitle('⚠️ Email Temporaire - Expiration Proche')
                .setDescription([
                    '**Votre email temporaire va bientôt expirer !**',
                    '',
                    `⏳ Expire <t:${Math.floor((Date.now() + expiresIn) / 1000)}:R>`,
                    '',
                    '*Créez un nouvel email si nécessaire avec `/email create`*'
                ].join('\n'))
                .setFooter({ text: 'Pluzio Mail • Notification d\'expiration' });

            const row = new ActionRowBuilder()
                .addComponents(
                    new ButtonBuilder()
                        .setCustomId('create_new_email')
                        .setLabel('📧 Créer un nouvel email')
                        .setStyle(ButtonStyle.Success)
                );

            await channel.send({
                content: `⚠️ <@${userId}>, attention !`,
                embeds: [embed],
                components: [row]
            });

            return true;
        } catch (error) {
            console.error('❌ Erreur lors de l\'envoi de l\'avertissement d\'expiration:', error);
            return false;
        }
    }

    async sendWelcomeMessage(channel, userId) {
        try {
            const embed = new EmbedBuilder()
                .setColor(0x5865F2)
                .setTitle('👋 Bienvenue sur Pluzio Mail !')
                .setDescription([
                    '**Votre canal email privé a été créé !**',
                    '',
                    '**🚀 Pour commencer :**',
                    '1. Créez votre première adresse email avec le bouton ci-dessous',
                    '2. Utilisez cette adresse où vous en avez besoin',
                    '3. Les emails reçus apparaîtront automatiquement ici',
                    '',
                    '*💡 Vos emails sont privés et sécurisés*'
                ].join('\n'))
                .setFooter({ text: 'Pluzio Mail • Service d\'Email Temporaire' });

            const row = new ActionRowBuilder()
                .addComponents(
                    new ButtonBuilder()
                        .setCustomId('create_email')
                        .setLabel('📧 Créer un email')
                        .setStyle(ButtonStyle.Success),
                    new ButtonBuilder()
                        .setCustomId('help')
                        .setLabel('❓ Aide')
                        .setStyle(ButtonStyle.Secondary)
                );

            await channel.send({
                content: `🎉 <@${userId}>, bienvenue !`,
                embeds: [embed],
                components: [row]
            });

            return true;
        } catch (error) {
            console.error('❌ Erreur lors de l\'envoi du message de bienvenue:', error);
            return false;
        }
    }

    async sendErrorNotification(channel, userId, title, description) {
        try {
            const embed = Embeds.createErrorEmbed(title, description);
            
            await channel.send({
                content: `⚠️ <@${userId}>, une erreur est survenue.`,
                embeds: [embed]
            });

            return true;
        } catch (error) {
            console.error('❌ Erreur lors de l\'envoi de la notification d\'erreur:', error);
            return false;
        }
    }
}

module.exports = Notifications;