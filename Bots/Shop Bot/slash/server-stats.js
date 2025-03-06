const Discord = require('discord.js');
const fetchAll = require('discord-fetch-all');

module.exports = {
    name: "server-stats",
    description: 'Get the server stats',
    run: async (client, interaction) => {
        await interaction.deferReply();
        const guild = interaction.guild;
        await guild.members.fetch()
        const vouch_channel_id = await client.db.get(`vouch_channel`);
      let vouch_count = 0;
        if (vouch_channel_id !== null) {
            const vouch_channel = guild.channels.cache.get(vouch_channel_id);
            const allMessages = await fetchAll.messages(vouch_channel);
            vouch_count = allMessages.length;
        }
        const embed = new Discord.MessageEmbed()
            .setTitle(`${guild.name} Stats`)
            .setColor("#56089e")
            .setThumbnail(guild.iconURL({ dynamic: true }))
            .addFields(
                { name: 'Total Members', value: `${guild.members.cache.size}` },
                { name: 'Humans', value: `${guild.members.cache.filter(member => !member.user.bot).size}` },
                { name: 'Bots', value: `${guild.members.cache.filter(member => member.user.bot).size}` },
                { name: 'Owner', value: `<@${guild.ownerId}>` },
                { name: 'Server Created', value: guild.createdAt.toDateString() },
                { name: 'Server Age', value: `${Math.floor((Date.now() - guild.createdAt) / 86400000)} days` }
            )
            .setFooter({
                text: `${vouch_count !== 0 ? `vouches: ${vouch_count}` : `set vouch channel with /set-vouch-channel`}`,
            })
        await interaction.editReply({
            embeds: [embed]
        });
    }
};