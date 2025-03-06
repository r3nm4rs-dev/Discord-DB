const fs = require('fs')

module.exports = {
  name: "netflix",
  descriptionfr: "Affiche une activité Netflix",
  descriptionen: "Make you play Netflix",
  run: async (client, message, args) => {
    client.db.rpc = true
    client.db.rpcname = "Netflix"
    client.db.rpcdetails = `${args.slice(0).join(' ') || null}`
    client.db.rpcstate = `E1:S1 ${client.db.name}`
    client.db.rpctimestamp = true
    client.db.rpclargeimage = "https://cdn.discordapp.com/attachments/1112323981484236810/1112718619424604271/926541896573153281.png"
    client.db.rpclargeimagetext = null
    client.db.rpcsmallimage = "https://cdn.discordapp.com/attachments/1112323981484236810/1112718619642712135/926541821293764658.png"
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

    message.edit(client.trad(`You're now watching \`${args.slice(0).join(' ') || "nothing"}\` on **Netflix**`, `Vous regardez maintenant \`${args.slice(0).join(' ') || "rien"}\` sur **Netflix**`))
}
}