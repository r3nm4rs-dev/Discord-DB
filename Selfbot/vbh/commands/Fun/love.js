const { language, savedb, loadbackup } = require("../../fonctions")
module.exports = {
    name: "love",
    description: "Send a love message",
    run: async (client, message, args, db) => {
      try{
          message.edit("🖤❤️🖤")
          message.edit("❤️🖤❤️")
          message.edit("🖤❤️🖤")
          message.edit("❤️🖤❤️")
          message.edit("🖤❤️🖤")
          message.edit(await language(client,`Je t'aime ❤️ ${message.mentions.users.first() ? message.mentions.users.first() : message.author}`,`I love you ❤️ ${message.mentions.users.first() ? message.mentions.users.first() : message.author}`))
          }
          catch{}
      }
  }