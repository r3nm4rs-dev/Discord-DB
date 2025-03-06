const Discord = require('discord.js');

module.exports = {
    name: "set_vouch_role",
    description: 'Set the vouch role',
    options: [
        {
            name: 'role',
            description: 'The role to set as the vouch role',
            type: 'ROLE',
            required: true
        }
    ],
    run: async (client, interaction) => {
        await interaction.deferReply({ ephermeral: true });

        const role = interaction.options.getRole('role');

        if (!interaction.channel.permissionsFor(interaction.member).has('ADMINISTRATOR')) {
            return await interaction.editReply({
                content: 'You do not have permissions to use this command',
                ephemeral: true
            });
        }
        
        await client.db.set(`vouch_role`, role.id);
        const Embed = new Discord.MessageEmbed()
            .setTitle('Vouch Role')
            .setDescription(`Vouch Role has been set to ${role}`)
            .setColor("#56089e");
        
        await interaction.editReply({
            embeds: [Embed],
            ephemeral: true
        });
    }
};