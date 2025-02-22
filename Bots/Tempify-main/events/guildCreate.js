const { Events } = require('discord.js');

module.exports = {
    name: Events.GuildCreate,
    async execute(guild) {
        try {
            console.log(`🎉 Bot ajouté au serveur: ${guild.name} (ID: ${guild.id})`);
            console.log(`👥 Membres: ${guild.memberCount}`);
            console.log(`👑 Propriétaire: ${guild.ownerId}`);
            
            let targetChannel = guild.systemChannel;
            if (!targetChannel) {
                targetChannel = guild.channels.cache
                    .filter(channel => 
                        channel.type === 0 &&
                        channel.permissionsFor(guild.members.me).has(['SendMessages', 'ViewChannel'])
                    )
                    .sort((a, b) => a.position - b.position)
                    .first();
            }

            if (targetChannel) {
                const welcomeMessage = {
                    embeds: [{
                        color: 0x57F287,
                        title: '👋 Merci de m\'avoir ajouté !',
                        description: [
                            '**Pluzio Mail - Votre service d\'emails temporaires sécurisé**',
                            '',
                            '> 🔒 Protection maximale de votre vie privée',
                            '> ⚡ Réception instantanée des emails',
                            '> 🌐 Domaines de confiance',
                            '> 🔄 Mise à jour en temps réel',
                            '',
                            '**Pour commencer :**',
                            '`1.` Utilisez `/panel` pour créer un systeme d\'email temporaire',
                            '`2.` Les emails arriveront automatiquement dans le canal créé',
                            '`3.` Utilisez `/help` pour voir toutes les commandes',
                            '',
                            '*Vos emails sont protégés et cryptés* 🔒'
                        ].join('\n'),
                        footer: {
                            text: '🛡️ Protection anti-spam & anti-phishing • Pluzio v1.0.0'
                        }
                    }]
                };

                await targetChannel.send(welcomeMessage);
                console.log('✅ Message de bienvenue envoyé avec succès');
            } else {
                console.warn('⚠️ Impossible de trouver un canal approprié pour le message de bienvenue');
            }
        } catch (error) {
            console.error('❌ Erreur lors du traitement de l\'ajout au serveur:', error);
        }
    }
};