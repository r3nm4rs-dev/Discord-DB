const fs = require('fs')

module.exports = {
  name: "bl",
  descriptionfr: "Blacklist un utilisateur",
  descriptionen: "Blacklist a user",
  run: async (client, message, args) => {
    if (!args[0]) {
      return message.edit(`**Blacklist:**\n\n${client.db.blacklist.length > 0 ? client.db.blacklist.map(userid => `> <@${userid}>`).join('\n') : client.trad("Nobody", "Personne")}`)
    } else {
      let user = message.mentions.users.first() || client.users.cache.get(args[0])
      if (!user) try{
        user = await client.users.fetch(args[0])
      }
      catch{
        return message.edit(
          client.trad(`No user found for \`${args[0] || "nothing"}\``, `Aucun utilisateur de trouvé pour \`${args[0] || "rien"}\``)
        )
      }

      if (client.db.blacklist.includes(user.id)) return message.edit(client.trad(`${user.username} is already blacklist`, `${user.username} est déjà blacklist`))

      client.db.blacklist.push(user.id)
      client.save()

      let banned = 0
      let notban = 0

      for (const guild of client.guilds.cache.map(g => g)){
        try{
            await guild.bans.create(user.id, {reason: args[1] ? args.slice(1).join(' ') : "Aucune raison fournie"}).then(() => banned++).catch(() => notban++)
        }
        catch{ notban++ }
    }

      return message.edit(client.trad(`${user.username} has been banned from **${banned} server${banned > 1 ? "s" : ""}**.\nHe can't be banned from **${notban} server${notban > 1 ? "s" : ""}**`, `${user.username} a été banni de **${banned} serveur${banned > 1 ? "s" : ""}**.\nIl n'a pas pu être ban dans **${notban} serveur${notban > 1 ? "s" : ""}**`))
    }
  }
}