const fs = require('fs')

module.exports = {
  name: "idc",
  descriptionfr: "╭∩╮（︶︿︶）╭∩╮",
  descriptionen: "╭∩╮（︶︿︶）╭∩╮",
  usage: "",
  run: async (client, message, args) => {
    message.delete().catch(() => false)
    message.channel.send("╭∩╮（︶︿︶）╭∩╮")
  }
}