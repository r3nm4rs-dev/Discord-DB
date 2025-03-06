const fs = require('fs')

module.exports = {
  name: "setstream",
  descriptionfr: "Active ou désactive le stream vocale",
  descriptionen: "Enable or disable the voice stream",
  usage: "<on/off>",
  run: async (client, message, args) => {
    if (!args[0] || (args[0] !== "on" && args[0] !== "off"))
      return message.edit("Paramètre manquant: `on` ou `off`");
    if (args[0] === "on") {
      client.db.streaming = true;
      client.save();
      client.refreshVoice()
      message.edit(`Vous serez en stream lors d'un joinvc`);
    } else {
      client.db.streaming = false;
      client.save();
      client.refreshVoice()
      message.edit(`Vous ne serez pas en stream lors d'un joinvc`);
    }
  },
};
