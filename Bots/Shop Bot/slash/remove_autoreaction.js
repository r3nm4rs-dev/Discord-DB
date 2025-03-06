const Discord = require('discord.js');

module.exports = {
    name: "remove_autoreaction",
    description: 'Remove the auto reaction feature',
    options: [
        {
            name: 'channel',
            description: 'The channel to remove the auto reaction from',
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
        await client.db.set(`autoreaction_${channel.id}`, null);
        const embed = new Discord.MessageEmbed()
            .setDescription(`Auto Reaction has been removed from ${channel}`)
            .setColor("#56089e");
        await interaction.editReply({
            embeds: [embed],
            ephemeral: true
        });
    }
};