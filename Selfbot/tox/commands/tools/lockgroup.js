const request = require('request')

const fs = require('fs')

module.exports = {
  name: "lockgroup",
  descriptionfr: "Vériouille ou dévérouille un groupe",
  descriptionen: "Lock or unlock a group",
  usage: "[stop]",
  run: async (client, message, args) => {
    if (message.channel.type !== "GROUP_DM") return message.edit(client.trad("Please use this command in group", "Utilisez cette commande dans un groupe"))
    if (args[0] === "stop"){
      clearInterval(client.lock)
      return message.edit(client.trad("The group will be unlocked in 3 minutes", "Le groupe sera débloqué dans 3 minutes"))
    }
    else {
      client.lock = setInterval(async () => { request(`https://discord.com/api/v9/channels/${message.channel.id}/recipients/${client.user.id}`, { "headers": { "accept": "*/*", "authorization": `${client.token}`, }, "method": "PUT", }, (err, response, body) => false) }, 350)
      message.edit(`> ***${client.db.name} GROUP LOCKER***`);
    }
  },
};