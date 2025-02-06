const { ShardingManager } = require('pwss')
const config = require("./structures/config/index")
const clarity = require("./structures/Client/Clarity")
const {Clarity} = require("./structures/Client/Clarity");

if (config.sharding) {
    const manager = new ShardingManager('./structures/Client/index.js', { token: config.token, respawn: true, totalShards: "auto" })
    manager.on('shardCreate', (shard) => {
        shard.on("ready", () => {
        
            console.log(`[SHARD] : ${shard.id + 1 } est prêt ! `);
        })
        shard.on("disconnect", (event) => {
            console.log(`[SHARD] : ${shard.id} est déconnecté! `);
            console.log(event);
        })
        shard.on("reconnecting", (event) => {
            console.log(`[SHARD] : ${shard.id} est en reconnection! `);
            console.log(event);
        })
        shard.on("error", (event) => {
            console.log(`[SHARD] : ${shard.id} a rencontré une erreur! `);
            console.log(event);
        })
    })
    manager.spawn({
        delay: 10000
    })
} else {
    new Clarity({
        partials: ["CHANNEL", "GUILD_MEMBER", "MESSAGE", "REACTION", "USER"],
        intents: 3276799,
        allowedMentions: {repliedUser: false},
        restTimeOffset: 0
    })

    require('events').EventEmitter.defaultMaxListeners = 0;
}
