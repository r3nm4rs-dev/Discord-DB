const axios = require('axios');

class Tempify {
    constructor(apiKey) {
        if (!apiKey) {
            throw new Error('API Key is required for Tempify service');
        }

        this.apiKey = apiKey;
        this.client = axios.create({
            baseURL: 'https://api.tempmail.lol/v2',
            headers: {
                'Authorization': `Bearer ${apiKey}`,
                'Content-Type': 'application/json',
                'Accept': 'application/json'
            },
            timeout: 15000
        });
    }

    async createInbox() {
        try {
            console.log(' Création d\'un nouvel email temporaire...');
            const response = await this.client.post('/inbox/create', {}, {
                validateStatus: function (status) {
                    return status >= 200 && status < 500;
                }
            });
            
            console.log(' Réponse de l\'API:', JSON.stringify(response.data, null, 2));
            
            if (!response.data) {
                throw new Error('Réponse vide de l\'API Tempify');
            }

            if (response.status === 401) {
                throw new Error('Clé API invalide. Veuillez vérifier votre configuration.');
            }

            if (response.status === 429) {
                throw new Error('Trop de requêtes. Veuillez réessayer dans quelques minutes.');
            }

            if (!response.data.address || !response.data.token) {
                console.error(' Réponse invalide:', response.data);
                throw new Error('Format de réponse invalide de l\'API Tempify');
            }

            console.log(' Email créé avec succès:', response.data.address);
            const createdAt = Date.now();
            const expiresAt = createdAt + (60 * 60 * 1000);
            return {
                address: response.data.address,
                token: response.data.token,
                createdAt,
                expiresAt,
                remainingTime: expiresAt - createdAt
            };
        } catch (error) {
            console.error(' Erreur détaillée:', {
                message: error.message,
                response: error.response?.data,
                status: error.response?.status,
                headers: error.response?.headers
            });

            if (error.code === 'ECONNABORTED') {
                throw new Error('Le serveur Tempify met trop de temps à répondre. Veuillez réessayer.');
            }

            throw new Error('Impossible de créer l\'email temporaire. ' + error.message);
        }
    }

    async getEmails(token) {
        if (!token) {
            throw new Error('Token requis pour récupérer les emails');
        }

        try {
            console.log(' Récupération des emails...');
            const response = await this.client.get('/inbox', {
                params: { token },
                validateStatus: function (status) {
                    return status >= 200 && status < 500;
                }
            });
            
            if (response.status === 404) {
                console.log(' Token expiré ou invalide');
                return [];
            }

            if (!response.data || !response.data.emails) {
                console.log(' Aucun email trouvé');
                return [];
            }

            if (response.data.expired) {
                console.log(' L\'email est expiré');
            }

            return response.data.emails.map(email => ({
                from: email.from,
                to: email.to,
                subject: email.subject,
                text: email.body,
                html: email.html,
                date: email.date
            }));

        } catch (error) {
            console.error(' Erreur lors de la récupération des emails:', error);
            throw new Error('Impossible de récupérer les emails: ' + error.message);
        }
    }

    cleanEmailContent(content) {
        content = content.replace(/<[^>]*>/g, '');
        content = content.replace(/[\r\n]+/g, '\n').trim();
        return content.length > 4096 ? content.substring(0, 4093) + '...' : content;
    }

    processAttachments(attachments = []) {
        return attachments.map(attachment => ({
            filename: attachment.filename || 'fichier.txt',
            contentType: attachment.contentType || 'application/octet-stream',
            size: attachment.size || 0,
            url: attachment.url || null
        }));
    }

    async deleteInbox(token) {
        if (!token) {
            throw new Error('Token is required to delete inbox');
        }

        try {
            await this.client.delete(`/inbox/${token}`, {
                validateStatus: function (status) {
                    return status >= 200 && status < 500;
                }
            });
            return true;
        } catch (error) {
            console.error(' Erreur lors de la suppression de l\'email:', error.message);
            return false;
        }
    }

    async checkToken(token) {
        if (!token) {
            return false;
        }

        try {
            const response = await this.client.get(`/validate/${token}`, {
                validateStatus: function (status) {
                    return status >= 200 && status < 500;
                }
            });
            return response.data?.valid === true;
        } catch {
            return false;
        }
    }

    getExpirationTime(createdAt) {
        const expiresAt = createdAt + (60 * 60 * 1000);
        return {
            expiresAt,
            remainingTime: Math.max(0, expiresAt - Date.now())
        };
    }
}

module.exports = Tempify;