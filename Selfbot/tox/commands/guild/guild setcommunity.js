const fs = require('fs')

module.exports = {
  name: "gsetcommunity",
  descriptionfr: "Active ou désactive la communautée",
  descriptionen: "Enable or disable the community",
  run: async (client, message, args) => {
    if (!message.guild) return message.edit(client.trad(
      `Please run this command on a server`,
      `Veuillez executer cette commande dans un serveur`,
      ))
    
    if (!message.guild.members.me.permissions.has("MANAGE_GUILD")) return message.edit(client.trad(
      `You do not have the necessary permissions to run this command`,
      `Vous n'avez pas les permissions nécessaires pour executer cette commande`
    ))

    if (args[0] !== "on" && args[0] !== "off") return message.edit(client.trad("Missing parameter: `on` or `off`", "Veuillez préciser `on` ou `off`"))
    message.guild.setCommunity(args[0] === "on" ? true : false)
    message.edit(client.trad(
      `The community bar has been ${args[0] === "on" ? "enable" : "disables"}`,
      `La communautée a été ${args[0] === "on" ? "activée" : "désactivée"}`,
    ))
  }
}