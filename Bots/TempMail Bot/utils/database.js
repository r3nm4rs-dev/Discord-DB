const fs = require('fs').promises;
const path = require('path');

class Database {
    constructor() {
        this.dataDir = path.join(process.cwd(), 'data');
        this.usersFile = path.join(this.dataDir, 'users.json');
        this.emailsFile = path.join(this.dataDir, 'emails.json');
        this.configFile = path.join(this.dataDir, 'config.json');
        this.cache = {
            users: new Map(),
            emails: new Map(),
            config: new Map()
        };
    }

    async init() {
        try {
            await fs.mkdir(this.dataDir, { recursive: true });
            await this.createFileIfNotExists(this.usersFile, []);
            await this.createFileIfNotExists(this.emailsFile, []);
            await this.createFileIfNotExists(this.configFile, {});
            await this.loadCache();
        } catch (error) {
            throw error;
        }
    }

    async createFileIfNotExists(filePath, defaultContent) {
        try {
            await fs.access(filePath);
        } catch {
            await fs.writeFile(filePath, JSON.stringify(defaultContent, null, 2));
        }
    }

    async loadCache() {
        try {
            const usersData = await fs.readFile(this.usersFile, 'utf-8');
            const users = JSON.parse(usersData);
            this.cache.users = new Map(users.map(user => [user.id, user]));

            const emailsData = await fs.readFile(this.emailsFile, 'utf-8');
            const emails = JSON.parse(emailsData);
            this.cache.emails = new Map(emails.map(email => [email.address, email]));

            const configData = await fs.readFile(this.configFile, 'utf-8');
            this.cache.config = new Map(Object.entries(JSON.parse(configData)));
        } catch (error) {
            throw error;
        }
    }

    async save() {
        try {
            const users = Array.from(this.cache.users.values());
            await fs.writeFile(this.usersFile, JSON.stringify(users, null, 2));

            const emails = Array.from(this.cache.emails.values());
            await fs.writeFile(this.emailsFile, JSON.stringify(emails, null, 2));

            const config = Object.fromEntries(this.cache.config);
            await fs.writeFile(this.configFile, JSON.stringify(config, null, 2));
        } catch (error) {
            throw error;
        }
    }

    async getUser(userId) {
        return this.cache.users.get(userId) || null;
    }

    async createUser(userId) {
        const user = {
            id: userId,
            emails: [],
            createdAt: Date.now()
        };
        this.cache.users.set(userId, user);
        await this.save();
        return user;
    }

    async addEmailToUser(userId, emailData) {
        let user = await this.getUser(userId);
        if (!user) {
            user = await this.createUser(userId);
        }

        const email = {
            address: emailData.address,
            token: emailData.token,
            createdAt: emailData.createdAt || Date.now(),
            channelId: emailData.channelId,
            expiresAt: Date.now() + (60 * 60 * 1000)
        };

        const maxEmails = process.env.MAX_EMAILS || 3;
        if (user.emails.length >= maxEmails) {
            throw new Error(`Vous avez atteint la limite de ${maxEmails} emails temporaires.`);
        }

        user.emails.push(email);
        
        this.cache.emails.set(email.address, {
            ...email,
            userId
        });

        await this.save();
        return user;
    }

    async removeEmailFromUser(userId, emailAddress) {
        const user = await this.getUser(userId);
        if (!user || !user.emails) {
            return false;
        }

        const emailIndex = user.emails.findIndex(e => e.address === emailAddress);
        if (emailIndex === -1) {
            return false;
        }

        const emailToRemove = user.emails[emailIndex];

        user.emails.splice(emailIndex, 1);
        
        this.cache.emails.delete(emailAddress);

        if (user.emails.length === 0) {
            this.cache.users.delete(userId);
        }

        await this.save();

        return {
            success: true,
            channelId: emailToRemove.channelId
        };
    }

    async getEmailsByUser(userId) {
        const user = await this.getUser(userId);
        return user?.emails || [];
    }

    async getEmailByAddress(address) {
        return this.cache.emails.get(address) || null;
    }

    async setConfig(key, value) {
        this.cache.config.set(key, value);
        await this.save();
    }

    async getConfig(key) {
        return this.cache.config.get(key);
    }

    async cleanupExpiredEmails() {
        const now = Date.now();
        let cleaned = 0;

        for (const [userId, user] of this.cache.users) {
            if (!user.emails) continue;

            const expiredEmails = user.emails.filter(email => email.expiresAt < now);
            if (expiredEmails.length > 0) {
                user.emails = user.emails.filter(email => email.expiresAt >= now);
                expiredEmails.forEach(email => {
                    this.cache.emails.delete(email.address);
                    cleaned++;
                });
            }
        }

        if (cleaned > 0) {
            await this.save();
            console.log(`🧹 ${cleaned} email(s) expiré(s) supprimé(s)`);
        }

        return cleaned;
    }
}

module.exports = new Database();