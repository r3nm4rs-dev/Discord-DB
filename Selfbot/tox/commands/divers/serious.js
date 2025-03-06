const fs = require('fs')

module.exports = {
  name: "serious",
  descriptionfr: "(ಠ_ಠ)",
  descriptionen: "(ಠ_ಠ)",
  usage: "",
  run: async (client, message, args) => {
    message.delete().catch(() => false)
    message.channel.send("(ಠ_ಠ)")
  }
}