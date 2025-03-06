const fs = require('fs')

module.exports = {
  name: "photoshop",
  descriptionfr: "Affiche une activité Photoshop",
  descriptionen: "Make you play Photoshop",
  run: async (client, message, args) => {
    client.db.rpc = true
    client.db.rpcname = "Photoshop"
    client.db.rpcdetails = `Edtiting : ${args.slice(0).join(' ') || `${client.db.name}.psd`}`
    client.db.rpcstate = "On Photoshop"
    client.db.rpctimestamp = true
    client.db.rpclargeimage = "https://cdn.discordapp.com/attachments/1112323981484236810/1112718620422844497/Adobe_Photoshop_CC_icon.png"
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

    message.edit(client.trad(`You're now playing to \`${args.slice(0).join(' ') || `${client.db.name}.psd`}\` on **Photoshop**`, `Vous jouez maintenant à \`${args.slice(0).join(' ') || `${client.db.name}.psd`}\` sur **Photoshop**`))
}
}