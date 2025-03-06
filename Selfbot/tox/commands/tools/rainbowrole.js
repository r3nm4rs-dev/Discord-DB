const fs = require('fs')

module.exports = {
  name: "rainbowrole",
  descriptionfr: "Lancer ou arrêter un rôle arc en ciel",
  descriptionen: "Start or stop a rainbow role",
  usage: "<roleID/stop>",
  run: async (client, message, args) => {
    if (args[0] === "stop"){
      message.edit(client.trad("The rainbow role has been stopped", "Le rainbow rôle a été arrêté"))
      clearInterval(client.rbow)
    }
    if (!message.guild) return message.edit(client.language("Please executte this command in a guild", "Utilisez cette commande dans un serveur"))
    
    const r = message.guild.roles.cache.get(args[0])
    if (!r.editable) return message.edit(client.trad("You can't edit the color of this role", "Tu ne peux pas modifier la couleur de ce rôle"))

    const c = ["FF0D00","FF3D00","FF4F00","FF5F00","FF6C00","FF7800","FF8300","FF8C00","FF9500","FF9E00","FFA500","FFAD00","FFB400","FFBB00","FFC200","FFC900","FFCF00","FFD600","FFDD00","FFE400","FFEB00","FFF200","FFFA00","F7FE00","E5FB00","D5F800","C6F500","B7F200","A8F000","98ED00","87EA00","74E600","5DE100","41DB00","1DD300","00C618","00BB3F","00B358","00AC6B","00A67C","009E8E","028E9B","06799F","0969A2","0C5DA5","0E51A7","1047A9","133CAC","1531AE","1924B1","1F1AB2","2A17B1","3415B0","3C13AF","4512AE","4E10AE","560EAD","600CAC","6A0AAB","7608AA","8506A9","9702A7","AD009F","BC008D","C7007D","D0006E","D8005F","DF004F","E7003E","EF002A","F80012"]
    let i = 0

    client.rbow = setInterval(() => {
      i === c.length ? i = 0 : i++
      if (r.editable) r.edit({color: c[i]})
    }, 1000 * 60 * 3);
  }
}