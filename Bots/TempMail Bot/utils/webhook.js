const express = require('express');
const Database = require('./database');
const Tempify = require('./tempmail');
const Notifications = require('./notifications');

class WebhookServer {
    constructor(client, port = process.env.WEBHOOK_PORT || 3000) {
        this.client = client;
        this.port = port;
        this.app = express();
        this.notifications = new Notifications(client);
        this.tempmail = new Tempify(process.env.TEMPMAIL_API_KEY);
        this.setupMiddleware();
        this.setupRoutes();
    }

    setupMiddleware() {
        this.app.use(express.json());
        this.app.use(express.urlencoded({ extended: true }));
        
        this.app.use((req, res, next) => {
            if (!this.validateRequest(req)) {
                return res.status(403).json({ error: 'Accès non autorisé' });
            }
            next();
        });
    }

    setupRoutes() {
        this.app.get('/health', (req, res) => {
            res.json({ status: 'ok', timestamp: Date.now() });
        });

        this.app.post('/webhook/email', async (req, res) => {
            try {
                await this.handleEmailWebhook(req.body);
                res.json({ success: true });
            } catch (error) {
                console.error('❌ Erreur webhook:', error);
                res.status(500).json({ error: error.message });
            }
        });

        this.app.use((err, req, res, next) => {
            console.error('❌ Erreur serveur:', err);
            res.status(500).json({ error: 'Erreur interne du serveur' });
        });
    }

    async handleEmailWebhook(data) {
        if (!this.validateEmailData(data)) {
            throw new Error('Données d\'email invalides');
        }

        const { to, from, subject, text, html, attachments } = data;

        try {
            const user = await Database.findUserByEmail(to);
            if (!user) {
                console.warn(`⚠️ Email reçu pour un utilisateur inconnu: ${to}`);
                return;
            }

            const channel = await this.client.channels.fetch(user.channelId);
            if (!channel) {
                console.error(`❌ Canal introuvable pour l'utilisateur: ${user.userId}`);
                return;
            }

            if (await this.isDuplicateEmail(user.userId, from, subject, Date.now())) {
                console.warn(`⚠️ Email doublon détecté pour ${user.userId}`);
                return;
            }

            await this.notifications.sendEmailNotification(channel, {
                from,
                to,
                subject,
                text,
                html,
                attachments,
                date: Date.now()
            }, user.userId);

            await Database.addEmailToHistory(user.userId, {
                from,
                subject,
                timestamp: Date.now()
            });

        } catch (error) {
            console.error('❌ Erreur lors du traitement du webhook:', error);
            throw error;
        }
    }

    validateRequest(req) {
        const apiKey = req.headers['x-api-key'];
        return apiKey === process.env.WEBHOOK_SECRET;
    }

    validateEmailData(data) {
        return data 
            && typeof data === 'object'
            && typeof data.to === 'string'
            && typeof data.from === 'string'
            && typeof data.subject === 'string'
            && (typeof data.text === 'string' || typeof data.html === 'string');
    }

    async isDuplicateEmail(userId, from, subject, timestamp) {
        const recentEmails = await Database.getRecentEmails(userId);
        const fiveMinutesAgo = timestamp - (5 * 60 * 1000);

        return recentEmails.some(email => 
            email.from === from 
            && email.subject === subject 
            && email.timestamp > fiveMinutesAgo
        );
    }

    start() {
        return new Promise((resolve, reject) => {
            try {
                this.server = this.app.listen(this.port, () => {
                    console.log(`✅ Serveur webhook démarré sur le port ${this.port}`);
                    resolve();
                });

                this.server.on('error', (error) => {
                    console.error('❌ Erreur serveur webhook:', error);
                    reject(error);
                });
            } catch (error) {
                console.error('❌ Erreur lors du démarrage du serveur webhook:', error);
                reject(error);
            }
        });
    }

    stop() {
        return new Promise((resolve, reject) => {
            if (this.server) {
                this.server.close((error) => {
                    if (error) {
                        console.error('❌ Erreur lors de l\'arrêt du serveur webhook:', error);
                        reject(error);
                    } else {
                        console.log('✅ Serveur webhook arrêté');
                        resolve();
                    }
                });
            } else {
                resolve();
            }
        });
    }
}

module.exports = WebhookServer;
