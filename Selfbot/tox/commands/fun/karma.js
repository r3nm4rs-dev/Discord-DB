const fs = require('fs')

module.exports = {
  name: "karma",
  descriptionfr: "oh le Karma",
  descriptionen: "oh the Karma",
  usage: "[user]",
  run: async (client, message, args) => {
    const user = message.mentions.users.first() || client.users.cache.get(args[0]) || message.author 
    message.edit(`⛧ __**${client.db.name}**__ ⛧\n**${client.trad(`Bah listen to ${user.username} you made Karmaed`, `Bah écoute ${user.username} tu t'es fais Karmaed`)}**\n\nhttps://cdn.discordapp.com/attachments/602163438390738957/603946294888759316/tumblr_mns4ojjGJb1rzkceno1_500.gif`)
  }
}