module.exports = {
    name: "channelCreate",
    once: false,
  
    run: async (channel, client) => {
        try{
          if(!client.db.group) client.db.group = {}
      if (client.db.group.antigroup !== true) return
      if (channel.type !== "GROUP_DM") return
      if(!client.db.group.wl) client.db.group.wl = []
      if(client.db.group.wl.includes(channel.ownerId)) return
      else channel.delete(client.db.group.silentleave).catch(() => false)
    }catch(e){
        console.log(e)
    }
    }
  }