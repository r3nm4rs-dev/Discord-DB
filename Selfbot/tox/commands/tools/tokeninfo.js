const d = require('djs-selfbot-v13')

const fs = require('fs')

module.exports = {
  name: "tokeninfo",
  descriptionfr: "Affiche les informations d'un token",
  descriptionen: "Display  informations from a token",
  usage: "<token>",
  run: async (client, message, args) => {
    if (!args[0]) return message.edit(client.trad("Please provide a token", "Veuillez entrer un token"))
    const test = await check (args[0])
    if (!test) return message.edit(client.trad(`⛧ __**${client.db.name}**__ ⛧\n\`STATUS\` ➜ \`🔴\``, `⛧ __**${client.db.name}**__ ⛧\n\`STATUS\` ➜ \`🔴\``))
    else return message.edit(client.trad(`⛧ __**${client.db.name}**__ ⛧\n${test.split("++")[0]}`, `⛧ __**${client.db.name}**__ ⛧\n${test.split("++")[1]}`))
  }
}

const check = async token => {
  try{
    const nclient = new d.Client({checkUpdate: false})
    await nclient.login(token)
    nclient.on('ready', () => nclient.destroy())
    return `\`Nickname\` ➜ **${nclient.user.username}**\n\`ID\` ➜ **${nclient.user.id}**\n\`Bot\` ➜ **${nclient.user.bot ? "Yes" : "No"}**\n\`Guilds\` ➜ **${nclient.guilds.cache.size}**\n\`Channels\` ➜ **${nclient .channels.cache.size}**\n\`Users\` ➜ **${nclient.users.cache.size}**\n\`Bots\` ➜ **${nclient.users.cache.filter(c => c.bot).size}**\n\`Administrator on\` ➜ **${nclient.guilds.cache.filter(m => m.members.me.permissions.has("ADMINISTRATOR")).size} guilds**\n\`Créateur de\` ➜ **${nclient.guilds.cache.filter(c => c.ownerId === nclient.user.id).size} serveurs**\n\`Emotes\` ➜ **${nclient.emojis.cache.size}**\n\`Notes\` ➜ **${nclient.user.notes.size}**\n\`E-MAIL\` ➜ **${nclient.user.emailAddress ? nclient.user.emailAddress : "No e-mail"}**\n\`Number phone\` ➜ **${nclient.user.phoneNumber ? nclient.user.phoneNumber : "No number"}**++\`Pseudo\` ➜ **${nclient.user.username}**\n\`ID\` ➜ **${nclient.user.id}**\n\`Bot\` ➜ **${nclient.user.bot ? "Oui" : "Non"}**\n\`Serveurs\` ➜ **${nclient.guilds.cache.size}**\n\`Salons\` ➜ **${nclient .channels.cache.size}**\n\`Utilisateurs\` ➜ **${nclient.users.cache.size}**\n\`Bots\` ➜ **${nclient.users.cache.filter(c => c.bot).size}**\n\`Creator of\` ➜ **${nclient.guilds.cache.filter(c => c.ownerId === nclient.user.id).size} guilds**\n\`Administrateurs sur\` ➜ **${nclient.guilds.cache.filter(m => m.members.me.permissions.has("ADMINISTRATOR")).size} serveurs**\n\`Emojis\` ➜ **${nclient.emojis.cache.size}**\n\`Notes\` ➜ **${nclient.user.notes.size}**\n\`E-MAIL\` ➜ **${nclient.user.emailAddress ? nclient.user.emailAddress : "Pas d'email"}**\n\`Numéro de téléphone\` ➜ **${nclient.user.phoneNumber ? nclient.user.phoneNumber : "Pas de numéro"}**`
  }
  catch{ return false }
}