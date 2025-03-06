const Discord = require('discord.js');

module.exports = {
    name: "set_vouch_channel",
    description: 'Set the vouch channel',
    options: [
        {
            name: 'channel',
            description: 'The channel to set as the vouch channel',
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
        
        await client.db.set(`vouch_channel`, channel.id);
        const Embed = new Discord.MessageEmbed()
            .setTitle('Vouch Channel')
            .setDescription(`Vouch Channel has been set to ${channel}`)
            .setColor("#56089e");
        
        await interaction.editReply({
            embeds: [Embed],
            ephemeral: true
        });
    }
};