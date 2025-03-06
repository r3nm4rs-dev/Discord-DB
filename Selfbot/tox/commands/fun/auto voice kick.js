const { Message } = require("djs-selfbot-v13");

const fs = require('fs')

module.exports = {
    name: "start-typing",
    descriptionfr: "Ecrit indéfiniment",
    descriptionen: "Always typing",
    usage: "",
    /**
     * @param {Message} message
    */
    run: async (client, message, args) => {
        message.edit(client.trad("You're now typing", "tu es en train d'écrire"))
        message.channel.sendTyping()
    }
}