const backup = require('discord-backup')

const fs = require('fs')

module.exports = {
    name: "backup-create",
    descriptionfr: "Crée une sauvegarde du serveur",
    descriptionen: "Create a backup of a server",
    usage: "[guildId]",
    run: async (client, message, args) => {
        const guild = client.guilds.cache.get(args[0]) || message.guild
        
        if (!guild) return message.edit(client.trad(
            `Please run this command on a server`,
            `Veuillez executer cette commande dans un serveur`,
        ))

        client.setbackup(client.user.id)

        message.edit(client.trad(
            `__**⛧ ${client.db.name} BACKUP ⛧**__
            > Guild: \`${guild.name}\`
            > Channels: \`${guild.channels.cache.size}\`
            > Roles: \`${guild.roles.cache.size}\`
            
            > **Creating the current backup...** (ETA: <t:${Math.round((Date.now() + guild.channels.cache.size * 250) / 1000)}:R>)`.replaceAll("            ", ""),
            `__**⛧ ${client.db.name} BACKUP ⛧**__
            > Serveur: \`${guild.name}\`
            > Salons: \`${guild.channels.cache.size}\`
            > Rôles: \`${guild.roles.cache.size}\`

            > **Création de la backup en cours...** (Temps estimé: <t:${Math.round((Date.now() + guild.channels.cache.size * 250) / 1000)}:R>)`.replaceAll("            ", "")
        ))
            
        const backupData = await backup.create(guild, {
            doNotBackup: ["bans", "emojis"],
            maxMessagesPerChannel: 0,
            jsonSave: true,
            jsonBeautify: true,
        })

        message.edit(client.trad(`The backup of ${guild.name} finished. Use the command \`${client.db.prefix}backup-load ${backupData.id}\``, `La backup de ${guild.name} est terminée. Utilise la commande \`${client.db.prefix}backup-load ${backupData.id}\``))
    }
  }