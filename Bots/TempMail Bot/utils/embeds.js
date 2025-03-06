const { EmbedBuilder, ActionRowBuilder, ButtonBuilder, ButtonStyle } = require('discord.js');
const config = require('../config.json');

const Colors = {
    PRIMARY: 0x5865F2,
    SUCCESS: 0x57F287,
    WARNING: 0xFEE75C,
    ERROR: 0xED4245,
    INFO: 0x5865F2
};

class Embeds {
    static createPanelEmbed() {
        const embed = new EmbedBuilder()
            .setColor(Colors.PRIMARY)
            .setDescription([
                '# ✉️ Pluzio Mail',
                '',
                '> Bienvenue dans votre service d\'emails temporaires !',
                '',
                '## 🌟 Caractéristiques',
                '```md',
                '1. 🔒 Emails cryptés de bout en bout',
                '2. ⚡ Réception instantanée (3s)',
                '3. 🔄 Actualisation en temps réel',
                '4. 🛡️ Protection anti-spam & anti-phishing',
                '5. ⏰ Durée de vie : 1 heure',
                '```',
                '',
                '## 💫 Comment utiliser',
                '```md',
                '1. Cliquez sur le bouton ci-dessous',
                '2. Recevez votre email temporaire',
                '3. Utilisez-le pour vos inscriptions',
                '4. Recevez vos emails instantanément',
                '```'
            ].join('\n'))
            .setImage(config.embeds.images.logo)
            .setFooter({ text: `Pluzio Mail • Version ${config.bot.version} • Made With 💖 by Droska` })
            .setTimestamp();

        return embed;
    }

    static createEmailEmbed(user, address) {
        const maxEmails = process.env.MAX_EMAILS || 2;
        const emailCount = user?.emails?.length || 0;
        const expirationTime = Math.floor((Date.now() + 60 * 60 * 1000) / 1000);

        const embed = new EmbedBuilder()
            .setColor(Colors.SUCCESS)
            .setTitle('📨 Email Créé avec Succès')
            .setDescription([
                '## 📬 Votre Adresse Email',
                `\`\`\`${address}\`\`\``,
                '',
                '## ℹ️ Informations',
                `> 📧 Emails actifs: ${emailCount}/${maxEmails}`,
                `> ⏰ Expiration: <t:${expirationTime}:R>`,
                '',
                '## 🔒 Sécurité',
                '```md',
                '1. 🔐 Cryptage de bout en bout',
                '2. 🛡️ Protection anti-spam & anti-phishing',
                '3. ⌛ Suppression automatique après 60 minutes',
                '```',
                '',
                '⚠️ Ce channel sera automatiquement supprimé après l\'expiration de l\'email.'
            ].join('\n'))
            .setFooter({ text: 'Pluzio Mail • Email Sécurisé • Made With 💖 by r3nm4rss' })
            .setTimestamp();

        return {
            embed,
            components: [
                new ActionRowBuilder().addComponents(
                    new ButtonBuilder()
                        .setCustomId('delete_channel')
                        .setLabel('Supprimer votre email temporaire')
                        .setStyle(ButtonStyle.Danger)
                        .setEmoji('🗑️')
                )
            ]
        };
    }

    static createReceivedEmailEmbed(email) {
        const embed = new EmbedBuilder()
            .setColor(Colors.SUCCESS)
            .setTitle('📨 Nouvel Email Reçu')
            .addFields(
                { 
                    name: '👤 Expéditeur',
                    value: `\`${email.from}\``,
                    inline: true 
                },
                { 
                    name: '⏰ Reçu',
                    value: `<t:${Math.floor(Date.now() / 1000)}:R>`,
                    inline: true 
                },
                { 
                    name: '📝 Sujet',
                    value: email.subject || '*(Sans sujet)*',
                    inline: false 
                }
            )
            .setFooter({ text: 'Pluzio Mail • Email Sécurisé • Made With 💖 by r3nm4rss' })
            .setTimestamp();

        if (email.text) {
            let content = email.text;
            if (content.length > 1024) {
                content = content.substring(0, 1000) + '\n\n... [Message tronqué]';
            }

            embed.addFields({ 
                name: '📄 Contenu',
                value: `\`\`\`\n${content}\n\`\`\``
            });
        }

        if (email.html) {
            embed.addFields({ 
                name: '🌐 HTML',
                value: 'Cet email contient du contenu HTML'
            });
        }

        return {
            embed,
            components: [
                new ActionRowBuilder().addComponents(
                    new ButtonBuilder()
                        .setCustomId('delete_channel')
                        .setLabel('Supprimer votre email temporaire')
                        .setStyle(ButtonStyle.Danger)
                        .setEmoji('🗑️')
                )
            ]
        };
    }

    static createWarningEmbed(user) {
        return new EmbedBuilder()
            .setColor('#FFA500')
            .setTitle('⚠️ Avertissement - Suppression Imminente')
            .setDescription(`${user}, votre email temporaire sera supprimé dans **5 minutes** !

\`\`\`
⏰ Temps restant : 5 minutes
📧 Sauvegardez vos emails importants
🔔 Cette action est automatique
\`\`\`

> Vous allez désormais pouvoir créer un nouveau canal !`)
            .setTimestamp()
            .setFooter({ text: '🗑️ Suppression automatique' });
    }

    static async handleChannelDeletion(channel, user) {
        const warningMessage = await channel.send({
            content: `${user}`,
            embeds: [this.createWarningEmbed(user)]
        });

        await new Promise(resolve => setTimeout(resolve, 5 * 60 * 1000));

        try {
            await channel.delete();
        } catch (error) {
            console.error('Erreur lors de la suppression du canal:', error);
        }
    }
}

module.exports = Embeds;