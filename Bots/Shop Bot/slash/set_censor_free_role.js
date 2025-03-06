const Discord = require('discord.js');

module.exports = {
    name: "set_censor_free_role",
    description: "Set the role that can bypass the censor",
    options: [
        {
            name: "role",
            description: "The role that can bypass the censor",
            type: "ROLE",
            required: true
        }
    ],
    run: async (client, interaction) => {
        await interaction.deferReply({ ephemeral: true });
        const role = interaction.options.getRole("role");
        const guild = interaction.guild;

        if (!interaction.channel.permissionsFor(interaction.member).has('ADMINISTRATOR')) {
            return await interaction.editReply({
                content: 'You do not have permissions to use this command',
                ephemeral: true
            });
        }

        client.db.set(`censor_free_role`, role.id);

        const embed = new Discord.MessageEmbed()
            .setTitle("Success")
            .setDescription(`The role ${role} can now bypass the censor`)
            .setColor("GREEN")
            .setTimestamp()
            .setFooter({
                text: `Requested by ${interaction.user.username}`,
                iconURL: interaction.user.displayAvatarURL()
            });

        await interaction.editReply({ embeds: [embed] });
    }
};