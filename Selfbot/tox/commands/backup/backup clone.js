const backup = require('discord-backup')

const fs = require('fs')

module.exports = {
  name: "backup-clone",
  descriptionfr: "Créé et charge une backup rapidement",
  descriptionen: "Create and load a backup quickly",
  usage: "[guildID]",
  run: async (client, message, args) => {
    const guild = client.guilds.cache.get(args[0]) || message.guild
    if (!guild) return message.edit(client.trad(
      `No guild found for \`${args[0] || "nothing"}\``,
      `Aucun serveur de trouvé pour \`${args[0] || "rien"}\``
    ))

      client.setbackup(client.user.id)

    message.delete().catch(() => false)
    const bkp = await backup.create(guild, {
      maxMessagesPerChannel: 0,
      doNotBackup: ["bans", "emojis"],
      jsonSave: false
    })

    const newguild = await client.guilds.create(client.db.name)
    backup.load(bkp.id, newguild).catch(() => false)
  }
}