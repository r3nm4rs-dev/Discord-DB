const Discord = require('discord.js-selfbot-v13')

module.exports = {
    name: "multistatus",
    description: "Gestion des multistatus du bot",
    run: async (client, message, args) => {
        try {
            if(!client.db.multistatus) client.db.multistatus = {}
            if(!client.db.multistatus.texts) client.db.multistatus.texts = []
            if(!client.db.multistatus.emojis) client.db.multistatus.emojis = []
            if (!args[0]) {
                let title = client.db.nitro === true ? '<a:diamond_black:1276441229394968607>' : '`💎`';
                let arrow = client.db.nitro === true ? ' <:arrow:1274251907002667038> ' : '・';
                
                const hlp = client.db.lang === "fr" ?
                `» **__Help Multi-Status__** ${title}\n\n***Ajouter un nouveau texte***${arrow}\`${client.db.prefix}multistatus add <emoji> <texte>\`\n***Supprimer un texte***${arrow}\`${client.db.prefix}multistatus remove <numéro>\`\n\n***Effacer tous les multistatus***${arrow}\`${client.db.prefix}multistatus clear\`\n***Afficher la liste des multistatus***${arrow}\`${client.db.prefix}multistatus list\`\n\n***Démarrer le multistatus***${arrow}\`${client.db.prefix}multistatus start\`\n***Arrêter le multistatus***${arrow}\`${client.db.prefix}multistatus stop\`` 
                :
                `» **__Help Multi-Status__** ${title}\n\n***Add a new status***${arrow}\`${client.db.prefix}multistatus add <emoji> <text>\`\n***Delete a status***${arrow}\`${client.db.prefix}multistatus remove <number>\`\n\n***Clear all multistatuses***${arrow}\`${client.db.prefix}multistatus clear\`\n***Show the list of multistatuses***${arrow}\`${client.db.prefix}multistatus list\`\n\n***Start the multistatus***${arrow}\`${client.db.prefix}multistatus start\`\n***Stop the multistatus***${arrow}\`${client.db.prefix}multistatus stop\``;
                
                message.edit(hlp);                
                return
            }

            switch (args[0]) {
                case "list":
    if (client.db.multistatus.texts && client.db.multistatus.texts.length > 0) {
        const title = client.db.lang === "fr" ? "***Liste des Multistatus***" : "***Multistatus List***"
        const list = client.db.multistatus.texts.map((text, index) => {
            const emoji = client.db.multistatus.emojis[index] || '' 
            return `***${index + 1}. ${emoji.trim()} ${text.trim()}***` 
        }).join("\n")
        message.edit(title + "\n" + list)
    } else {
        message.edit(client.db.lang === "fr" ? "***Il n'y a aucun multistatus enregistré***" : "***There are no multistatus registered***")
    }
    break

                

                case "add":
                    const emojiToAdd = args[1]
                    const textToAdd = args.slice(2).join(" ")
                    if (!emojiToAdd || !textToAdd) {
                        message.edit(client.db.lang === "fr" ? "***Veuillez fournir un emoji et un texte à ajouter***" : "***Please provide an emoji and text to add***")
                        return
                    }
                    if (!client.db.multistatus.texts) client.db.multistatus.texts = []
                    if(client.db.nitro === true) client.db.multistatus.emojis.push(emojiToAdd)
                    client.db.multistatus.texts.push(textToAdd)
                    client.save(client, client.db)
                    message.edit(client.db.lang === "fr" ? `***Le texte \`${emojiToAdd} ${textToAdd}\` a été ajouté aux multistatus***` : `***The text \`${emojiToAdd} ${textToAdd}\` has been added to multistatus***`)
                    break

                case "remove":
                    const indexToDelete = parseInt(args[1], 10)
                    if (isNaN(indexToDelete) || indexToDelete < 1 || indexToDelete > client.db.multistatus.texts.length) {
                        message.edit(client.db.lang === "fr" ? "***Veuillez fournir un numéro valide de multistatus à supprimer***" : "***Please provide a valid multistatus number to delete***")
                        return
                    }
                    const removedText = client.db.multistatus.texts.splice(indexToDelete - 1, 1)[0]
                    client.db.multistatus.emojis.splice(indexToDelete - 1, 1)
                    client.save(client, client.db)
                    message.edit(client.db.lang === "fr" ? `***Le texte \`${removedText}\` a été supprimé des multistatus***` : `***The text \`${removedText}\` has been deleted from multistatus***`)
                    break

                case "clear":
                    client.db.multistatus.texts = []
                    client.db.multistatus.emojis = []
                    client.save(client, client.db)
                    message.edit(client.db.lang === "fr" ? "***Tous les multistatus ont été effacés***" : "***All multistatus have been cleared***")
                    break

                case "start":
                    if (!client.multistatusInterval) {
                        client.db.multistatus.m = true
                        if(!client.db.multistatus.interval) client.db.multistatus.interval = 12000
                        client.multistatusInterval = setInterval(updateStatus, client.db.multistatus.interval)
                        client.save(client, client.db)
                        message.edit(client.db.lang === "fr" ? "***Les multistatus ont été démarrés***" : "***Multistatus have been started***")
                    } else {
                        message.edit(client.db.lang === "fr" ? "***Les multistatus sont déjà en cours***" : "***Multistatus are already running***")
                    }
                    break

                case "stop":
                    if (client.multistatusInterval) {
                        clearInterval(client.multistatusInterval)
                        client.multistatusInterval = null
                        client.db.multistatus.m = false
                        client.save(client, client.db)
                        message.edit(client.db.lang === "fr" ? "***Les multistatus ont été arrêtés***" : "***Multistatus have been stopped***")
                    } else {
                        message.edit(client.db.lang === "fr" ? "***Les multistatus ne sont pas en cours***" : "***Multistatus are not running***")
                    }
                    break

                default:
                    break
            }

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

            updateStatus()
            setInterval(updateStatus, client.db.multistatus.interval)
        } catch (e) {
            console.log(e)
        }
    }
}