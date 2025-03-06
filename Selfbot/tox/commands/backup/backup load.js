const backup = require('discord-backup')
const { Message } = require('djs-selfbot-v13')

const fs = require('fs')

module.exports = {
    name: "backup-load",
    descriptionfr: "Charge une sauvegarde du serveur",
    descriptionen: "Load a backup of a server",
    usage: "<backupId>",
    run: async (client, message, args) => {
        
        if (!message.guild) return message.edit(client.trad(
            `Please run this command on a server`,
            `Veuillez executer cette commande dans un serveur`,
        ))

        if (!message.guild.members.me.permissions.has("ADMINISTRATOR")) return message.edit(client.trad(
            `You do not have the necessary permissions to run this command`,
            `Vous n'avez pas les permissions nécessaires pour executer cette commande`
          ))

        client.setbackup(client.user.id)

        backup.fetch(args[0])
        .then(async (backupData) => {
            message.edit(client.trad(`__**⛧ ${client.db.name} BACKUP ⛧**__
            > Guild: \`${backupData.data.name}\`
            > Channels: \`${backupData.data.channels.others.length + backupData.data.channels.categories.length}\`
            > Roles: \`${backupData.data.roles.length}\`
            
            > **Type \`${client.db.prefix}confirm\` for loading this backup (canceling: <t:${Math.round((Date.now() + 1000 * 60) / 1000)}:R>)**`, 
            
            `__**⛧ ${client.db.name} BACKUP ⛧**__
            > Serveur: \`${backupData.data.name}\`
            > Salons: \`${backupData.data.channels.others.length + calc(backupData.data.channels.categories.map(c => c.children.length))}\`
            > Rôles: \`${backupData.data.roles.length}\`
            
            > **Ecrit \`${client.db.prefix}confirmer\` pour charger la backup (annulation: <t:${Math.round((Date.now() + 1000 * 60) / 1000)}:R>)**`.replaceAll("            ", "")))
        
            await message.channel.awaitMessages({filter: m => m.author.id === message.author.id, time: 1000 * 60, max:1, errors: ["time"]})
            .then((c) => {
                if (c.first().content === `${client.db.prefix}confirm` || c.first().content === `${client.db.prefix}confirmer`){
                    message.delete().catch(() => false)
                    backup.load(backupData.id, message.guild)
                }
                else {
                    c.first().delete().catch(() => false)
                    message.edit(client.trad("You didn't confirm the loading", "Tu n'as pas confirmé le chargement"))
                }
            })
            .catch(() => message.edit(client.trad("You didn't confirm the loading", "Tu n'as pas confirmé le chargement")).then(m => setTimeout(() => m.delete().catch(() => false), 3000)))
        })
        .catch(() => {
            message.edit(client.trad(`No backup found for the id: \`${args[0] || "nothing"}\``, `Aucune backup de trouvée pour l'id: \`${args[0] || "rien"}\``))
        })

    }
  }

  function calc(tableau) {
    const somme = tableau.reduce((acc, nombre) => acc + nombre, 0);
    return somme;
}