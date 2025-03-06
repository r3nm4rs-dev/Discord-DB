const backup = require('discord-backup')

const fs = require('fs')

module.exports = {
  name: "backup-info",
  descriptionfr: "Affiche les informations d'une backup",
  descriptionen: "Display informations from a backup",
  usage: "<backupId>",
  run: async (client, message, args) => {
    client.setbackup(client.user.id)
    
    backup.fetch(args[0])
    .then((bkp) =>
      message.edit(client.trad(
`__**⛧ ${client.db.name} BACKUP ⛧**__
>>> \`Server\` ➜ **${bkp.data.name}**
\`Server ID\` ➜ **${bkp.data.guildID}**
\`Icon of the server\` ➜ **${bkp.data.iconURL ? bkp.data.iconURL : "No Icon"} **
\`Banner of the server\` ➜ **${bkp.data.bannerURL ? bkp.data.bannerURL : "No Banner"} **
\`Splash of the server\` ➜ **${bkp.data.splashURL ? bkp.data.splashURL : "No Splash"} **
\`File size\` ➜ **${bkp.size}kb**
\`Created\` ➜ **<t:${Math.round(bkp.data.createdTimestamp / 1000)}:R>**`,
`__**⛧ ${client.db.name} BACKUP ⛧**__
>>> \`Serveur\` ➜ **${bkp.data.name}**
\`Serveur ID\` ➜ **${bkp.data.guildID}**
\`Icon du Serveur\` ➜ **${bkp.data.iconURL ? bkp.data.iconURL : "Aucune Icon"} **
\`Bannière du serveur\` ➜ **${bkp.data.bannerURL ? bkp.data.bannerURL : "Aucune Bannière"} **
\`Bannière d'Invitation\` ➜ **${bkp.data.splashURL ? bkp.data.splashURL : "Aucune Bannière"} **
\`Taille du fichier\` ➜ **${bkp.size}kb**
\`Créé\` ➜ **<t:${Math.round(bkp.data.createdTimestamp / 1000)}:R>**`,
    )))
    .catch(() => message.edit(client.trad(`No backup found for the id: \`${args[0] || "nothing"}\``, `Aucune backup de trouvée pour l'id: \`${args[0] || "rien"}\``)))
  }
}