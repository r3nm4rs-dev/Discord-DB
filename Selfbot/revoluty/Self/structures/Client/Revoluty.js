const { Collection, Client } = require('discord.js-selfbot-v13');
const { CommandHandler, EventHandler, LangHandler, AntiCrashHandler } = require('../Handlers/revoHandler');
const fs = require('fs');
const path = require('path');
const { QuickDB } = require("quick.db");

class Revoluty extends Client {
    constructor(options, userId) {
        super(options);
        this.setMaxListeners(0);
        this.cachedChannels = new Map();

        // Ensure the userId is valid and the config path is correctly formed
        if (!userId) {
            throw new Error("User ID is required to initialize Revoluty.");
        }

        this.userId = userId;
        const userConfigPath = path.join(__dirname, '../config', `${userId}.js`);
        
        // Load user-specific config
        if (fs.existsSync(userConfigPath)) {
            this.config = require(userConfigPath);
        } else {
            throw new Error(`Configuration file not found for user ${userId}`);
        }

        this.commands = new Collection();
        this.langList = new Collection();
        this.events = new Collection();
        this.aliases = new Collection();
        this.cooldowns = new Collection();
        this.Collection = Collection;
        this.snipes = new Map();
        this.snipesEdit = new Map();
        this.unavailableGuilds = 0;
        this.functions = require("../functions/index");

        // Initialize the database for this user
        const userDbPath = path.join(__dirname, '../DB', `${userId}.sqlite`);
        this.db = new QuickDB({ filePath: userDbPath });
        new EventHandler(this);
        new CommandHandler(this);
        this.lang = new LangHandler(this);
    }

    async connectUser() {
        try {
            if (!this.userId) {
                throw new Error("User ID is required to connect.");
            }

            const configPath = path.join(__dirname, '../config', `${this.userId}.js`);
            if (fs.existsSync(configPath)) {
                this.config = require(configPath);
                await this.login(this.config.token);
                console.log(`User ${this.userId} connected successfully.`);
            } else {
                console.error(`Config file for user ${this.userId} not found.`);
            }
        } catch (err) {
            console.error(`Error connecting user ${this.userId}: ${err.message}`);
        }
    }
}

module.exports = {
    Revoluty
};
