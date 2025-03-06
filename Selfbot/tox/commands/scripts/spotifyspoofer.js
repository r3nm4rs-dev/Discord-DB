const fs = require('fs')

module.exports = {
  name: "spotifyspoofer",
  descriptionfr: "Pouvoir \"Ecouter Avec\" sans avoir spotify premium",
  descriptionen: "Allows to \"Listen Along\" without spotify premium",
  run: async (client, message, args) => {
    message.edit(`⛧ __**${client.db.name}**__ ⛧\n\`\`\`js\n(webpackChunkdiscord_app.push([[''],{},e=>{m=[];for(let c in e.c)m.push(e.c[c])}]),m).find(m => m?.exports?.Z?.getAccounts).exports.Z.getAccounts().forEach((conn) => conn.type === "spotify" && (webpackChunkdiscord_app.push([[''],{},e=>{m=[];for(let c in e.c)m.push(e.c[c])}]),m).find(m => m?.exports?.Z?.isDispatching).exports.Z.dispatch({type: "SPOTIFY_PROFILE_UPDATE", accountId: conn.id, isPremium: true}))\`\`\``)
  }
}