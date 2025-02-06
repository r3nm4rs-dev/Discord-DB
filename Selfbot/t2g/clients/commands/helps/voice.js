module.exports = {
    name: "voice",
    run: async (client, message, args) => {
        if (!client.db.voice) client.db.voice = {};

        const translations = {
            fr: {
                help: `» **__Help Voice__** ${client.db.nitro === true ? '<:vocal:1275207758920290325>' : '`🎙`'}\n\n***Rejoindre un salon vocal***${client.db.nitro === true ? '<:arrow:1274251907002667038> ' : '・'}\`${client.db.prefix}voice join <vocid>\`\n***Changer le salon vocal par défaut***${client.db.nitro === true ? '<:arrow:1274251907002667038> ' : '・'}\`${client.db.prefix}voice auto <vocid>\`\n\n***Se mute ou se démute***${client.db.nitro === true ? '<:arrow:1274251907002667038> ' : '・'}\`${client.db.prefix}voice mute <on/off>\`\n***Se mettre en sourdine ou enlever***${client.db.nitro === true ? '<:arrow:1274251907002667038> ' : '・'}\`${client.db.prefix}voice deaf <on/off>\`\n\n***Activer ou désactiver la caméra***${client.db.nitro === true ? '<:arrow:1274251907002667038> ' : '・'}\`${client.db.prefix}voice cam <on/off>\`\n***Activer ou désactiver le stream***${client.db.nitro === true ? '<:arrow:1274251907002667038> ' : '・'}\`${client.db.prefix}voice stream <on/off>\``,
                id: "***Veuillez fournir un ID de salon vocal.***",
                good: (channelId) => `***Rejoint le salon vocal : <#${channelId}>***`,
                nochannel: "***Salon vocal non trouvé.***",
                autogood: (channelId) => `***Salon vocal de démarrage défini sur : <#${channelId}>***`,
                onoff: "***Veuillez spécifier 'on' ou 'off'.***",
                mutegood: (state) => `***Mute vocal défini sur : ${state ? 'on' : 'off'}***`,
                deafengood: (state) => `***Sourdine vocale définie sur : ${state ? 'on' : 'off'}***`,
                camgood: (state) => `***Caméra vocale définie sur : ${state ? 'on' : 'off'}***`,
                streamgood: (state) => `***Stream vocal défini sur : ${state ? 'on' : 'off'}***`,
            },
            en: {
                help: `» **__Help Voice__** ${client.db.nitro === true ? '<:vocal:1275207758920290325>' : '`🎙`'}\n***Join a voice channel***${client.db.nitro === true ? '<:arrow:1274251907002667038> ' : '・'}\`${client.db.prefix}voice join <vocid>\`\n***Change the default voice channel***${client.db.nitro === true ? '<:arrow:1274251907002667038> ' : '・'}\`${client.db.prefix}voice auto <vocid>\`\n***Mute or unmute yourself***${client.db.nitro === true ? '<:arrow:1274251907002667038> ' : '・'}\`${client.db.prefix}voice mute <on/off>\`\n***Deafen or undeafen yourself***${client.db.nitro === true ? '<:arrow:1274251907002667038> ' : '・'}\`${client.db.prefix}voice deaf <on/off>\`\n***Turn your camera on or off***${client.db.nitro === true ? '<:arrow:1274251907002667038> ' : '・'}\`${client.db.prefix}voice cam <on/off>\`\n***Turn your stream on or off***${client.db.nitro === true ? '<:arrow:1274251907002667038> ' : '・'}\`${client.db.prefix}voice stream <on/off>\``,
                id: "***Please provide a voice channel ID.***",
                good: (channelId) => `***Joined voice channel: <#${channelId}>***`,
                nochannel: "***Voice channel not found.***",
                autogood: (channelId) => `***Startup voice channel set to: <#${channelId}>***`,
                onoff: "***Please specify 'on' or 'off'.***",
                mutegood: (state) => `***Voice mute set to: ${state ? 'on' : 'off'}***`,
                deafengood: (state) => `***Voice deafen set to: ${state ? 'on' : 'off'}***`,
                camgood: (state) => `***Voice camera set to: ${state ? 'on' : 'off'}***`,
                streamgood: (state) => `***Voice stream set to: ${state ? 'on' : 'off'}***`,
            },
        };
    
        const lang = client.db.lang || "en";
        const t = translations[lang];

        if (!args[0]) {
            const hlp = t.help;
            message.edit(hlp);
            return;
        }

        const command = args[0].toLowerCase();

        switch (command) {
            case "join":
                if (!args[1]) return message.edit(t.id);
                const channel = client.channels.cache.get(args[1]);
                if (channel && channel.isVoice()) {
                    client.ws.broadcast({
                        op: 4,
                        d: {
                            guild_id: channel.guild.id,
                            channel_id: channel.id,
                            self_mute: client.db.voice.mute,
                            self_deaf: client.db.voice.deaf,
                        },
                    });
                    message.edit(t.good(channel.id));
                } else {
                    message.edit(t.nochannel);
                }
                break;

            case "auto":
                if (!args[1]) return message.edit(t.id);
                client.db.voice.auto = args[1];
                await client.save(client, client.db);
                message.edit(t.autogood(args[1]));
                break;

            case "mute":
                if (!args[1]) return message.edit(t.onoff);
                client.db.voice.mute = args[1].toLowerCase() === "on";
                await client.save(client, client.db);
                message.edit(t.mutegood(client.db.voice.mute));
                await updateVoiceState(client, client.db);
                break;

            case "deaf":
                if (!args[1]) return message.edit(t.onoff);
                client.db.voice.deaf = args[1].toLowerCase() === "on";
                await client.save(client, client.db);
                message.edit(t.deafengood(client.db.voice.deaf));
                await updateVoiceState(client, client.db);
                break;

            case "cam":
                if (!args[1]) return message.edit(t.onoff);
                client.db.voice.cam = args[1].toLowerCase() === "on";
                await client.save(client, client.db);
                message.edit(t.camgood(client.db.voice.cam));
                await updateVoiceState(client, client.db);
                break;

            case "stream":
                if (!args[1]) return message.edit(t.onoff);
                client.db.voice.stream = args[1].toLowerCase() === "on";
                await client.save(client, client.db);
                message.edit(t.streamgood(client.db.voice.stream));

                const voiceChannel = client.channels.cache.get(client.db.voice.auto);
                if (voiceChannel) {
                    if (client.db.voice.stream) {
                        await client.sleep(1337);
                        client.ws.broadcast({
                            op: 18,
                            d: {
                                type: "guild",
                                guild_id: voiceChannel.guild.id,
                                channel_id: voiceChannel.id,
                                preferred_region: "japan",
                            },
                        });
                    } else {
                        await client.sleep(1337);
                        let streamKey;
                        if (["DM", "GROUP_DM"].includes(voiceChannel.type) && !voiceChannel.guild) {
                            streamKey = `call:${voiceChannel.id}:${client.user?.id}`;
                        } else {
                            streamKey = `guild:${voiceChannel.guild.id}:${voiceChannel.id}:${client.user?.id}`;
                        }
                        client.ws.broadcast({
                            op: 19,
                            d: {
                                stream_key: streamKey,
                            },
                        });
                    }
                } else {
                    message.edit(t.nochannel);
                }
                break;

            default:
                message.edit(t.help);
                break;
        }
    },
};

async function updateVoiceState(client, db) {
    const channel = client.channels.cache.get(db.voice.auto);
    if (channel) {
        await client.ws.broadcast({
            op: 4,
            d: {
                guild_id: channel.guild.id,
                channel_id: channel.id,
                self_mute: db.voice.mute,
                self_deaf: db.voice.deaf,
                self_video: db.voice.cam,
            },
        });
    }
}
