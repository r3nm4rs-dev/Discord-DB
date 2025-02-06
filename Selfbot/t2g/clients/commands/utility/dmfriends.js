const sleep = (ms) => new Promise((resolve) => setTimeout(resolve, ms));

const formatTime = (ms) => {
    const seconds = Math.floor(ms / 1000);
    const minutes = Math.floor(seconds / 60);
    const hours = Math.floor(minutes / 60);

    if (hours > 0) {
        return `${hours} hours`;
    }
    if (minutes > 0) {
        return `${minutes} minutes`;
    }
    return `${seconds} seconds`;
};

module.exports = {
    name: "dmfriends",
    description: "",
    run: async (client, message, args) => {
        try{
        let msg = args.slice(0).join(" ");
        const delay = 3000;
        const friends = [...client.relationships.friendCache.values()];
        const totalFriends = friends.length;
        const totalDelay = delay * totalFriends;
        const formattedTime = formatTime(totalDelay);

        await client.relationships.fetch();
        message.edit(`***DmFriends*** :\n***Text*** : \`${msg}\`\n***Wait ${formattedTime} to DM ${totalFriends} friends.***`);

        for (const user of friends) {
            user?.send(msg);
            await sleep(delay);
        }
    }catch(e){
    }
    }
};
