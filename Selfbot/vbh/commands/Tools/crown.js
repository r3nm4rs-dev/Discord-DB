const { language } = require("../../fonctions")
module.exports = {
  name: "crown",
  description: "Display the info of a server",
  run: async (client, message, args, db) => {
    try{
      let guild = client.guilds.cache.get(args[0]) || await client.guilds.fetch(args[0])
      if (!guild) return message.edit(`Aucun serveur de trouvé pour \`${args[0] || "rien"}\``)

      message.edit(await language(client, `▸ __**VBH**__ ✫
> **Serveur:** \`${message.guild.name}\`
> **Propriétaire:** <@!${guild.ownerId}>
> **ID du propriétaire:** \`${guild.ownerId}\``))
    }
    catch{}
  }
}
