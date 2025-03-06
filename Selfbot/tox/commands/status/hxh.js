const fs = require('fs')

module.exports = {
    name: "hxh",
    descriptionfr: "Affiche une activité hunter x hunter",
    descriptionen: "Make you play hunter x hunter",
    run: async (client, message, args) => {
      client.db.rpc = true
      client.db.rpcname = "Hunter X Hunter"
      client.db.rpcdetails = null
      client.db.rpcstate = null
      client.db.rpclargeimage = "https://cdn.discordapp.com/attachments/1148064948057018493/1198585938822041621/c6881a58d7d976f2a40ec0a7646b35c0.jpg?ex=65bf7124&is=65acfc24&hm=a32fdcfa0be20afcf59f1ce6e3bf6f4da646575d84f557fec986066ec328b4ad&"
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
  
      message.edit(client.trad(`You're now playing to **Hunter X Hunter**`, `Vous jouez maintenant à **Hunter X Hunter**`))
    }
  }