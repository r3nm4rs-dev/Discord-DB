const backup = require('discord-backup')

const fs = require('fs')

module.exports = {
  name: "backup-delete",
  descriptionfr: "Supprime une backup",
  descriptionen: "Delete a backup",
  usage: "<backupId>",
  run: async (client, message, args) => {
    client.setbackup(client.user.id)
    
    backup.remove(args[0])
    .then(() => message.edit(client.trad(
      `The backup with the id \`${args[0]}\` has beed deleted (irreversible action)`,
      `La backup avec comme id \`${args[0]}\` a été supprimée (action irréversible)`
    )))
    .catch(() => message.edit(client.trad(
      `No backup found for \`${args[0] || "nothing"}\``,
      `Aucune backup de trouvée pour \`${args[0] || "rien"}\``
    )))
}
}