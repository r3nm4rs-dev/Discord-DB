const fs = require('fs')

module.exports = {
  name: "rl",
  descriptionfr: "Affiche une activité Rocket League",
  descriptionen: "Make you play Rocket League",
  run: async (client, message, args) => {
    client.db.rpc = true
    client.db.rpcname = "Rocket League"
    client.db.rpcdetails = null
    client.db.rpcstate = null
    client.db.rpctimestamp = null
    client.db.rpclargeimage = "https://cdn.discordapp.com/attachments/1112323981484236810/1112718627490242740/rl.png"
    client.db.rpclargeimagetext = null
    client.db.rpcsmallimage = null
    client.db.rpcsmallimagetext = null
    client.db.rpctype = "PLAYING"
    client.db.rpcpartymin = 0
    client.db.rpcpartymax = 0
    client.db.rpcbuttontext = null
    client.db.rpcbuttonlink = null
    client.db.rpcbuttontext2 = null
    client.db.rpcbuttonlink2 = null
    client.save()
    client.rpc()

    message.edit(client.trad(`You're now playing to **Rocket League**`, `Vous jouez maintenant à **Rocket League**`))
  }
}