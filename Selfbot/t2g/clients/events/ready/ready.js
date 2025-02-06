const fs = require('node:fs')
const Discord = require('discord.js-selfbot-v13')

module.exports = {
    name: "ready",
    once: false,

    run: async (client) => {
        try{
        if (!fs.existsSync(`./clients/backups`)) fs.mkdirSync('./clients/backups')
            if (!fs.existsSync(`./clients/database/${client.user.id}.json`)) fs.writeFileSync(`./clients/database/${client.user.id}.json`, fs.readFileSync("./clients/database/example.json"))
            if (!fs.existsSync(`./clients/backups/${client.user.id}`)) fs.mkdirSync(`./clients/backups/${client.user.id}`)
            client.db = require(`../../database/${client.user.id}`)
            client.save = function (client, db) {
            fs.writeFile(`./clients/database/${client.user.id}.json`, JSON.stringify(db), err => {
                if (err) console.log(err);
            });
        }
        const premiumType = String(client.user.premiumType)
        client.db.nitro = ["1", "2", "3"].includes(premiumType)
        client.save(client, client.db)

        if(client.db.status) client.user.setStatus(client.db.status)
			if(!client.db.rpc.twitch) client.db.rpc.twitch = 'https://twitch.tv/b2discord'
            const xx = new Discord.RichPresence(client)
            if(client.db.rpc.type) xx.setType(client.db.rpc.type)
            if(client.db.rpc.type === 'STREAMING') xx.setURL(client.db.rpc.twitch)
            if(client.db.rpc.platform) xx.setPlatform(client.db.rpc.platform)
            if(client.db.rpc.name) xx.setName(client.db.rpc.name)
            if(client.db.rpc.details) xx.setDetails(client.db.rpc.details)
            if(client.db.rpc.state) xx.setState(client.db.rpc.state)
            if(client.db.rpc.largeimage) xx.setAssetsLargeImage(client.db.rpc.largeimage)
            if(client.db.rpc.smallimage) xx.setAssetsSmallImage(client.db.rpc.smallimage)
            if(client.db.rpc.appid) xx.setApplicationId(client.db.rpc.appid)
            if (client.db.rpc.buttontext1 && client.db.rpc.buttonlink1) xx.addButton(client.db.rpc.buttontext1, client.db.rpc.buttonlink1)
            if (client.db.rpc.buttontext2 && client.db.rpc.buttonlink2) xx.addButton(client.db.rpc.buttontext2, client.db.rpc.buttonlink2)
            if(client.db.rpc.time) xx.setStartTimestamp(client.db.rpc.time)
                
            const ss = new Discord.SpotifyRPC(client)
            if(client.db.spotify.largeimage) ss.setAssetsLargeImage(client.db.spotify.largeimage)
            if(client.db.spotify.smallimage) ss.setAssetsSmallImage(client.db.spotify.smallimage)
            if (client.db.spotify.state) ss.setState(client.db.spotify.state)
            if (client.db.spotify.details) ss.setDetails(client.db.spotify.details)
            if(client.db.spotify.album) ss.setAssetsLargeText(client.db.spotify.album)
            if(client.db.spotify.platform) ss.setPlatform(client.db.spotify.platform)
            ss.setStartTimestamp(Date.now())
            ss.setEndTimestamp(Date.now() + (client.db.spotify.timestamp || 1000 * (13 * 60 + 37)))
            if(client.db.spotify.s === true) client.user.setPresence({activities: [ss]})
            if(client.db.rpc.x === true) client.user.setPresence({ activities: [xx] })
            if(client.db.rpc.s === true & client.db.rpc.x === true) client.user.setPresence({ activities: [xx, ss] })
                function updateStatus() {
                    if (Array.isArray(client.db.multistatus.texts) && client.db.multistatus.texts.length > 0) {
                        let currentIndex = 0
                
                        function updateStatus() {
                            const xx = new Discord.RichPresence(client)
            if(client.db.rpc.type) xx.setType(client.db.rpc.type)
            if(client.db.rpc.platform) xx.setPlatform(client.db.rpc.platform)
            if(client.db.rpc.name) xx.setName(client.db.rpc.name)
            if(client.db.rpc.details) xx.setDetails(client.db.rpc.details)
            if(client.db.rpc.state) xx.setState(client.db.rpc.state)
            if(client.db.rpc.largeimage) xx.setAssetsLargeImage(client.db.rpc.largeimage)
            if(client.db.rpc.smallimage) xx.setAssetsSmallImage(client.db.rpc.smallimage)
            if(client.db.rpc.appid) xx.setApplicationId(client.db.rpc.appid)
            if (client.db.rpc.buttontext1 && client.db.rpc.buttonlink1) xx.addButton(client.db.rpc.buttontext1, client.db.rpc.buttonlink1)
            if (client.db.rpc.buttontext2 && client.db.rpc.buttonlink2) xx.addButton(client.db.rpc.buttontext2, client.db.rpc.buttonlink2)
                const ss = new Discord.SpotifyRPC(client)
            if(client.db.spotify.largeimage) ss.setAssetsLargeImage(client.db.spotify.largeimage)
            if(client.db.spotify.smallimage) ss.setAssetsSmallImage(client.db.spotify.smallimage)
            if (client.db.spotify.state) ss.setState(client.db.spotify.state)
            if (client.db.spotify.details) ss.setDetails(client.db.spotify.details)
            if(client.db.spotify.album) ss.setAssetsLargeText(client.db.spotify.album)
            if(client.db.spotify.platform) ss.setPlatform(client.db.spotify.platform)
            ss.setStartTimestamp(Date.now())
            ss.setEndTimestamp(Date.now() + (client.db.spotify.timestamp || 1000 * (13 * 60 + 37)))
                            const r = new Discord.CustomStatus(client)
                            
                            if (Array.isArray(client.db.multistatus.emojis) && client.db.multistatus.emojis.length > 0) {
                                r.setEmoji(client.db.multistatus.emojis[currentIndex % client.db.multistatus.emojis.length])
                            }
                            
                            const currentText = client.db.multistatus.texts[currentIndex]
                            
                            r.setState(currentText)
                            
                           if(client.db.rpc.x !== true && client.db.spotify.s !== true) client.user.setActivity(r)
                            if(client.db.spotify.s === true) client.user.setPresence({activities: [r, ss]})
                            if(client.db.rpc.x === true) client.user.setPresence({activities: [r, xx]})
                            currentIndex = (currentIndex + 1) % client.db.multistatus.texts.length
                        }
                    
                        updateStatus()
                    
                        setInterval(updateStatus, client.db.multistatus.interval)
                    }    
                    
                }
    
                if(client.db.multistatus.m === true) {
                updateStatus()
                setInterval(updateStatus, client.db.multistatus.interval)
    }

        console.log('\x1b[34m%s\x1b[0m', "---------------------------")
        console.log(`\x1b[31mTag : ${client.user.tag}`);
        }catch(e){
            console.log(e)
        }
    }
}