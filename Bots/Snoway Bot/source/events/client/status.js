const Discord = require("discord.js");
const Pluzio = require("../../structures/client/index");

module.exports = {
    name: "ready",
    /**
     *
     * @param {Pluzio} client
     */
    run: async (client) => {
       setInterval(async () => {
            const db = await client.db.get(`status`)
            const presenceOptions = {
                status: db?.status || 0,
                activities: [{
                    name: db?.name || "Pluzio V" + client.version + " .gg/pluzio",
                    type: db?.type || 4,
                    url: "https://twitch.tv/r3nm4rss"

                }]
            };
            client.user.setPresence(presenceOptions)

        }, 5000)
    }
};
