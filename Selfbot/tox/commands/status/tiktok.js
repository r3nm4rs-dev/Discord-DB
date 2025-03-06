const fs = require('fs')

module.exports = {
  name: "tiktok",
  descriptionfr: "Affiche une activité tiktok",
  descriptionen: "Make you play tiktok",
  run: async (client, message, args) => {
    client.db.rpc = true
    client.db.rpcname = "TIKTOK"
    client.db.rpcdetails = `${args.slice(0).join(' ') || client.db.name}`
    client.db.rpcstate = "On TIKTOK"
    client.db.rpctimestamp = null
    client.db.rpclargeimage = "https://cdn.discordapp.com/attachments/1112323981484236810/1112718620645146634/889705078167048203.png"
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

    message.edit(client.trad(`You're now watching \`${args.slice(0).join(' ') || client.db.name}\` on **TikTok**`, `Vous regardez maintenant \`${args.slice(0).join(' ') || client.db.name}\` sur **TikTok**`))
}
}