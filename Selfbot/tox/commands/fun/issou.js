const fs = require('fs')

module.exports = {
  name: "issou",
  descriptionfr: "ISSOU",
  descriptionen: "ISSOU",
  run: async (client, message, args) => {
    const issou = [
      'https://media.tenor.com/images/9df5f6ef799544b11c1171d4c873d1f4/tenor.gif',
      'https://media.tenor.com/images/bae9f9ee3bf793a0bb667d8e4ccb9883/tenor.gif',
      'https://media.tenor.com/images/6f567ef7cae93ca76de2346f28764ee9/tenor.gif',
      'https://media.tenor.com/images/3d8eb1e9c497abc46370cee9b55d682f/tenor.gif',
      'https://media.tenor.com/images/19fe7ebb05c2aceb9e68d84ee5c031a7/tenor.gif',
      'https://media.tenor.com/images/db17bbcb693788625c8228d30bc5fc42/tenor.gif',
      'https://media1.tenor.com/images/003a06f5074259c50b519056a12f6e33/tenor.gif',
      'https://media1.tenor.com/images/5e1fafda52c90acfe2499ac5061f4c99/tenor.gif',
      'https://cdn.discordapp.com/attachments/603949531700396032/603954611405062157/tenor_1.gif'
    ]

    const user = message.mentions.users.first() || client.users.cache.get(args[0]) || message.author 
    message.edit(`⛧ __**${client.db.name}**__ ⛧\n**ISSOU**\n\n${issou[Math.floor(Math.random() * issou.length)]}`)
  }
}