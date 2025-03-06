const fs = require('fs')

module.exports = {
  name: "setmute",
  descriptionfr: "Active ou désactive le mute lors d'un joinvc",
  descriptionen: "Enable or disable the mute when joinvc",
  usage: "<on/off>",
  run: async (client, message, args) => {
    if (!args[0] || args[0] !== "on" && args[0] !== "off") return message.edit("Paramètre manquant: `on` ou `off`")
    if (args[0] === "on"){
      client.db.vcselfmut = true
      client.save()
      client.refreshVoice()
      message.edit(`Vous serez mute lors d'un joinvc`)
    }
    else{
      client.db.vcselfmut = false
      client.save()
      client.refreshVoice()
      message.edit(`Vous ne serez pas mute lors d'un joinvc`)
    }

  }
}