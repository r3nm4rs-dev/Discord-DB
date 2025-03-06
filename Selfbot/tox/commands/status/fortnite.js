const fs = require('fs')

module.exports = {
  name: "fortnite",
  descriptionfr: "Affiche une activité Fortnite",
  descriptionen: "Make you play Fortnite",
  run: async (client, message, args) => {
    client.db.rpc = true
    client.db.rpcname = "Fortnite"
    client.db.rpcdetails = `${args.slice(0).join(' ') || "Battle Royale - Dans le salon"}`
    client.db.rpcstate = "En Section"
    client.db.rpclargeimage = "https://cdn.discordapp.com/attachments/1112323981484236810/1112718618489278545/858017743551201330.png"
    client.db.rpctimestamp = true
    client.db.rpclargeimagetext = null
    client.db.rpcsmallimage = "Palier 100"
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

    message.edit(client.trad(`You're now playing to \`${args.slice(0).join(' ') || "Battle Royale - In the lobby"}\` on **fortnite**`, `Vous jouez maintenant à \`${args.slice(0).join(' ') || "Battle Royale - Dans le salon"}\` sur **fortnite**`))
  }
}