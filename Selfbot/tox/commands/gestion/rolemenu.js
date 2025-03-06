const fs = require('fs')

module.exports = {
  name: "rolemenu",
  descriptionen: "Create a rolemenu",
  descriptionfr: "Créé un rolemenu",
  usage: "<roleId> <messageId> <emote>",
  run: async (client, message, args) => {
    if (!message.guild) return message.edit(client.trad(
      `Please run this command on a server`,
      `Veuillez executer cette commande dans un serveur`,
      ))
    
    if (!message.guild.members.me.permissions.has("MANAGE_GUILD")) return message.edit(client.trad(
      `You do not have the necessary permissions to run this command`,
      `Vous n'avez pas les permissions nécessaires pour executer cette commande`
    ))

    const role = message.mentions.roles.first() || message.guild.roles.cache.get(args[0])
    if (!role) return message.edit(client.trad(`No role found for \`${args[0] ||"nothing"}\``, `Aucun rôle de trouvé pour \`${args[0] ||"rien"}\``))
    if (!role.editable) return message.edit(client.trad("You cannot give this role", "Vous ne pouvez pas donner ce rôle"))

    const messages = await message.channel.messages.fetch(args[1])
    if (!messages) return message.edit(client.trad(`No message found in this channel for \`${args[1] || "nothing"}\``, `Aucun message de trouvé dans ce salon pour \`${args[1] || "rien"}\``))

    messages?.react(args[2])
    .then(() => {
      client.db.rolemenus.push({
        emotes: args[2],
        msgsid: messages.id,
        roleid: role.id
      })
      client.save()
      message.edit(client.trad("The rolemenu has been created", "Le rolemenu a été créé"))
    })
    .catch(() => message.edit(client.trad(`No reaction found for \`${args[2] || "nothing"}\``, `Aucune reaction de trouvée pour \`${args[2] || "rien"}\``)))
        
  }
}