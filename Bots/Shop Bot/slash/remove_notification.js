const Discord = require('discord.js');
const Schema = require('../model/sticky');

module.exports = {
    name: "remove_notification",
    description: 'Removes A Notification in a Channel',
    options: [
        {
            name: 'channel',
            description: 'The channel to remove the notification from',
            type: 'CHANNEL',
            channel_types: ['0'],
            required: true
        }
    ],
    run: async (client, interaction) => {
        await interaction.deferReply({ ephermeral: true });
        const channel = interaction.options.getChannel('channel');

        if (!channel.permissionsFor(interaction.member).has('ADMINISTRATOR')) {
            return await interaction.editReply({
                content: 'You do not have permissions to use this command',
                ephemeral: true
            });
        }
        Schema.findOne(
            { Guild: interaction.guild.id, Channel: channel.id },
            async (err, data) => {
                if (!data) return;

                const lastStickyMessage = await channel.messages
                    .fetch(data.LastMessage)
                    .catch(() => { });
                if (!lastStickyMessage) return;
                await lastStickyMessage.delete({ timeout: 1000 });
            }
        )
        Schema.findOne({ Guild: interaction.guild.id, Channel: channel.id }, async (err, data) => {
            if (data) {
                Schema.findOneAndDelete({ Guild: interaction.guild.id, Channel: channel.id }).then(async () => {
                    await interaction.editReply({
                        content: `Notification has been removed from ${channel}`,
                        ephemeral: true
                    });
                })
            }
            else {
                await interaction.editReply({
                    content: `There is no notification in ${channel}`,
                    ephemeral: true
                });
            }
        })
    }
};