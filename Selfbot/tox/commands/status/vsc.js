const fs = require('fs')

module.exports = {
  name: "vsc",
  descriptionfr: "Permet de jouer a ...",
  descriptionen: "Play Visual Studio Code",
  run: async (client, message, args) => {
    client.db.rpc = true
    client.db.rpcname = "Pluzio SB"
    client.db.rpcdetails = "Pluzio Code"
    client.db.rpcstate = `Creator: ${args.slice(0).join(' ') || "By r3nm4rss"}`
    client.db.rpclargeimage = "https://cdn.discordapp.com/attachments/1316156404679049268/1318874599353749536/Sans_titre_27_20241216201946.png?ex=6763e92f&is=676297af&hm=9187b540eef691f1d5bac12aaeaa523ae6e596b26b980a232d7cd20f587e8aab&"
    client.db.rpclargeimagetext = "L2B"
    client.db.rpcsmallimage = "https://cdn.discordapp.com/attachments/1316156404679049268/1318874599353749536/Sans_titre_27_20241216201946.png?ex=6763e92f&is=676297af&hm=9187b540eef691f1d5bac12aaeaa523ae6e596b26b980a232d7cd20f587e8aab&"
    client.db.rpcsmallimagetext = "Join selfbot .gg/pluzio"
    client.db.rpctype = "STREAMING"
    client.db.rpctimestamp = true
    client.db.rpcpartymin = null,
    client.db.rpcpartymax = null,
    client.db.rpcbuttontext = "Join Selfbot Here"
    client.db.rpcbuttonlink = "https://discord.gg/pluzio"
    client.db.rpcbuttontext2 = "L2B Server"
    client.db.rpcbuttonlink2 = "https://discord.gg/pluzio"
    client.save()
    client.rpc()

    message.edit(client.trad(`You're now playing to \`${args.slice(0).join(' ') || "No workspace"}\` on **Visual Studio Code**`, `Vous streamer \`${args.slice(0).join(' ') || "Pluzio"}\` dans **Pluzio SB**`))
  }
}