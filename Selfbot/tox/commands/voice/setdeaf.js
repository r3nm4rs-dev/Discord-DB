const fs = require('fs')

module.exports = {
  name: "setdeaf",
  descriptionfr: "Active ou désactive le mute casque lors d'un joinvc",
  descriptionen: "Enable or disable the deaf when joinvc",
  usage: "<on/off>",
  run: async (client, message, args) => {
    if (!args[0] || args[0] !== "on" && args[0] !== "off") return message.edit("Paramètre manquant: `on` ou `off`")
    if (args[0] === "on"){
      client.db.vcselfdea = true
      client.save()
      client.refreshVoice()
      message.edit(`Vous serez mute casque lors d'un joinvc`)
    }
    else{
      client.db.vcselfdea = false
      client.save()
      client.refreshVoice()
      message.edit(`Vous ne serez pas mute casque lors d'un joinvc`)
    }

  }
}