const { Permissions } = require("djs-selfbot-v13")

const fs = require('fs')

module.exports = {
  name: "logs-setup",
  descriptionfr: "Setup le panel de logs",
  descriptionen: "Setup the logs panel",
  usage: "[server ID]",
  run: async (client, message, args) => {
    const guild = client.guilds.cache.get(args[0]) || message.guild
    if (!guild) return message.edit(client.trad('Please use this command in guild', 'Veuillez utiliser cette commande dans un serveur'))
    
    if (!guild.members.me.permissions.has("MANAGE_CHANNELS")) return message.edit(client.trad(`You do not have the necessary permissions to run this command`, `Vous n'avez pas les permissions nécessaires pour executer cette commande`))
    if (!guild.members.me.permissions.has("MANAGE_WEBHOOKS")) return message.edit(client.trad(`You do not have the necessary permissions to run this command`, `Vous n'avez pas les permissions nécessaires pour executer cette commande`))
    
    const cat = await message.guild.channels.create(client.db.name, {type: "GUILD_CATEGORY", position: 0, permissionOverwrites: [{id: message.author.id, allow: [Permissions.FLAGS.VIEW_CHANNEL]}, {id: message.guild.id, deny: [Permissions.FLAGS.VIEW_CHANNEL]}]})
    const channel = await message.guild.channels.create(client.db.name + " logger", {type: "GUILD_TEXT", permissionOverwrites: [{id: message.author.id, allow: [Permissions.FLAGS.VIEW_CHANNEL]}, {id: message.guild.id, deny: [Permissions.FLAGS.VIEW_CHANNEL]}]})
    channel.setParent(cat.id)

    const webhook = await channel.createWebhook(`${client.db.name} | LOGGER`, {avatar: "https://i.imgur.com/w00MfXD.jpg"})

    client.db.logger = webhook.url
    client.db.ologger = true
    client.save()
    message.edit(client.trad("The setup has been finished", "Le setup a été fini"))
  }
}