const Discord = require('discord.js-selfbot-v13')

module.exports = {
    name: "rpc",
    run: async(c, m, a) => {
        if(!a[0]) {
        let title = c.db.nitro === true ? '<:rpc:1275208317953638473>' : '🎳'
        let arrow = c.db.nitro === true ? ' <:arrow:1274251907002667038> ' : '・'
        m.edit(c.db.lang === 'fr' ? `» __**Help RPC**__ ${title}\n\n***Met le RPC sur on ou off***${arrow}\`${c.db.prefix}rpc on/off\`\n***Lance le RPC***${arrow}\`${c.db.prefix}rpc custom\`\n\n***Change le type***${arrow}\`${c.db.prefix}configrpc type <type>\`\n***Change la plateforme***${arrow}\`${c.db.prefix}configrpc platform <ps4, ps5, desktop, samsung>\`\n***Change le nom***${arrow}\`${c.db.prefix}configrpc name <text>\`\n***Change le time***${arrow}\`${c.db.prefix}configrpc time <numbers> <unit>\`\n***Change les détails***${arrow}\`${c.db.prefix}configrpc details <text>\`\n***Change l'état***${arrow}\`${c.db.prefix}configrpc state <text>\`\n***Change la grande image***${arrow}\`${c.db.prefix}configrpc largeimage <link>\`\n***Change la petite image***${arrow}\`${c.db.prefix}configrpc smallimage <link>\`\n***Change l'ID de l'application***${arrow}\`${c.db.prefix}configrpc appid <id>\`\n***Change les boutons***${arrow}\`${c.db.prefix}configrpc button 1/2 <link> <text>\`` : `» **__Help RPC__** ${title}\n\n***Turn the RPC on or off***${arrow}\`${c.db.prefix}rpc on/off\`\n***Launch the RPC***${arrow}\`${c.db.prefix}rpc custom\`\n\n***Change the type of the RPC***${arrow}\`${c.db.prefix}configrpc type <type>\`\n***Change the platform of the RPC***${arrow}\`${c.db.prefix}configrpc platform <ps4, ps5, desktop, samsung>\`\n***Change the name of the RPC***${arrow}\`${c.db.prefix}configrpc name <text>\`\n***Change the time***${arrow}\`${c.db.prefix}configrpc time <numbers> <unit>\`\n***Change the details of the RPC***${arrow}\`${c.db.prefix}configrpc details <text>\`\n***Change the state of the RPC***${arrow}\`${c.db.prefix}configrpc state <text>\`\n***Change the large image of the RPC***${arrow}\`${c.db.prefix}configrpc largeimage <link>\`\n***Change the small image of the RPC***${arrow}\`${c.db.prefix}configrpc smallimage <link>\`\n***Change the application ID of the RPC***${arrow}\`${c.db.prefix}configrpc appid <id>\`\n***Change the buttons of the RPC***${arrow}\`${c.db.prefix}configrpc button 1/2 <link> <text>\``);

}
    else if(a[0] === "custom") {
        try{
        const xx = new Discord.RichPresence(c)
        if(c.db.rpc.type) xx.setType(c.db.rpc.type)
        if(c.db.rpc.platform) xx.setPlatform(c.db.rpc.platform)
        if(c.db.rpc.name) xx.setName(c.db.rpc.name)
            if(c.db.rpc.time) xx.setStartTimestamp(c.db.rpc.time)
        if(c.db.rpc.details) xx.setDetails(c.db.rpc.details)
        if(c.db.rpc.state) xx.setState(c.db.rpc.state)
        if(c.db.rpc.largeimage) xx.setAssetsLargeImage(c.db.rpc.largeimage)
        if(c.db.rpc.smallimage) xx.setAssetsSmallImage(c.db.rpc.smallimage)
        if(c.db.rpc.appid) xx.setApplicationId(c.db.rpc.appid)
        if (c.db.rpc.buttontext1 && c.db.rpc.buttonlink1) xx.addButton(c.db.rpc.buttontext1, c.db.rpc.buttonlink1)
        if (c.db.rpc.buttontext2 && c.db.rpc.buttonlink2) xx.addButton(c.db.rpc.buttontext2, c.db.rpc.buttonlink2)
        if (c.db.rpc.x === true) c.user.setPresence({ activities: [xx] })
        else c.user.setActivity("", {
            type: "PLAYING"
        })
    m.delete()
    }catch(e){
        console.log(e)
    }
}
    else if (a[0] === "on") {
        c.db.rpc.x = true
        c.save(c, c.db)
        m.delete()
    }
    else if (a[0] === "off") {
        c.db.rpc.x = false
        c.save(c, c.db)
        m.delete()
    }
    }
}