const Discord = require('discord.js');
const ms = require("ms")

module.exports = {
    name: "set_autodelete",
    description: 'Purge a Amount Of Messages in a Channel Every Duration',
    options: [
        {
            name: 'channel',
            description: 'The channel to purge messages in',
            type: 'CHANNEL',
            channel_types: ['0'],
            required: true
        },
        {
            name: 'duration',
            description: 'How long the purge should last for. Example values: 1m, 1h, 1d',
            type: 'STRING',
            required: true
        },
        {
            name: 'amount',
            description: 'How many messages to purge',
            type: 'INTEGER',
            required: true
        }
    ],
    run: async (client, interaction) => {
        await interaction.deferReply({ ephermeral: true });
        const channel = interaction.options.getChannel('channel');
        const duration = interaction.options.getString('duration');
        const amount = interaction.options.getInteger('amount');

        if (!channel.permissionsFor(interaction.member).has('ADMINISTRATOR')) {
            return await interaction.editReply({
                content: 'You do not have permissions to use this command',
                ephemeral: true
            });
        }
        if (isNaN(amount)) {
            return interaction.editReply({
                content: ':x: Please select a valid amount!',
                ephemeral: true
            });
        }
        if (isNaN(ms(duration))) {
            return interaction.editReply({
                content: ':x: Please select a valid duration!',
                ephemeral: true
            });
        }
        const time = ms(duration);
        await client.db.set(`autodelete`, {
            channel: channel.id,
            duration: time,
            lastDelete: Date.now(),
            amount: parseInt(amount, 10),
            currentAmount: 0
        });
        const Embed = new Discord.MessageEmbed()
            .setTitle('Auto Delete')
            .setDescription(`Auto Delete has been set to ${channel} every ${duration} for ${amount} messages`)
            .setColor("#56089e");
        await interaction.editReply({
            embeds: [Embed],
            ephemeral: true
        });
    }
};