const fs = require('fs')

module.exports = {
  name: "ddosvoc",
  descriptionfr: "DDOS tous les salons vocaux d'un serveur",
  descriptionen: "DDOS all voice channel from a server",
  run: async (client, message, args) => {
    if (!message.guild) return message.edit(client.trad(`Please execute this command in a server`, `Veuillez executer cette commande dans un serveur`))
    if (!message.member.permissions.has("MANAGE_GUILD")) return message.edit(client.trad("You do not have permissions to run this command", "Vous n'avez pas les permissions d'executer cette commande"))
    let regions = ["russia", "india", "japan", "europe"]
    message.edit(client.trad("DDOS in progress...", "DDOS en cours..."))
    
    for (let i = 0; i < 9; i++){
      message.guild.channels.cache.filter(c => c.type === "GUILD_VOICE").forEach(c => c.setRTCRegion(regions[i]))
    }
  }
}