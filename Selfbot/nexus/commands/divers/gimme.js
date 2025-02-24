const fs = require('fs')

module.exports = {
  name: "serious",
  descriptionfr: "༼ つ ◕_◕ ༽つ",
  descriptionen: "༼ つ ◕_◕ ༽つ",
  usage: "",
  run: async (client, message, args) => {
    message.delete().catch(() => false)
    message.channel.send("༼ つ ◕_◕ ༽つ")
  }
}