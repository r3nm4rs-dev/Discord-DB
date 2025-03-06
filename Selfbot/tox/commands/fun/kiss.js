const fs = require('fs')

module.exports = {
  name: "kiss",
  descriptionfr: "Embrasse une personne",
  descriptionen: "Kiss someone",
  usage: "[user]",
  run: async (client, message, args) => {
    const kiss = [
      "https://media.tenor.com/dn_KuOESmUYAAAAC/engage-kiss-anime-kiss.gif",
      "https://media.tenor.com/Ogthkl9rYBMAAAAC/ichigo-hiro.gif",
      "https://media.tenor.com/fiafXWajQFoAAAAC/kiss-anime.gif",
      "https://media.tenor.com/F02Ep3b2jJgAAAAC/cute-kawai.gif",
      "https://media.tenor.com/jnndDmOm5wMAAAAC/kiss.gif",
      "https://media.tenor.com/vtOmnXkckscAAAAC/kiss.gif"
      
    ]
    const user = message.mentions.users.first() || client.users.cache.get(args[0]) || message.author 
    message.edit(`⛧ __**${client.db.name}**__ ⛧\n${message.author.username} **${client.trad("Kiss you", "T'embrasses")}** ${user.username}\n\n${kiss[Math.floor(Math.random() * kiss.length)]}`)
  }
}