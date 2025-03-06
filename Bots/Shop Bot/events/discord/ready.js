const register = require('../../utils/slashsync');
module.exports = async (client) => {
    await register(client, client.register_arr.map((command) => ({
        name: command.name,
        description: command.description,
        options: command.options,
        type: 'CHAT_INPUT'
    })), {
        debug: true
    });
    // Register slash commands - ( If you are one of those people who read the codes I highly suggest ignoring this because I am very bad at what I am doing, thanks LMAO )
    console.log(`[ / | Slash Command ] - ✅ Loaded all slash commands!`)
    let invite = `https://discord.com/api/oauth2/authorize?client_id=${client.user.id}&permissions=8&scope=applications.commands%20bot`;
    const activities = [`Pluzio's Shop`];
    setInterval(async () => {
        if (client.guildsettings["serverstats_vc"]) {
            if (client.guildsettings["serverstats_vc"]["time_vc_id"]) {
                let ctime = new Date().toLocaleString('en-GB', { hour: '2-digit', minute: '2-digit', hour12: true, timeZone: 'Europe/London' })
                const ch0 = client.channels.cache.get(client.guildsettings["serverstats_vc"]["time_vc_id"])
                await ch0.edit({ name: `🕔 ServerTime : ${ctime}` }).then(e => console.log(e))
                console.log(ctime)
            }
        }
        if (client.guildsettings["serverstats_vc"]) {
            if (client.guildsettings["serverstats_vc"]["humans_vc_id"]) {
                let ch = client.channels.cache.get(client.guildsettings["serverstats_vc"]["humans_vc_id"])
                await ch.guild.members.fetch()
                await ch.edit({ name: `👥 Members : ${ch.guild.memberCount - ch.guild.members.cache.filter(member => member.user.bot).size}` })
            }
        }
        if (client.guildsettings["serverstats_vc"]) {
            if (client.guildsettings["serverstats_vc"]["bots_vc_id"]) {
                let ch1 = client.channels.cache.get(client.guildsettings["serverstats_vc"]["bots_vc_id"])
                await ch1.guild.members.fetch()
                await ch1.edit({ name: `🤖 Bots : ${ch1.guild.members.cache.filter(member => member.user.bot).size}` })
            }
        }
        if (client.guildsettings["serverstats_vc"]) {
            if (client.guildsettings["serverstats_vc"]["total_vc_id"]) {
                let ch2 = client.channels.cache.get(client.guildsettings["serverstats_vc"]["total_vc_id"])
                await ch2.edit({ name: `🌍 Total : ${ch2.guild.memberCount}` })
            }
        }
    }, 1800000)

    setInterval(() => {
        let activity = activities[Math.floor(Math.random() * activities.length)];
        client.user.setActivity(activity, { type: "WATCHING" });
    }, 20000);

    async function wipe(channel) {
        let msg_size = 100;
        while (msg_size == 100) {
            await channel.bulkDelete(100)
                .then(messages => msg_size = messages.size)
                .catch(console.error);
        }
        return
    }
    setInterval(async () => {
        const AUTO_DELETE = await client.db.get(`autodelete`);
        if (AUTO_DELETE === null) return;
        const channel = client.channels.cache.get(AUTO_DELETE.channel);
        if (AUTO_DELETE.currentAmount >= AUTO_DELETE.amount) return;
        if ((Date.now() - AUTO_DELETE.lastDelete) > AUTO_DELETE.duration) {
            await client.db.set(`autodelete`, {
                channel: AUTO_DELETE.channel,
                lastDelete: Date.now(),
                duration: AUTO_DELETE.duration,
                amount: AUTO_DELETE.amount,
                currentAmount: 0
            });
            await wipe(channel);
            channel.send("Chat Was Cleared! <:trash:1123244265477251083>")
        }
    }, 30000);

    setInterval(async () => {
        const SLOTS = await client.db.get(`slots`);
        if (Array.isArray(SLOTS) === false) return;

        SLOTS.forEach(async (slot) => {
            const slot_data = client.db.get(`slot.${slot}`);
            if (slot_data === null) return;

            const channel = client.channels.cache.get(slot);
            if (!channel) return;
            if ((Date.now() - slot_data.created_at) > slot_data.duration) {
                await client.db.delete(`slot.${slot}`);
                await client.db.set(`slots`, SLOTS.filter((s) => s !== slot));
                await channel.delete();
            }
        });
    }, 30 * 60 * 1000);
};