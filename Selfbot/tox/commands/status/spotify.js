const fs = require('fs')

module.exports = {
    name: "spotify",
    descriptionfr: "Affiche une activité Spotify",
    descriptionen: "Make you play Spotify",
    run: async (client, message, args) => {
      client.db.rpc = true
      client.db.rpcname = "Spotify"
      client.db.rpcdetails = `${args.slice(0).join(' ') || client.db.name}`
      client.db.rpcstate = null
      client.db.rpctimestamp = null
      client.db.rpclargeimage = "https://cdn.discordapp.com/attachments/1148064948057018493/1198583453017448539/Spotify_logo_without_text.svg.png?ex=65bf6ed3&is=65acf9d3&hm=82759801bf6695e0509abb464ef5adb1435194177c437693dc19fcc783ab1455&"
      client.db.rpclargeimagetext = null
      client.db.rpcsmallimage = null
      client.db.rpcsmallimagetext = null
      client.db.rpctype = "LISTENING"
      client.db.rpcpartymin = 0
      client.db.rpcpartymax = 0
      client.db.rpcbuttontext = null
      client.db.rpcbuttonlink = null
      client.db.rpcbuttontext2 = null
      client.db.rpcbuttonlink2 = null
      client.save()
      client.rpc()
  
      message.edit(client.trad(`You're now listening to **Spotify**`, `Vous écoutez maintenant **Spotify**`))
    }
  }