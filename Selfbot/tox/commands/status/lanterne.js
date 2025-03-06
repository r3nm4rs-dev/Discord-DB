const fs = require('fs')

module.exports = {
    name: "lanterne",
    descriptionfr: "Change ton status en boucle",
    descriptionen: "Change in loop your status",
    usage: "[stop]",
    run: async (client, message, args) => {
        if (args[0] === "stop"){
            message.edit(client.trad(`Your activity is not gonna always change`, `Ton activité ne se changera plus`))
            clearInterval(client.lant)
        }
        else {
            message.edit(client.trad(`Your activity is gonna always change`, `Ton activité se changera toute seule`))
            let i = 0
            var status = ["online", "idle", "dnd"]
            client.lant = setInterval(() => {
                if (i === status.length) i = 0
                client.user.setStatus(status[i]); i++
            }, 2000);
        }
    }
}