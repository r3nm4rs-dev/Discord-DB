const fs = require('fs')

module.exports = {
  name: "ipinfo",
  descriptionfr: "Récupérer les informations d'une ip",
  descriptionen: "Get info about an IP address",
  usage: "<IP>",
  run: async (client, message, args) => {
    try{
      if (!args[0]) return message.edit(client.trad("Please provide an IP address", "Veuillez me donner une adresse IP"))

      const fetch = require("node-fetch");
      const res = await fetch(`http://ip-api.com/json/${args[0]}`);
      const json = await res.json();

      if (json.status !== "success")
        return message.edit(client.trad("Invalid IP address", "Adresse IP invalide"))

        message.edit(client.trad(
            `⛧ __**${client.db.name}**__ ⛧\n\n\`IP\` ➜ ${json.query}\n\`Pays\` ➜ ${json.country}\n\`Ville\` ➜ ${json.city}\n\`Region\` ➜ ${json.regionName}\n\`Latitude\` ➜ ${json.lat}\n\`Longitude\` ➜ ${json.lon}`,
            `⛧ __**${client.db.name}**__ ⛧\n\n\`IP\` ➜ ${json.query}\n\`Pays\` ➜ ${json.country}\n\`Ville\` ➜ ${json.city}\n\`Region\` ➜ ${json.regionName}\n\`Latitude\` ➜ ${json.lat}\n\`Longitude\` ➜ ${json.lon}`
          ))
    }
    catch(e){}
  },
};