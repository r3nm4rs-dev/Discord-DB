module.exports = {
    name: "logs",
    description: "Set up logging channels and webhooks for the server",
    run: async (client, message, args) => {
        if(!client.db.logs) client.db.logs = {}
        let title = client.db.nitro === true ? '<a:aw_letter:1276084313980403763>' : '\`🗒️\`'
        let arrow = client.db.nitro === true ? ' <:arrow:1274251907002667038> ' : '・'
        if (!args[0]) {
            const response = client.db.lang === "fr"
    ? `**__Help Logs__** ${title}\n\n***Activer ou désactiver les logs***${arrow}\`${client.db.prefix}logs on/off\`\n\n***Configurer les logs***${arrow}\`${client.db.prefix}logs setup [server_id]\`\n***Changer la couleur***${arrow}\`${client.db.prefix}logs color [hex]\`\n\n***Ajouter des logs personnalisés***${arrow}\`${client.db.prefix}logs custom add [word]\`\n***Retirer des logs personnalisés***${arrow}\`${client.db.prefix}logs custom remove [word]\`\n***Effacer la liste des logs personnalisés***${arrow}\`${client.db.prefix}logs custom clear\`\n***Lister les logs personnalisés***${arrow}\`${client.db.prefix}logs custom list\``
    : `» **__Help Logs__** ${title}\n\n***Enable or disable logs***${arrow}\`${client.db.prefix}logs on/off\`\n\n***Set up the logs***${arrow}\`${client.db.prefix}logs setup [server_id]\`\n***Change the color***${arrow}\`${client.db.prefix}logs color [hex]\`\n\n***Add custom logs***${arrow}\`${client.db.prefix}logs custom add [word]\`\n***Remove custom logs***${arrow}\`${client.db.prefix}logs custom remove [word]\`\n***Clear the custom logs list***${arrow}\`${client.db.prefix}logs custom clear\`\n***List custom logs***${arrow}\`${client.db.prefix}logs custom list\``;

await message.edit(response);

            return;
        }

        if (args[0] === "setup") {
            if (!args[1]) {
                const response = client.db.lang === "fr"
                    ? `***Veuillez fournir un ID de serveur valide**.*`
                    : `***Please provide a valid server ID**.*`;
                await message.edit(response);
                return;
            }

            const serverId = args[1];
            const guild = client.guilds.cache.get(serverId);

            if (!guild) {
                const response = client.db.lang === "fr"
                    ? `***Serveur introuvable avec ID ${serverId}**.*`
                    : `***Server not found with ID ${serverId}**.*`;
                await message.edit(response);
                return;
            }

            const channels = [
                '💎・message・delete・logs',
                '💎・message・edit・logs',
                '💎・server・join・logs',
                '💎・server・leave・logs',
                '💎・group・logs',
                '💎・nitro・Sniper',
                '💎・custom・Logs'
            ];

            for (let channelName of channels) {
                let channel = await guild.channels.create(channelName, { type: 'text' });
                let webhook = await channel.createWebhook('Logs');

                let dataname = channelName.replace(/[^a-zA-Z0-9]/g, '');
                client.db.logs[dataname] = webhook.url;
            }
            client.db.logs.l = true
            client.save(client, client.db);
            let guild2 = await client.guilds.fetch(serverId)

            const response = client.db.lang === "fr"
                ? `***Logs installés pour le serveur \`${guild2.name}\`**.*`
                : `***Logs set up for the server \`${guild2.name}\`**.*`;
            await message.edit(response);
            return;
        }

        if (args[0] === "color") {
            if(!args[1]) {
                client.db.logs.color = "#ffffff"
                client.save(client, db)
                message.delete()
            }
            const hexColor = args[1];
            const isValidHex = /^#[0-9A-F]{6}$/i.test(hexColor);

            if (!hexColor || isValidHex) {
                client.db.logs.color = hexColor ? hexColor : "#ffffff";
                client.save(client, client.db);
                message.delete();
            } else {
                const response = client.db.lang === "fr"
                    ? `***Veuillez fournir une couleur hex valide**.*`
                    : `***Please provide a valid hex color**.*`;
                await message.edit(response);
            }
            return;
        }
        if(args[0] === "on") {
            client.db.logs.l = true
            client.save(client, client.db)
            message.delete()
        }
        if(args[0] === "off") {
            client.db.logs.l = false
            client.save(client, client.db)
            message.delete()
        }
        if(args[0] === "custom") {
            if(!client.db.logs.customword) client.db.logs.customword = []
            if (args[1] === "clear") {
                client.db.logs.customword = [];
                client.save(client, db);
                const success = client.db.lang === "fr" 
                    ? "***La liste des custom words a été vidée !***" 
                    : "***The custom word list has been cleared !***";
                await message.edit(success);
            }
            if(args[1] === "add") {
                if(!args[2]) {
                    const noargs = client.db.lang === "fr" ? "***Vous devez me fournir un word à ajouter !***" : "***You need to provide me with a word to add !***"
                    await message.edit(noargs)
                    return
                }
                if(client.db.logs.customword.includes(args[2])) {
                    const already = client.db.lang === "fr"? "***Ce word existe déjà !***" : "***This custom word already exists !***"
                    await message.edit(already)
                    return
                }
                client.db.logs.customl = true
                if(!client.db.logs.customword) client.db.logs.customword = []
                client.db.logs.customword.push(args[2])
                client.save(client, client.db)
                message.delete()
            }
            if (args[1] === "remove") {
                if (!args[2]) {
                    const noargs = client.db.lang === "fr" ? "***Vous devez me fournir un word à retirer !***" : "***You need to provide me with a word to delete !***";
                    await message.edit(noargs);
                    return;
                }
                if (!client.db.logs.customword.includes(args[2])) {
                    const notfound = client.db.lang === "fr" ? "***Ce word n'est pas dans la liste des custom word !***" : "***This word is not in the custom word list !***";
                    await message.edit(notfound);
                    return;
                }
                client.db.logs.customword = client.db.logs.customword.filter(word => word !== args[2]);
                client.save(client, client.db)
                message.delete();
            }
            if (args[1] === "list") {
                if(!client.db.logs.customword) {
                    const zero = client.db.lang === "fr" ? "***La liste des custom word est vide !***" : "***The list of custom words is empty !***"
                    message.edit(zero);
                    return
                }
                const wordList = client.db.logs.customword.join(', ');
                const listMessage = client.db.lang === "fr" ? `***Liste des custom words*** : \`${wordList}\`` : `***Custom word list*** : \`${wordList}\``;
                await message.edit(listMessage);
            }
        }
    }
};