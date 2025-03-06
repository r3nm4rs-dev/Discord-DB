const fs = require('fs')

module.exports = {
  name: "gsetboost",
  descriptionfr: "Active ou désactive la barre des boosts",
  descriptionen: "Enable or disable the boost bar",
  run: async (client, message, args) => {
    if (!message.guild) return message.edit(client.trad(
      `Please run this command on a server`,
      `Veuillez executer cette commande dans un serveur`,
      ))
    
    if (!message.guild.members.me.permissions.has("MANAGE_GUILD")) return message.edit(client.trad(
      `You do not have the necessary permissions to run this command`,
      `Vous n'avez pas les permissions nécessaires pour executer cette commande`,
      
    ))

    if (args[0] !== "on" && args[0] !== "off") return message.edit(client.trad("Veuillez préciser `on` ou `off`", "Missing parameter: `on` or `off`"))
    message.guild.setPremiumProgressBarEnabled(args[1] === "on" ? true : false)
    message.edit(client.trad(
      `The server boost bar has been ${args[1] === "on" ? "enable" : "disables"}`,
      `La barre des boosts du serveur a été ${args[1] === "on" ? "activée" : "désactivée"}`,
      
    ))
  }
}