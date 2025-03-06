const fs = require('fs')

module.exports = {
  name: "disney+",
  descriptionfr: "Affiche une activité Disney+",
  descriptionen: "Make you play Disney+",
  run: async (client, message, args) => {
    client.db.rpc = true
    client.db.rpcname = "Disney +"
    client.db.rpcdetails = `${args.slice(0).join(' ') || client.db.name}`
    client.db.rpcstate = "On Disney+"
    client.db.rpctimestamp = true
    client.db.rpclargeimage = "https://cdn.discordapp.com/attachments/1112323981484236810/1112718620200550512/de5d2aj-baf1c3c6-2eb4-48c2-a6d6-3e0f904c1e24.png"
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

    message.edit(client.trad(`You're now watching \`${args.join(' ') || client.db.name}\` on **Disney +**`, `Vous regarder maintenant \`${args.join(' ') || client.db.name}\` sur **Disney +**`))
  }
}