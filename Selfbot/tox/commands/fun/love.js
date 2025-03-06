const fs = require('fs')

module.exports = {
  name: "love",
  descriptionfr: "Envoie un message d'amour",
  descriptionen: "Send a love message",
  usage: "[user]", 
  run: async (client, message, args) => {
    const user = message.mentions.users.first() || client.users.cache.get(args[0]) || message.author 
    message.edit(`⛧ __**${client.db.name}**__ ⛧\n${client.trad("I love", "Je t'aime")} ${user.username} ❤️❤️❤️\n\nhttps://cdn.discordapp.com/attachments/603949531700396032/603951212567724042/3169546865_1_3_8YcAOoIs.gif`)
  }
}