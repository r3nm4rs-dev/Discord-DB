const fs = require('fs')

module.exports = {
  name: "uptime",
  descriptionfr: "Affiche depuis quand le bot est allumé",
  descriptionen: "Shows how long the bot has been on",
  run: async (client, message, args) => {
    let totalSeconds = (client.uptime / 1000);
    let days = Math.floor(totalSeconds / 86400);
    totalSeconds %= 86400;
    let hours = Math.floor(totalSeconds / 3600);
    totalSeconds %= 3600;
    let minutes = Math.floor(totalSeconds / 60);
    let seconds = Math.floor(totalSeconds % 60);

    message.edit(`Uptime: ${days} ${client.trad("Days", "Jours")} | ${hours} ${client.trad("Hours", "Heures")} | ${minutes} ${client.trad("Minuts", "Minutes")} | ${seconds} ${client.trad('Seconds', "Secondes")}`);
  }
}