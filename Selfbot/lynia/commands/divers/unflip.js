const fs = require('fs')

module.exports = {
  name: "gimme",
  descriptionfr: "┬──┬ ノ( ゜-゜ノ)",
  descriptionen: "┬──┬ ノ( ゜-゜ノ)",
  usage: "",
  run: async (client, message, args) => {
    message.delete().catch(() => false)
    message.channel.send("┬──┬ ノ( ゜-゜ノ)")
  }
}