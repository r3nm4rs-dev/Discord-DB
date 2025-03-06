const Discord = require('discord.js');

module.exports = {
    name: "set_autoreaction",
    description: 'Set the auto reaction feature',
    options: [
        {
            name: 'channel',
            description: 'The channel to send the auto reaction in',
            type: 'CHANNEL',
            channel_types: ['0'],
            required: true
        },
        {
            name: 'emoji1',
            description: 'The emoji to react with',
            type: 'STRING',
            required: true
        },
        {
            name: 'emoji2',
            description: 'The emoji to react with',
            type: 'STRING',
            required: true
        },
        {
            name: 'emoji3',
            description: 'The emoji to react with',
            type: 'STRING',
            required: true
        },
    ],
    run: async (client, interaction) => {
        await interaction.deferReply({ ephermeral: true });
        const channel = interaction.options.getChannel('channel');
        const emoji1 = interaction.options.getString('emoji1');
        const emoji2 = interaction.options.getString('emoji2');
        const emoji3 = interaction.options.getString('emoji3');

        if (!channel.permissionsFor(interaction.member).has('ADMINISTRATOR')) {
            return await interaction.editReply({
                content: 'You do not have permissions to use this command',
                ephemeral: true
            });
        }
        
        await client.db.set(`autoreaction_${channel.id}`, [emoji1, emoji2, emoji3]);
        
        const embed = new Discord.MessageEmbed()
            .setDescription(`Auto Reaction has been set in ${channel}\n\u200b\nEmojis: ${emoji1}, ${emoji2}, ${emoji3}`)
            .setColor("#56089e");
        await interaction.editReply({
            embeds: [embed],
            ephemeral: true
        });
    }
};