const d = require('djs-selfbot-v13')
const c = require('oceanic.js')
const fs = require('fs')

module.exports = {
  name: "checktoken",
  descriptionfr: "Vérifie si un token marche",
  descriptionen: "Check if a token work",
  usage: "<token>",
  run: async (client, message, args) => {
    if (!args[0]) return message.edit(client.trad("Please provide a token", "Veuillez entrer un token"))
    const test = await check (args[0])
    
    if (!test) return message.edit(client.trad(`⛧ __**${client.db.name}**__ ⛧\n\`STATUS\` ➜ \`🔴\``, `⛧ __**${client.db.name}**__ ⛧\n\`STATUS\` ➜ \`🔴`))
    else return message.edit(client.trad(`⛧ __**${client.db.name}**__ ⛧\n\`STATUS\` ➜ \`🟢`, `⛧ __**${client.db.name}**__ ⛧\n\`STATUS\` ➜ \`🟢`))
  }
}

const check = async token => {
  try{
    const nclient = new d.Client({checkUpdate: false})
    await nclient.login(token)
    nclient.on('ready', () => nclient.destroy())
    return true
  }
  catch{ 
    try{
      const nclient = new c.Client({gateway: {intents: []}, auth: `Bot ${token}`})
      await nclient.connect()
      nclient.on('ready', () => nclient.disconnect(false))
      return true
    }
    catch{ return false }
  }
}