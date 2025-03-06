const request = require('request')

const fs = require('fs')

module.exports = {
  name: "find",
  descriptionfr: "Cherche si un utilisateur est en vocal",
  descriptionen: "Search if a user is in voice channel",
  usage: "[stop]",
  run: async (client, message, args) => {
    let u = message.mentions.users.first() || client.users.cache.get(args[0])
    if (!u) try {
      u = await client.users.fetch(args[0])
    }
    catch { return message.edit(client.trad(`No user found for \`${args[0] || "nothing"}\``, `Aucun utilisateur de trouvé pour \`${args[0] || "rien"}\``)) }
    
    let channels = []

    for (const guild of client.guilds.cache.map(g => g)){
      const c = guild.members.cache.get(u.id)?.voice.channel
      if (c) channels.push(client.trad(`> <@${u.id}> is actually connected in the voice channel ${c.name} (<#${c.id}>)`, `> <@${u.id}> est actuellement connecté dans le vocal ${c.name} (<#${c.id}>)`)); 
    }

    if (channels.length > 0) return message.edit(`⛧ __**${client.db.name}**__ ⛧\n${channels.map(c => c).join('\n')}`)
    else return message.edit(client.trad("The user is not in voice channel", "L'utilisateur n'est pas en vocal"))

  }
}