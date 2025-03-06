const fs = require('fs')

module.exports = {
  name: "invitebot",
  descriptionfr: "Envoie un lien pour inviter un bot",
  descriptionen: "Send the link for invite a bot",
  usage: "<botid>",
  run: async (client, message, args) => {
    let user = message.mentions.users.first() || await client.users.fetch(args[0]).catch(() => false);

    if (!user || !user.bot) return message.edit("Veuillez envoyer mentionner un bot")
    message.edit(`${client.trad("Invitation of", "Invitation de")} ${user.username}\nhttps://discord.com/api/oauth2/authorize?client_id=${user.id}&permissions=8&scope=bot`)
}
}