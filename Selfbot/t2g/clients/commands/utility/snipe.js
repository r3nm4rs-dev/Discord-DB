module.exports = {
    name: "snipe",
    run: async(client, message, args) => {
        const snipes = client.snipes.get(message.channel.id);
        if (!snipes || snipes.length === 0) return message.edit(`» **__Snipe__**\n> ***Number*** : \`0/0\` ${client.db.nitro === true ? `<:sniper:1275722524075888641>` : `\`🎯\``}\n> ***Number*** : \`0/0\``);

        const snipeIndex = args[0] && !isNaN(args[0]) ? parseInt(args[0], 10) - 1 : 0;
        const msg = snipes[snipeIndex];

        if (!msg) return message.edit(`» **__Snipe__** ${client.db.nitro === true ? `<:sniper:1275722524075888641>` : `\`🎯\``}\n> ***Number*** : \`0/0\``);

        message.edit(`» **__Snipe__** ${client.db.nitro === true ? `<:sniper:1275722524075888641>` : `\`🎯\``}
    > ***Author*** : \`${msg.author.tag}\`
    > ***Content*** : \`${msg.content}\`
    > ***Attachment*** : \`${msg.image}\`
    > ***Date*** : <t:${parseInt(msg.date / 1000, 10)}:R>
    > ***Number*** : \`${snipeIndex + 1}/${snipes.length}\``);
    }
}
