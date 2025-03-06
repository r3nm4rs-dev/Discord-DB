const { RichPresence } = require('djs-selfbot-v13')

const fs = require('fs')

module.exports = {
  name: "ready",
  once: true,
  run: async (client) => {
    await client.sleep(1000)
    if (client.db.rpc === true){
      const r = new RichPresence()
      if (client.db.rpcname) r.setName(client.db.rpcname)
      if (client.db.appid) r.setApplicationId(client.db.appid)
      if (client.db.rpcdetails) r.setDetails(client.db.rpcdetails)
      if (client.db.rpcstate) r.setState(client.db.rpcstate)
      if (client.db.rpctype) r.setType(client.db.rpctype)
      if (client.db.rpctype === "STREAMING") r.setURL(client.db.twitch)
      if (!isNaN(client.db.rpcpartymax) && client.db.rpcpartymin > 0) r.setParty({max: client.db.rpcpartymax, current: client.db.rpcpartymin})
      if (client.db.rpctimestamp) r.setStartTimestamp(Date.now())
      if (client.db.rpclargeimage) r.setAssetsLargeImage(client.db.rpclargeimage)
      if (client.db.rpclargeimagetxt) r.setAssetsLargeText(client.db.rpclargeimagetxt)
      if (client.db.rpcsmallimage) r.setAssetsSmallImage(client.db.rpcsmallimage)
      if (client.db.rpcsmallimagetxt) r.setAssetsSmallText(client.db.rpcsmallimagetxt)
      if (client.db.rpcbuttontext && client.db.rpcbuttonlink) r.addButton(client.db.rpcbuttontext, client.db.rpcbuttonlink)
      if (client.db.rpcbuttontext2 && client.db.rpcbuttonlink2) r.addButton(client.db.rpcbuttontext2, client.db.rpcbuttonlink2)
      client.user.setActivity(r) 
    }
  }
}