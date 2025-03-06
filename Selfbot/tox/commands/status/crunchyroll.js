const fs = require('fs')

module.exports = {
  name: "crunchyroll",
  descriptionfr: "Affiche une activité Crunchyroll",
  descriptionen: "Make you play Crunchyroll",
  run: async (client, message, args) => {
    client.db.rpc = true
    client.db.rpcname = "Crunchyroll"
    client.db.rpcdetails = `${args.join(' ') || client.db.name}`
    client.db.rpcstate = null
    client.db.rpctimestamp = null
    client.db.rpclargeimage = "https://cdn.discordapp.com/attachments/1112323981484236810/1112746697832022016/417bVUqe0pL.png"
    client.db.rpclargeimagetext = null
    client.db.rpcsmallimage = null
    client.db.rpcsmallimagetext = null
    client.db.rpctype = "WATCHING"
    client.db.rpcpartymin = 0
    client.db.rpcpartymax = 0
    client.db.rpcbuttontext = null
    client.db.rpcbuttonlink = null
    client.db.rpcbuttontext2 = null
    client.db.rpcbuttonlink2 = null
    client.save()
    client.rpc()

    message.edit(client.trad(`You're now watching \`${args.join(' ') || client.db.name}\` on **Crunchyroll**`, `Vous regarder maintenant \`${args.join(' ') || client.db.name}\` sur **Crunchyroll**`))
  }
}