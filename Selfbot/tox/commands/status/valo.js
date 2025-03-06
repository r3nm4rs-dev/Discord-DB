const fs = require('fs')

module.exports = {
  name: "valo",
  descriptionfr: "Affiche une activité Valorant",
  descriptionen: "Make you play Valorant",
  run: async (client, message, args) => {
    client.db.rpc = true
    client.db.rpcname = "Valorant"
    client.db.rpcdetails = null
    client.db.rpcstate = null
    client.db.rpclargeimage = "https://cdn.discordapp.com/attachments/1112323981484236810/1112718618279559199/RL_JEUX_DE_MERDE.png"
    client.db.rpctimestamp = null
    client.db.rpclargeimagetext = null
    client.db.rpcsmallimage = null
    client.db.rpcsmallimagetext = null
    client.db.rpctype = "PLAYING"
    client.db.rpcpartymin = null
    client.db.rpcpartymax = null
    client.db.rpcbuttontext = null
    client.db.rpcbuttonlink = null
    client.db.rpcbuttontext2 = null
    client.db.rpcbuttonlink2 = null
    client.save()
    client.rpc()

    message.edit(client.trad(`You're now playing to **Valorant**`, `Vous jouez maintenant à **Valorant**`))
}
}