const fs = require('fs')

module.exports = {
  name: "warn",
  descriptionfr: "Avrti un membre",
  descriptionen: "Warn a member",
  run: async (client, message, args) => {
    if (!message.guild) return message.edit(client.trad(
      `Please run this command on a server`,
      `Veuillez executer cette commande dans un serveur`,
      ))
    
    if (!message.guild.members.me.permissions.has("MANAGE_MESSAGES")) return message.edit(client.trad(
      `You do not have the necessary permissions to run this command`,
      `Vous n'avez pas les permissions nécessaires pour executer cette commande`
    ))
    
    const member = message.mentions.members.first() || message.guild.members.cache.get(args[0]) || await message.guild.members.fetch(args[0]).catch(() => false)
    if (!member) return message.edit(client.trad(
      `No member found for \`${args[0] || "nothing"}\``,
      `Aucun membre de trouvé pour \`${args[0] || "rien"}\``,
    ))
    member
    .send(client.trad(
      `**YOU HAVE BEEN WARNED**\n\n\`Guild\` ➜ **${message.guild}**\n\`reason\` ➜ **${args.slice(1).join(' ') || "Not provided  "}**`,
      `**VOUS AVEZ ETE AVERTI**\n\n\`Serveur\` ➜ **${message.guild}**\n\`raison\` ➜ **${args.slice(1).join(' ') || "Non fournies"}**`,
    ))
    .then(() => message.edit(client.trad(
        `${member.username} has been **warn**`,
        `${member.username} a été **averti**`,)
      ))
      .catch(() => message.edit(client.trad(
        `${member.username} cannot be **warn**`,
        `${member.username} n'a pas pu être **averti**`,
      )));  }
}