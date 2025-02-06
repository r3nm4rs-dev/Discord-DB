const fs = require('fs');
const path = require('path');
const { readdirSync } = require('fs');
const { PermissionsBitField } = require('discord.js');
const { Routes } = require('discord-api-types/v9');
const { REST } = require('@discordjs/rest');
class EventHandler {
    constructor(clarity) {
        this.clarity = clarity;
        this.getFiles(path.resolve(__dirname, '../../events'));
    }

    getFiles(dir) {
        fs.readdir(dir, (err, files) => {
            if (err) throw err;
            files.forEach(file => {
                const filePath = path.join(dir, file);
                fs.stat(filePath, (err, stats) => {
                    if (err) throw err;
                    if (stats.isDirectory()) {
                        this.getFiles(filePath);
                    } else if (file.endsWith('.js') && !file.endsWith('.disabled')) {
                        console.log(`[EVENTS] Bind: ${file.split('.js')[0]}`);
                        this.registerFile(filePath);
                    }
                });
            });
        });
    }

    registerFile(file) {
        const event = require(file);
        if (event.once) {
            this.clarity.once(event.name, (...args) => event.run(this.clarity, ...args));
        } else {
            this.clarity.on(event.name, (...args) => event.run(this.clarity, ...args));
        }
        delete require.cache[require.resolve(file)];
    }
}

class LangHandler {
    constructor(clarity) {
        this.clarity = clarity;
        this.getFiles(path.resolve(__dirname, '../../lang'));
    }

    getFiles(dir) {
        fs.readdir(dir, (err, files) => {
            if (err) throw err;
            files.forEach(file => {
                const filePath = path.join(dir, file);
                fs.stat(filePath, (err, stats) => {
                    if (err) throw err;
                    if (stats.isDirectory()) {
                        this.getFiles(filePath);
                    } else if (file.endsWith('.js') && !file.endsWith('.disabled')) {
                        console.log(`[LANG] Bind: ${file.split('.js')[0]}`);
                        this.registerFile(filePath);
                    }
                });
            });
        });
    }

    registerFile(file) {
        const pull = require(file);
        if (pull.name) {
            this.clarity.langList.set(file.split("/").pop().slice(0, -3), pull.dictionary);
        }
        delete require.cache[require.resolve(file)];
    }

    get(Lang) {
        return this.clarity.langList.get(Lang);
    }
}

class AntiCrashHandler {
    constructor(clarity) {
        this.clarity = clarity;
        this.getFiles(path.resolve(__dirname, '../../antiCrash'));
    }

    getFiles(dir) {
        fs.readdir(dir, (err, files) => {
            if (err) throw err;
            files.forEach(file => {
                const filePath = path.join(dir, file);
                fs.stat(filePath, (err, stats) => {
                    if (err) throw err;
                    if (stats.isDirectory()) {
                        this.getFiles(filePath);
                    } else if (file.endsWith('.js') && !file.endsWith('.disabled')) {
                        console.log(`[ANTICRASH] Bind: ${file.split('.js')[0]}`);
                        this.registerFile(filePath);
                    }
                });
            });
        });
    }

    registerFile(file) {
        const event = require(file);
        if (event.once) {
            this.clarity.once(event.name, (...args) => event.run(this.clarity, ...args));
        } else {
            this.clarity.on(event.name, (...args) => event.run(this.clarity, ...args));
        }
        delete require.cache[require.resolve(file)];
    }
}

class SlashCommandHandler {
    constructor(client, rest) {
        this.client = client;
        this.rest = rest;

        // Load and register commands when the bot is ready
        this.client.once('ready', () => {
            this.loadCommands();
            this.registerCommands();
        });
    }

    loadCommands() {
        const data = [];
        let count = 0;

        // Read all directories in ./slashCommands/
        const commandDirs = readdirSync(path.resolve(__dirname, '../../slashCommands/'));
        commandDirs.forEach((dir) => {
            // Filter all JavaScript files in the directory
            const slashCommandFiles = readdirSync(path.resolve(__dirname, `../../slashCommands/${dir}/`)).filter((file) => file.endsWith(".js"));

            // Loop through each file and set up the command
            for (const file of slashCommandFiles) {
                const filePath = path.resolve(__dirname, `../../slashCommands/${dir}/${file}`);
                const slashCommand = require(filePath);

                if (!slashCommand.name) {
                    console.error(`slashCommandNameError: ${file.split(".")[0]} application command name is required.`);
                    continue;
                }

                if (!slashCommand.description) {
                    console.error(`slashCommandDescriptionError: ${file.split(".")[0]} application command description is required.`);
                    continue;
                }

                // Set the command in the client's collection
                this.client.slashCommands.set(slashCommand.name, slashCommand);

                // Add the command data to the data array for registration
                data.push({
                    name: slashCommand.name,
                    description: slashCommand.description,
                    type: slashCommand.type || 1, // Default to type 1 if not specified
                    options: slashCommand.options || null,
                    default_permission: slashCommand.default_permission || null,
                    default_member_permissions: slashCommand.default_member_permissions ? PermissionsBitField.resolve(slashCommand.default_member_permissions).toString() : null
                });
                count++;
            }
        });

        // Store the data for later registration
        this.data = data;
        console.log(`Loaded ${count} slash commands.`);
    }

    async registerCommands() {
        const rest = this.rest || new REST({ version: '10' }).setToken(this.client.config.manager.token);

        try {
            await rest.put(
                Routes.applicationCommands(this.client.config.manager.botId),
                { body: this.data }
            );
            console.log('Successfully registered application commands.');
        } catch (error) {
            console.error('Error registering application commands:', error);
        }
    }
}

class CommandHandler {
    constructor(clarity) {
        this.clarity = clarity;
        this.getFiles(path.resolve(__dirname, '../../commands'));
    }

    getFiles(dir) {
        fs.readdir(dir, (err, files) => {
            if (err) throw err;
            files.forEach(file => {
                const filePath = path.join(dir, file);
                fs.stat(filePath, (err, stats) => {
                    if (err) throw err;
                    if (stats.isDirectory()) {
                        this.getFiles(filePath);
                    } else if (file.endsWith('.js') && !file.endsWith('.disabled')) {
                        console.log(`[COMMANDS] Bind: ${file.split('.js')[0]}`);
                        this.registerFile(filePath);
                    }
                });
            });
        });
    }

    registerFile(file) {
        const pull = require(file);
        if (pull.name) {
            if (pull.aliases && Array.isArray(pull.aliases)) {
                pull.aliases.forEach(alias =>
                    this.clarity.aliases.set(alias.toLowerCase(), pull)
                );
            }
            this.clarity.commands.set(pull.name.toLowerCase(), pull);
            delete require.cache[require.resolve(file)];
        }
    }
}

module.exports = { CommandHandler, EventHandler, LangHandler, SlashCommandHandler, AntiCrashHandler };
