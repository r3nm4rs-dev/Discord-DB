const Discord = require('discord.js');

module.exports = {
    name: 'set_embed_role',
    description: 'Set the role that can use embeds',
    options: [
        {
            name: 'role',
            description: 'The role to set',
            type: 'ROLE',
            required: true
        }
    ],
    run: async (client, interaction) => {
        await interaction.deferReply({ ephemeral: true });

        const role = interaction.options.getRole('role');

        if (!interaction.channel.permissionsFor(interaction.member).has('ADMINISTRATOR')) {
            return interaction.editReply({ content: 'You do not have permissions to use this command', ephemeral: true });
        }

        client.db.set('embed_role', role.id);

        interaction.editReply({ content: `The embed role has been set to ${role}` });
    }
};