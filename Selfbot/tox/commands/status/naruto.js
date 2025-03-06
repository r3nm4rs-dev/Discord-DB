const fs = require('fs')

module.exports = {
    name: "naruto",
    descriptionfr: "Affiche une activité naruto",
    descriptionen: "Make you play naruto",
    run: async (client, message, args) => {
      client.db.rpc = true
      client.db.rpcname = "Naruto"
      client.db.rpcdetails = null
      client.db.rpcstate = null
      client.db.rpclargeimage = "https://cdn.discordapp.com/attachments/1148064948057018493/1198585373832515614/ccf3bc48abde9bff32afd840a747db10b1e234f4r1-630-630v2_uhq.jpg?ex=65bf709d&is=65acfb9d&hm=3a4556d83a2a4bd2c6c487fa656ae2a1e9bd0aeb48d4ff9e6dec9ffce9c6aae7&"
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
  
      message.edit(client.trad(`You're now playing to **naruto**`, `Vous jouez maintenant à **naruto**`))
    }
  }