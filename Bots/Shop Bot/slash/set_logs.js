const Discord = require('discord.js');

module.exports = {
    name: 'set_logs',
    description: 'Set the channel for logs',
    options: [
        {
            name: 'server_logs',
            description: 'The channel to send server logs in',
            type: 'CHANNEL',
            channel_types: ['0'],
            required: true
        },
        {
            name: 'ban_logs',
            description: 'The channel to send ban logs in',
            type: 'CHANNEL',
            channel_types: ['0'],
            required: true
        },
        {
            name: 'kick_logs',
            description: 'The channel to send kick logs in',
            type: 'CHANNEL',
            channel_types: ['0'],
            required: true
        },
        {
            name: 'message_logs',
            description: 'The channel to send message logs in',
            type: 'CHANNEL',
            channel_types: ['0'],
            required: true
        },
        {
            name: 'member_logs',
            description: 'The channel to send user logs in',
            type: 'CHANNEL',
            channel_types: ['0'],
            required: true
        }
    ],
    run: async (client, interaction) => {
        await interaction.deferReply({ ephermeral: true });
        const ban_logs = interaction.options.getChannel('ban_logs');
        const kick_logs = interaction.options.getChannel('kick_logs');
        const message_logs = interaction.options.getChannel('message_logs');
        const member_logs = interaction.options.getChannel('member_logs');
        const server_logs = interaction.options.getChannel('server_logs');

        if (!interaction.channel.permissionsFor(interaction.member).has('ADMINISTRATOR')) {
            return await interaction.editReply({
                content: 'You do not have permissions to use this command',
                ephemeral: true
            });
        }

        await client.db.set(`ban_logs`, ban_logs.id);
        await client.db.set(`kick_logs`, kick_logs.id);
        await client.db.set(`message_logs`, message_logs.id);
        await client.db.set(`member_logs`, member_logs.id);
        await client.db.set(`server_logs`, server_logs.id);

        const embed = new Discord.MessageEmbed()
            .setDescription(`Logs have been set in ${ban_logs}, ${kick_logs}, ${message_logs}, ${member_logs}`)
            .setColor("#56089e");

        await interaction.editReply({
            embeds: [embed],
            ephemeral: true
        });
    }
};