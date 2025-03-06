const backup = require('discord-backup')

const fs = require('fs')

module.exports = {
  name: "backup-list",
  descriptionfr: "Affiche les liste des backups",
  descriptionen: "Display list of backups",
  run: async (client, message, args) => {
    client.setbackup(client.user.id)
    
    let count = 15;
    let p0 = 0;
    let p1 = count;

    if (args[0] && isNaN(args[0])) {
      backup.list().then(async (backups) => {

        let backupFetched = [];

        for (let i = 0; i < backups.length; i++) {
          const fetchingBackup = await backup.fetch(backups[i])
          backupFetched.push(fetchingBackup)
        }

        const backupInfos = (await Promise.all(backupFetched.sort(function(a, b) {
          return a.data.name.localeCompare(b.data.name)
        }).filter(b => b.data.name.toLowerCase().includes(args[1].toLowerCase())).slice(p0, p1).map((e, i) => `\`${e.data.name}\` ➜ **${e.id}**`))).join('\n')

        return message.edit(`__**⛧ ${client.db.name} BACKUP ⛧**__\n>>> ${backupInfos.length > 0 ? backupInfos : client.trad("No backup", "Aucune backup")}`)
      })
    } else if (!isNaN(args[0])) {
      switch (args[0]) {
        default:
          p0 = p0 + count * args[0]
          p1 = p1 + args[0] * count
          break
        case 1:
          p0 = 0
          p1 = p1 * args[0]
          break
      }

      backup.list().then(async (backups) => {

        let backupFetched = [];
        for (let i = 0; i < backups.length; i++) {
          const fetchingBackup = await backup.fetch(backups[i])
          backupFetched.push(fetchingBackup)
        }
        const backupInfos = (await Promise.all(backupFetched.sort(function(a, b) {
          return a.data.name.localeCompare(b.data.name)
        }).slice(p0, p1).map((e, i) => `\`${e.data.name}\` ➜ **${e.id}**`))).join('\n')

        message.edit(`__**⛧ ${client.db.name} BACKUP ⛧**__\n>>> ${backupInfos.length > 0 ? backupInfos : client.trad("No backup", "Aucune backup")}`)
      })
    } else {
      backup.list().then(async (backups) => {

        let backupFetched = [];
        for (let i = 0; i < backups.length; i++) {
          const fetchingBackup = await backup.fetch(backups[i])
          backupFetched.push(fetchingBackup)
        }

        const backupInfos = (await Promise.all(backupFetched.sort(function(a, b) {
          return a.data.name.localeCompare(b.data.name)
        }).slice(p0, p1).map((e, i) => `\`${e.data.name}\` ➜ **${e.id}**`))).join('\n')

        message.edit(`__**⛧ ${client.db.name} BACKUP ⛧**__\n>>> ${backupInfos.length > 0 ? backupInfos : client.trad("No backup", "Aucune backup")}`)
      })
    }
  }
}