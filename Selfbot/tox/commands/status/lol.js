const fs = require('fs')

module.exports = {
  name: "lol",
  descriptionfr: "Affiche une activité League of Legends",
  descriptionen: "Make you play League of Legends",
  run: async (client, message, args) => {
    client.db.rpc = true
    client.db.rpcname = "League of Legends"
    client.db.rpcdetails = `${args.slice(0).join(' ') || "Faille de L'invocateur (Classé)"}`
    client.db.rpcstate = `Dans le Lobby`
    client.db.rpclargeimage = "https://media.discordapp.net/attachments/1112323981484236810/1112353992597573772/920476458860826724.png"
    client.db.rpctimestamp = null
    client.db.rpclargeimagetext = null
    client.db.rpcsmallimage = null
    client.db.rpcsmallimagetext = null
    client.db.rpctype = "PLAYING"
    client.db.rpcpartymin = 1
    client.db.rpcpartymax = 5
    client.db.rpcbuttontext = null
    client.db.rpcbuttonlink = null
    client.db.rpcbuttontext2 = null
    client.db.rpcbuttonlink2 = null
    client.save()
    client.rpc()

    message.edit(client.trad(`You're now playing to \`${args.slice(0).join(' ') || "Summoner's Rift (Ranked)"}\` on **League of Legends**`, `Vous jouez maintenant à \`${args.slice(0).join(' ') || "Faille de L'invocateur (Classé)"}\` sur **League of Legends**`))
  }
}