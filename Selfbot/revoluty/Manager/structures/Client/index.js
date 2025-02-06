const {Clarity} = require("./Clarity");
new Clarity({
    partials: ["CHANNEL", "GUILD_MEMBER", "MESSAGE", "REACTION", "USER"],
    intents: 3276799,
    allowedMentions: {repliedUser: false},
    restTimeOffset: 0
})

require('events').EventEmitter.defaultMaxListeners = 0;