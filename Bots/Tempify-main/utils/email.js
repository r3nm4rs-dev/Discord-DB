const Tempify = require('./tempmail');
const Database = require('./database');
const Embeds = require('./embeds');

class EmailService {
    constructor(client) {
        this.client = client;
        this.tempmail = new Tempify(process.env.TEMPMAIL_API_KEY);
        this.checkIntervals = new Map();
        this.lastEmailDates = new Map();
    }

    async checkEmails(channel, token, lastEmailDate = 0) {
        try {
            console.log(` Vérification des emails pour le channel ${channel.id}...`);
            const emails = await this.tempmail.getEmails(token);
            
            if (!emails || emails.length === 0) {
                return lastEmailDate;
            }

            const newEmails = emails
                .filter(email => new Date(email.date).getTime() > lastEmailDate)
                .sort((a, b) => new Date(a.date).getTime() - new Date(b.date).getTime());

            if (newEmails.length > 0) {
                console.log(` ${newEmails.length} nouveau(x) email(s) trouvé(s)`);
                for (const email of newEmails) {
                    const { embed, components } = Embeds.createReceivedEmailEmbed(email);
                    if (embed) {
                        await channel.send({ 
                            embeds: [embed],
                            components: components
                        });
                    }
                }

                return Math.max(...newEmails.map(email => new Date(email.date).getTime()));
            }

            return lastEmailDate;
        } catch (error) {
            console.error('❌ Erreur lors de la vérification des emails:', error);
            return lastEmailDate;
        }
    }

    startEmailCheck(channel, token) {
        if (this.checkIntervals.has(channel.id)) {
            clearInterval(this.checkIntervals.get(channel.id));
        }

        this.lastEmailDates.set(channel.id, Date.now());

        const interval = setInterval(async () => {
            const lastEmailDate = this.lastEmailDates.get(channel.id);
            const newLastEmailDate = await this.checkEmails(channel, token, lastEmailDate);
            this.lastEmailDates.set(channel.id, newLastEmailDate);
        }, 3000);

        this.checkIntervals.set(channel.id, interval);

        this.checkEmails(channel, token, this.lastEmailDates.get(channel.id));
    }

    stopEmailCheck(channelId) {
        if (this.checkIntervals.has(channelId)) {
            clearInterval(this.checkIntervals.get(channelId));
            this.checkIntervals.delete(channelId);
            this.lastEmailDates.delete(channelId);
        }
    }

    async createEmail(interaction) {
        try {
            const user = await Database.getUser(interaction.user.id);
            if (user && user.emails && user.emails.length >= 2) {
                throw new Error('Limite de 2 emails atteinte');
            }

            const { address, token } = await this.tempmail.createInbox();
            
            const channel = await interaction.guild.channels.create({
                name: `Tempify-${interaction.user.username}`,
                type: 0,
                parent: process.env.CATEGORY_ID,
                permissionOverwrites: [
                    {
                        id: interaction.guild.id,
                        deny: ['ViewChannel', 'SendMessages']
                    },
                    {
                        id: interaction.user.id,
                        allow: ['ViewChannel', 'ReadMessageHistory', 'SendMessages']
                    },
                    {
                        id: this.client.user.id,
                        allow: ['ViewChannel', 'SendMessages', 'EmbedLinks', 'ManageMessages']
                    }
                ]
            });

            const emailData = {
                address,
                token,
                channelId: channel.id,
                createdAt: Date.now(),
                expiresAt: Date.now() + 60 * 60 * 1000
            };

            await Database.addEmailToUser(interaction.user.id, emailData);

            this.startEmailCheck(channel, token);

            return { channel, address, token };
        } catch (error) {
            console.error('❌ Erreur lors de la création de l\'email:', error);
            throw error;
        }
    }

    async deleteEmail(userId, channelId) {
        try {
            const user = await Database.getUser(userId);
            if (!user || !user.emails) return false;

            const email = user.emails.find(e => e.channelId === channelId);
            if (!email) return false;

            this.stopEmailCheck(channelId);

            try {
                await this.tempmail.deleteInbox(email.token);
            } catch (error) {
                console.error('❌ Erreur lors de la suppression de l\'inbox:', error);
            }

            await Database.removeEmailFromUser(userId, channelId);
            return true;
        } catch (error) {
            console.error('❌ Erreur lors de la suppression de l\'email:', error);
            return false;
        }
    }
}

module.exports = EmailService;
