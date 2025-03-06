const fs = require('fs')

module.exports = {
  name: "money",
  descriptionfr: "[̲̅$̲̅(̲̅ιοο̲̅)̲̅$̲̅]",
  descriptionen: "[̲̅$̲̅(̲̅ιοο̲̅)̲̅$̲̅]",
  usage: "",
  run: async (client, message, args) => {
    message.delete().catch(() => false)
    message.channel.send("[̲̅$̲̅(̲̅ιοο̲̅)̲̅$̲̅]")
  }
}