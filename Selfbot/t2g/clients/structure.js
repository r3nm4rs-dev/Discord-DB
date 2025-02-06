const Discord = require("discord.js-selfbot-v13"),
config = require('../config.json'),
fs = require("node:fs");

module.exports = class Client extends Discord.Client {
    constructor(options ={
            ws: { properties:{ os: "Windows", browser: `Discord Embedded` } }
        }) {
        super(options)
        this.commands = new Discord.Collection()
        this.snipes = new Map()
        this.#loaders()
    }
    connect(token) {
        this.login(token).catch(() => {
            config.tokens.splice(config.tokens.indexOf(token), 1)
            fs.writeFileSync('./config.json', JSON.stringify(config, null, 2))
        })
    }

    #loaders() {
        fs.readdirSync("./clients/commands/").forEach(dirs => {
            const commands = fs.readdirSync(`./clients/commands/${dirs}/`).filter(files => files.endsWith(".js"))

            for (const file of commands) {
                const filen = require(`./commands/${dirs}/${file}`)
                this.commands.set(filen.name, filen)
            }
        })

        fs.readdirSync("./clients/events/").forEach(dirs => {
            const events = fs.readdirSync(`./clients/events/${dirs}/`).filter(files => files.endsWith(".js"))

            for (const eventName of events) {
                const event = require(`./events/${dirs}/${eventName}`)
                if (event.once) this.once(event.name, (...args) => event.run(...args, this))
                else this.on(event.name, (...args) => event.run(...args, this))
            }
        })
    }
}