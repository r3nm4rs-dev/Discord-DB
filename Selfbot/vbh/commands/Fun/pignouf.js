module.exports = {
    name: "pignouf",
    description: "branlete message",
    run: async (client, message, args, db) => {
        try{
          message.edit("8====✊D")
          message.edit("8===✊=D")
          message.edit("8==✊==D")
          message.edit("8=✊===D")
          message.edit("8==✊==D")
          message.edit("8===✊=D")
          message.edit(`8====✊D💦 ${message.mentions.users.first() ? message.mentions.users.first() : message.author}`)
        }
        catch{}
    }
}