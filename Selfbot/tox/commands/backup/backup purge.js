const backup = require('discord-backup')

const fs = require('fs')

module.exports = {
  name: "backup-purge",
  descriptionfr: "Supprime toutes les backups",
  descriptionen: "Delete all backups",
  run: async (client, message, args) => {
    client.setbackup(client.user.id)
    
    const list = await backup.list()
    message.edit(client.trad(`__**⛧ ${client.db.name} BACKUP ⛧**__
    >>> **Do you really wanna delete \`${list.length}\` backups ?
    Type \`${client.db.prefix}confirm\` for continue**`.replaceAll("    ", ""),
    
    `__**⛧ ${client.db.name} BACKUP ⛧**__
    >>> **Veux tu vraiment supprimer \`${list.length}\` backups ?
    Ecrit \`${client.db.prefix}confirmer\` pour continuer**`.replaceAll("    ", "")))
    
    await message.channel.awaitMessages({filter: m => m.author.id === message.author.id, time: 1000 * 60, max:1, errors: ["time"]})
    .then((c) => {
        if (c.first().content === `${client.db.prefix}confirm` || c.first().content === `${client.db.prefix}confirmer`){
          c.first().edit(client.trad(`\`${list.length}\` Backups are delete !!`, `\`${list.length}\` Backups supprimées !!`))
          message.delete().catch(() => false)
          list.map(b => backup.remove(b.id))
        }
        else {
            c.first().delete().catch(() => false)
            message.edit(client.trad("you have not confirmed the deletion", "Tu n'as pas confirmé la suppression")).then(m => setTimeout(() => m.delete().catch(() => false), 5000))
        }
    })
    .catch(() => message.edit(client.trad("you have not confirmed the deletion", "Tu n'as pas confirmé la suppression")).then(m => setTimeout(() => m.delete().catch(() => false), 5000)))

  }
}