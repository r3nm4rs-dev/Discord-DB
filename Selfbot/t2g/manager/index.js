const Discord = require("discord.js")
const fs = require("node:fs");
module.exports = class manager extends Discord.Client {
    constructor() {
        super({
            intents: [3276799, Discord.GatewayIntentBits.Guilds, Discord.GatewayIntentBits.MessageContent, Discord.GatewayIntentBits.DirectMessages, Discord.GatewayIntentBits.DirectMessageTyping],
            partials: [
                1, 2, 5, 3,
                4, 6, 0,
                Discord.Partials.Channel, Discord.Partials.Message
            ]
        });
        this.commands = new Discord.Collection()
        this.loadCommand()
        this.on("ready", async () => {
            this.application.commands.set(this.commands.toJSON())
        })
    }
    connect(token) {
        this.login(token)
    }
    loadCommand() {
        fs.readdirSync("./manager/commands/").forEach((dir) => {
            const sl = fs.readdirSync(`./manager/commands/${dir}/`).filter((files) => files.endsWith(".js"));
            for (const file of sl) {
                const slashCommand = require(`./commands/${dir}/${file}`);
                slashCommand.folder = dir
                this.commands.set(slashCommand.name, slashCommand);
            }
        });
        const subff = fs.readdirSync(`./manager/events`)
        for (const category of subff) {
            const files = fs.readdirSync(`./manager/events/${category}`)
            for (const file of files) {
                const event = require(`./events/${category}/${file}`)
                this.on(event.name, (...args) => event.run(this, ...args))
            }
        }
    }
    setClients(clientArray) {
        this.clients = clientArray;
        this.commands.forEach(command => {
            if (typeof command.setClients === 'function') {
                command.setClients(clientArray);
            }
        });
    }
}