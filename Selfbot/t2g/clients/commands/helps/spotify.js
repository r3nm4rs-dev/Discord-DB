const Discord = require('discord.js-selfbot-v13')

module.exports = {
    name: "spotify",
    run: async(client, message, args) => {
        if(!client.db.spotify) client.db.spotify = {}
        let title = client.db.nitro === true ? '<:Spotify:1275208247246061682>' : '\`🎵\`'
        let arrow = client.db.nitro === true ? ' <:arrow:1274251907002667038> ' : '・'
        if(!args[0]) return message.edit(client.db.lang === 'fr' ? `» **__Help Spotify__** ${title}\n\n***Met le RPC sur on ou off***${arrow}\`${client.db.prefix}spotify on/off\`\n***Lance le RPC***${arrow}\`${client.db.prefix}spotify custom\`\n\n***Change la plateforme***${arrow}\`${client.db.prefix}configspotify platform <ps4, ps5, desktop, samsung>\`\n\n***Change les détails***${arrow}\`${client.db.prefix}configspotify details <text>\`\n***Change l'état***${arrow}\`${client.db.prefix}configspotify state <text>\`\n***Change l'album***${arrow}\`${client.db.prefix}configspotify album <text>\`\n***Change le timestamp***${arrow}\`${client.db.prefix}configspotify timestamp <number>\`\n***Change la grande image***${arrow}\`${client.db.prefix}configspotify largeimage <link>\`\n***Change la petite image***${arrow}\`${client.db.prefix}configspotify smallimage <link>\`` : `» **__Help Spotify__** ${title}\n\n***Turn the RPC on or off***${arrow}\`${client.db.prefix}spotify on/off\`\n***Launch the RPC***${arrow}\`${client.db.prefix}spotify custom\`\n\n***Change the platform of the RPC***${arrow}\`${client.db.prefix}configspotify platform <ps4, ps5, desktop, samsung>\`\n\n***Change the details***${arrow}\`${client.db.prefix}configspotify details <text>\`\n***Change the state***${arrow}\`${client.db.prefix}configspotify state <text>\`\n***Change the album***${arrow}\`${client.db.prefix}configspotify album <text>\`\n***Change the timestamp***${arrow}\`${client.db.prefix}configspotify timestamp <number>\`\n***Change the large image***${arrow}\`${client.db.prefix}configspotify largeimage <link>\`\n***Change the small image***${arrow}\`${client.db.prefix}configspotify smallimage <link>\``)
    
    if(args[0] === "custom") {
        try{
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
            else client.user.setActivity("", {
                    type: "PLAYING"
            })
            message.delete()
        }catch(e){
            console.log(e)
        }
    }
    if(args[0] === "on") {
        client.db.spotify.s = true
        client.save(client, client.db)
        message.delete()
    }
    if(args[0] === "off") {
        client.db.spotify.s = false
        client.save(client, client.db)
        message.delete()
    }
  }
}