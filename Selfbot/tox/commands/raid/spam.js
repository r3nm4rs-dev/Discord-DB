const fs = require('fs')

module.exports = {
  name: "spam",
  descriptionfr: "Spam un salon",
  descriptionen: "Spam a channel",
  usage: "<text/stop>",
  run: async (client, message, args) => {
    if (!args[0]) return message.edit(client.trad("Please provide a message to send", "Veuillez préciser un message à envoyer"))
    if (args[0] === "stop" && !args[1]){
      clearInterval(client.msgspammer)
      message.edit(client.trad("The spam is stop", "Le spam a été arrêté"))  
    }
    else {
      message.edit(args.join(' '))
      client.msgspammer = setInterval(() => message.channel.send(args.join(' ')).catch(() => false), 1000);  
    }
  }
}