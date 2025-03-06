const Discord = require('discord.js');
const Schema = require('../model/sticky');

module.exports = {
    name: "set_notification",
    description: 'Create A Notification in a Channel',
    options: [
        {
            name: 'channel',
            description: 'The channel to send the notification in',
            type: 'CHANNEL',
            channel_types: ['0'],
            required: true
        },
        {
            name: 'message',
            description: 'The message to send',
            type: 'STRING',
            required: true
        }
    ],
    run: async (client, interaction) => {
        await interaction.deferReply({ ephermeral: true });
        const channel = interaction.options.getChannel('channel');
        const content = interaction.options.getString('message');

        if (!channel.permissionsFor(interaction.member).has('ADMINISTRATOR')) {
            return await interaction.editReply({
                content: 'You do not have permissions to use this command',
                ephemeral: true
            });
        }
        const embed = new Discord.MessageEmbed()
            .setDescription(`${content}`)
            .setColor("#56089e");
        channel.send({ embeds: [embed] }).then(msg => {
            Schema.findOne({ Guild: interaction.guild.id, Channel: channel.id }, async (err, data) => {
                if (data) {
                    data.Channel = channel.id;
                    data.Content = content;
                    data.LastMessage = msg.id;
                    data.save();
                }
                else {
                    new Schema({
                        Guild: interaction.guild.id,
                        Channel: channel.id,
                        LastMessage: msg.id,
                        Content: content,
                    }).save();
                }
            })
        })
        await interaction.editReply({
            content: `Notification has been sent to ${channel}`,
            ephemeral: true
        });
    }
};