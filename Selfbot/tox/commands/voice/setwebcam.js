const fs = require('fs')

module.exports = {
  name: "setwebcam",
  descriptionfr: "Active ou désactive la webcam vocale",
  descriptionen: "Enable or disable the voice webcam",
  usage: "<on/off>",
  run: async (client, message, args) => {
    if (!args[0] || (args[0] !== "on" && args[0] !== "off"))
      return message.edit("Paramètre manquant: `on` ou `off`");
    if (args[0] === "on") {
      client.db.vcselfdea = true;
      client.save();
      client.refreshVoice()
      message.edit(`Vous serez en webcam lors d'un joinvc`);
    } else {
      client.db.vcselfdea = false;
      client.save();
      client.refreshVoice()
      message.edit(`Vous ne serez pas en webcam lors d'un joinvc`);
    }
  },
};
