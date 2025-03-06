const Discord = require('discord.js');

module.exports = {
    name: 'set_slot_category',
    description: 'Set the category for slots',
    options: [
        {
            name: 'category',
            description: 'The category to set',
            type: 'CHANNEL',
            channel_types: ['4'],
            required: true
        },
        {
            name: 'member_role',
            description: 'The role to give members',
            type: 'ROLE',
            required: true
        }
    ],
    run: async (client, interaction) => {
        await interaction.deferReply({ ephemeral: true });

        const category = interaction.options.getChannel('category');

        if (!interaction.channel.permissionsFor(interaction.member).has('ADMINISTRATOR')) {
            return await interaction.editReply({
                content: 'You do not have permissions to use this command',
                ephemeral: true
            });
        }

        client.db.set('slots_category', category.id);
        client.db.set('member_role', interaction.options.getRole('member_role').id);

        const embed = new Discord.MessageEmbed()
            .setColor('GREEN')
            .setDescription(`Set the category for slots to ${category} and the member role to ${interaction.options.getRole('member_role')}!`);

        await interaction.editReply({ embeds: [embed] });
    }
};