const fs = require('fs')

module.exports = {
    name: "rolbox",
    descriptionfr: "Affiche une activité roblox",
    descriptionen: "Make you play roblox",
    run: async (client, message, args) => {
      client.db.rpc = true
      client.db.rpcname = "Roblox"
      client.db.rpcdetails = null
      client.db.rpcstate = null
      client.db.rpclargeimage = "https://cdn.discordapp.com/attachments/1148064948057018493/1198584501719269487/Roblox_Logo_2022.jpg?ex=65bf6fcd&is=65acfacd&hm=1da70a3d462fee74ad94f610339cbe78541a7e34f4a9d113effc0d26afa3dc9f&"
      client.db.rpctimestamp = true
      client.db.rpclargeimagetext = null
      client.db.rpcsmallimage = null
      client.db.rpcsmallimagetext = null
      client.db.rpctype = "PLAYING"
      client.db.rpcpartymin = 3
      client.db.rpcpartymax = 4
      client.db.rpcbuttontext = null
      client.db.rpcbuttonlink = null
      client.db.rpcbuttontext2 = null
      client.db.rpcbuttonlink2 = null
      client.save()
      client.rpc()
  
      message.edit(client.trad(`You're now playing to **Roblox**`, `Vous jouez maintenant à **Roblox**`))
    }
  }