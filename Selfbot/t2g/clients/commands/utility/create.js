const fs = require('node:fs')
const { Util } = require('discord.js-selfbot-v13')
module.exports = {
    name: "create",
    description: "",
    run: async (client, message, args) => {

        if(!message.guild) return message.delete().catch(e=> null);
        if(!message.guild.members.me.permissions.has('MANAGE_EMOJIS_AND_STICKERS')) return message.delete().catch(e=> null);
        let emojis = args.join(' ').split(' ');
        const validEmojis = emojis.filter(e => Util.parseEmoji(e).name && Util.parseEmoji(e).id);
        if (!validEmojis.length) return message.delete().catch(e=> null);
        const createdEmojis = [];
        for(const emoji of validEmojis) {
            const { name, id, animated } = Util.parseEmoji(emoji);
            const img = `https://cdn.discordapp.com/emojis/${id}.${animated ? 'gif' : 'png'}`;
            const newEmoji = await message.guild.emojis.create(img, name).catch(e=> null);
            createdEmojis.push(newEmoji);
        }
        message.delete().catch(e=> null);
        if (createdEmojis.length) {
            message.channel.send(createdEmojis.map(e => e.toString()).join(' '));
        } else {
            message.channel.send('***No emojis were created**.*');
        }
    }
}