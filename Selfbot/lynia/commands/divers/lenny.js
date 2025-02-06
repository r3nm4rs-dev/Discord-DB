const fs = require('fs')

module.exports = {
  name: "lenny",
  descriptionfr: "( ͡° ͜ʖ ͡°)",
  descriptionen: "( ͡° ͜ʖ ͡°)",
  usage: "",
  run: async (client, message, args) => {
    message.delete().catch(() => false)
    message.channel.send("( ͡° ͜ʖ ͡°)")
  }
}