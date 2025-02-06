const fs = require('fs');
const path = require('path');
const { readdirSync } = require('fs');
class EventHandler {
    constructor(revoluty) {
        this.revoluty = revoluty;
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
            this.revoluty.once(event.name, (...args) => event.run(this.revoluty, ...args));
        } else {
            this.revoluty.on(event.name, (...args) => event.run(this.revoluty, ...args));
        }
        delete require.cache[require.resolve(file)];
    }
}

class LangHandler {
    constructor(revoluty) {
        this.revoluty = revoluty;
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
            this.revoluty.langList.set(file.split("/").pop().slice(0, -3), pull.dictionary);
        }
        delete require.cache[require.resolve(file)];
    }

    get(Lang) {
        return this.revoluty.langList.get(Lang);
    }
}

class AntiCrashHandler {
    constructor(revoluty) {
        this.revoluty = revoluty;
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
            this.revoluty.once(event.name, (...args) => event.run(this.revoluty, ...args));
        } else {
            this.revoluty.on(event.name, (...args) => event.run(this.revoluty, ...args));
        }
        delete require.cache[require.resolve(file)];
    }
}


class CommandHandler {
    constructor(revoluty) {
        this.revoluty = revoluty;
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
                    this.revoluty.aliases.set(alias.toLowerCase(), pull)
                );
            }
            this.revoluty.commands.set(pull.name.toLowerCase(), pull);
            delete require.cache[require.resolve(file)];
        }
    }
}

module.exports = { CommandHandler, EventHandler, LangHandler, AntiCrashHandler };
