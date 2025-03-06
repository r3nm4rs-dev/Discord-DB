const { RichPresence } = require('djs-selfbot-v13')
const i = require('../../example.json')
const cron = require("node-cron");

const fs = require('fs')

module.exports = {
  name: "ready",
  once: true,
  run: async (client) => {
    console.log(`[+] `.green + "┃".red + ` ${client.user.username} est connecté`.reset)

    if (!await client.mongodb.get(`${client.user.id}_config`)) await client.mongodb.set(`${client.user.id}_config`, i)
    
    const premiums = await client.mongodb.get("premiums") || []
    client.db = await client.mongodb.get(`${client.user.id}_config`)
    client.save = async () => await client.mongodb.set(`${client.user.id}_config`, client.db)
    if (premiums.filter(c => c?.redeemedBy === client.user.id).length > 0) client.premium = true

    cron.schedule("* * * * *", async () => {
      const users = premiums.filter(c => c?.isPremium === true && c?.redeemedBy === client.user.id) || []
      if (!users?.length) return client.premium = false;
      users?.forEach(async () => {
        if (Date.now() >= premiums.filter(c => c.redeemedBy === client.user.id)[0].expiresAt) {
          const newpremium = premiums.filter(c => c.redeemedBy !== client.user.id)
          client.premium = false
          client.mongodb.set("premiums", newpremium)
        }
      });
    });
  

    client.rpc = () => {
      const r = new RichPresence()
      .setURL(client.db.twitch)
      .setName(client.db.rpcname)
      .setType(client.db.rpctype || "PLAYING")
      .setState(client.db.rpcstate)
      .setDetails(client.db.rpcdetails)
      .setAssetsLargeImage(client.db.rpclargeimage)
      .setAssetsSmallImage(client.db.rpcsmallimage)
      .setAssetsSmallText(client.db.rpcsmallimagetxt)
      .setAssetsLargeText(client.db.rpclargeimagetxt)
      if (client.db.rpctimestamp) r.setStartTimestamp(Date.now())
      if (client.db.rpcpartymax && client.db.rpcpartymin) r.setParty({max: client.db.rpcpartymax, current: client.db.rpcpartymin})
      if (client.db.rpcbuttonlink && client.db.rpcbuttontext) r.addButton(client.db.rpcbuttontext, client.db.rpcbuttonlink)
      if (client.db.rpcbuttonlink2 && client.db.rpcbuttontext2) r.addButton(client.db.rpcbuttontext2, client.db.rpcbuttonlink2)
      if (client.db.rpc !== false && client.db.rpcname) client.user.setActivity(r)
    }

    client.refreshVoice = async (channel) => {
      const { DiscordStreamClient } = await import("djs-stream-client")
      const StreamClient = new DiscordStreamClient(client);
      
      try{
        let voiceConnection = await StreamClient.joinVoiceChannel(
          client.channels.cache.get(channel ? channel : client.db.vcconnect),
          {
            selfDeaf: client.db.vcselfdea,
            selfMute: client.db.vcselfmut,
            selfVideo: client.db.vocwebcam
          }
        )
        if (client.db.streaming === true) try { await voiceConnection.createStream() } catch(e) {};
      }
      catch{}
    }

    if (client.db.vcconnect !== false) client.refreshVoice();
  }
}