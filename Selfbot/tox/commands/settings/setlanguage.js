const fs = require('fs')

module.exports = {
  name: "setlanguage",
  descriptionfr: "Modifie le language du bot (fr/en)",
  descriptionen: "Change the language of the bot (fr/en)",
  usage: "<url>",
  run: async (client, message, args) => {
        if (args[0] === "fr"){
            client.db.language = "fr"
            client.save()
            message.edit("Le language du selfbot a été modifié")
        }
        else{
            client.db.language = "fr"
            client.save()
            message.edit("The language of the selfbot has been modified")
        }
    }
}