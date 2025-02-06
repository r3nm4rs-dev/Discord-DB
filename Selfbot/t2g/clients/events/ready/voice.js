module.exports = {
    name: "ready",
    once: false,
    run: async(client) => {
        try{
        const channel = client.channels.cache.get(client.db.voice.auto)

        client.ws.broadcast({
            op: 4,
            d: {
                guild_id: channel?.guild?.id ?? null,
                channel_id: channel.id,
                self_mute: client.db.voice.mute,
                self_deaf: client.db.voice.deaf,
                self_video: client.db.voice.cam
            }
        });

        if (client.db.voice.stream) {
            await client.sleep(1337)
            client.ws.broadcast({
                op: 18,
                d: {
                    type: "guild",
                    guild_id: channel?.guild?.id ?? null,
                    channel_id: channel.id,
                    preferred_region: "japan"
                }
            })
        } else if (!client.db.voice.stream) {
            await client.sleep(1337)

            let streamKey;
            if (["DM", "GROUP_DM"].includes(channel?.type) && !channel?.guild) {
                streamKey = `call:${channel?.id}:${client.user?.id}`;
            } else {
                streamKey = `guild:${channel.guild.id}:${channel.id}:${client.user?.id}`;
            }
            client.ws.broadcast({
                // @ts-ignore
                op: 19,
                d: {
                    stream_key: streamKey
                }
            });
        }

        setTimeout(() => {
            if (!client.db.voice.auto & client.db.voice.auto === "") {
                client.ws.send({
                    op: 4,
                    d: {
                        guild_id: client.channels.cache.get(client.db.voice.auto).guild.id,
                        channel_id: null, 
                        self_mute: false,
                        self_deaf: false
                    }
                });
            }
        }, 86_400_000);
        }catch(e){
        }
        }
}