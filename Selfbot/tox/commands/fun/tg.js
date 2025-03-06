const fs = require('fs')

module.exports = {
  name: "tg",
  descriptionfr: "Nan ta gueule",
  descriptionen: "No shut up",
  usage: "[user]", 
  run: async (client, message, args) => {
    const user = message.mentions.users.first() || client.users.cache.get(args[0]) || message.author 
    message.edit(`⛧ __**${client.db.name}**__ ⛧\nFerme ta gueule fdp ! 👆\n\nhttps://media.giphy.com/media/b0xoqnrqoZXDa/giphy.gif`)
  }
}