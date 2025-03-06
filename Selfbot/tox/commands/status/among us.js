const fs = require('fs')

module.exports = {
  name: "amongus",
  descriptionfr: "Affiche une activité among us",
  descriptionen: "Make you play among us",
  run: async (client, message, args) => {
    client.db.rpc = true
    client.db.rpcname = "Among Us"
    client.db.rpcdetails = null
    client.db.rpcstate = null
    client.db.rpclargeimage = "https://cdn.discordapp.com/attachments/1148064948057018493/1198583925946204240/w0lmb8i7odo51.png?ex=65bf6f44&is=65acfa44&hm=f170923c49087633c67aad85729c1be06e7be27a5b7e7ea2205fd879bdbbd930&"
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

    message.edit(client.trad(`You're now playing to **Among Us**`, `Vous jouez maintenant à **Among Us**`))
  }
}