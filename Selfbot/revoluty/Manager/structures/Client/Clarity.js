const {Collection, Client} = require('pwss');
const { CommandHandler , EventHandler, SlashCommandHandler, LangHandler, AntiCrashHandler } = require('../handlers/clariHandler');
const { Database } = require("../handlers/Database")
const { REST } = require('@discordjs/rest');
const { Routes } = require('discord-api-types/v9');
const fs = require('fs');
const config = require('../config/index')
const rest = new REST({ version: '9' }).setToken(config.manager.token)
const dbConfig = require("../DB/Config")
class Clarity extends Client {
    constructor(options) {
        super(options);
        this.setMaxListeners(0);
        this.cachedChannels = new Map()
        this.config = config;
        this.commands = new Collection();
        this.slashCommands = new Collection();
        this.langList = new Collection();
        this.events = new Collection();
        this.aliases = new Collection();
        this.cooldowns = new Collection();
        this.Collection = Collection
        this.snipes = new Map();
        this.db = new Database(dbConfig).useClarityDB()
        this.snipesEdit = new Map();
        this.unavailableGuilds = 0;
        this.functions = require("../functions/index")
        this.ms = require("../utils/ms")
        this.afk = require("../utils/afk");
        this.axios = require("axios");
        this.version = require("../config/version");
        this.connectToken();
        new EventHandler(this);
        this.slashCommandHandler = new SlashCommandHandler(this, rest);
        new AntiCrashHandler(this);
        this.lang = new LangHandler(this)
    }

    async connectToken() {
        this.login(this.config.manager.token)
        .then(() => {
            var x = setInterval(() => {
                if (this.ws.reconnecting || this.ws.destroyed) {
                    this.login(this.config.manager.token).catch((err) => {
                        clearInterval(x);
                        console.error(`Erreur pendant la connexion au token : ${err}`);
                    });
                }
            }, 30000)
        })
            .catch((err) => {
                console.error(err);
                if(err?.code?.toLowerCase()?.includes("token")) return;
                setTimeout(() => {
                    this.connectToken();
                }, 10000)
            })
    }
    async refreshConfig() {
        delete this.config;
        delete require.cache[require.resolve("../config/index.js")];
        this.config = require("../config/index");
    }


}

module.exports = {
    Clarity
}