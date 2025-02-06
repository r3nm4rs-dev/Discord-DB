const Discord = require("discord.js-selfbot-v13");
const {  language } = require("../../fonctions")
module.exports = {
  name: "update",
  description: "Restart the client",
  run: async (client, message, args, db) => {
    try{
      message.edit(await language(client,`> Mise à jours du selfbot en cours..`, `> Restart..`))
      message.edit(await language(client,`> Mise a jours Terminé`, `> Restart Ended`))
       }
    catch{}
  }
}