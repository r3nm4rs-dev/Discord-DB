const ClarityDB = require("clarity-db");
const { SteganoDB } = require("stegano.db");
const { Client } = require("quickpostgres");
const { QuickDB, MySQLDriver, MongoDriver, JSONDriver, MemoryDriver } = require("quick.db");
const { MongoClient } = require('mongodb');

class Database {
    constructor(config) {
        this.config = config || {}; // Ensure config is defined
        this.databases = {};

        // Dynamically initialize each database if its config is present
        if (this.config.clarityDB) this.initClarityDB();
        if (this.config.steganoDB) this.initSteganoDB();
        if (this.config.quickDB) this.initQuickDB();
        if (this.config.postgres) this.initPostgres();
        if (this.config.mongoDB) this.initMongoDB();
    }

    initClarityDB() {
        const clarityConfig = this.config.clarityDB;
        this.databases.clarityDB = new ClarityDB(`./structures/DB/NOSQL/JSON/${clarityConfig.dbName}.json`, {
            backup: {
                enabled: clarityConfig.backup?.enabled ?? true,
                folder: clarityConfig.backup?.folder ?? './db_backups/',
                interval: clarityConfig.backup?.interval ?? 3600000
            },
            preset: clarityConfig.preset || { hello: "world" }
        });
    }

    initSteganoDB() {
        const steganoConfig = this.config.steganoDB;
        this.databases.steganoDB = new SteganoDB(`./structures/DB/NOSQL/Stegano/${steganoConfig.dbName}.png`);
    }

    initQuickDB() {
        let driver;
        const quickConfig = this.config.quickDB;

        switch (quickConfig.driver) {
            case 'mysql':
                driver = new MySQLDriver(quickConfig.mysqlOptions);
                break;
            case 'mongo':
                driver = new MongoDriver(quickConfig.mongoURI);
                break;
            case 'json':
                driver = new JSONDriver();
                break;
            case 'memory':
                driver = new MemoryDriver();
                break;
            case 'sqlite':
                // Create SQLite database directly without specifying a driver
                this.databases.quickDB = new QuickDB({ filepath: `./structures/DB/QuickDB/db.sqlite` });
                return;
            default:
                throw new Error("Unsupported QuickDB driver specified");
        }

        this.databases.quickDB = new QuickDB({ driver });
    }

    initPostgres() {
        const postgresConfig = this.config.postgres;
        this.databases.postgres = new Client({
            connectionString: postgresConfig.connectionString
        });
        this.databases.postgres.connect();
    }

    initMongoDB() {
        const mongoConfig = this.config.mongoDB;
        this.databases.mongoDB = new MongoClient(mongoConfig.connectionString, { useNewUrlParser: true, useUnifiedTopology: true });
        this.databases.mongoDB.connect();
    }

    useClarityDB() {
        return this.databases.clarityDB;
    }

    useSteganoDB() {
        return this.databases.steganoDB;
    }

    useQuickDB() {
        return this.databases.quickDB;
    }

    usePostgres() {
        return this.databases.postgres;
    }

    useMongoDB() {
        return this.databases.mongoDB;
    }

    prepareStatement(dbName, tableName) {
        const db = this.databases[dbName];
        if (!db) throw new Error(`Database ${dbName} not found`);

        if (typeof db.prepare !== 'function') {
            throw new Error(`The prepare method is not available for the ${dbName} database`);
        }

        return db.prepare(tableName);
    }
}

module.exports = { Database };
