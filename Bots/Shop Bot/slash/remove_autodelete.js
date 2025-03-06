const Discord = require('discord.js');

module.exports = {
    name: "remove_autodelete",
    description: 'Remove the auto delete feature, Dont Use this in a Channel that has Auto Delete',
    run: async (client, interaction) => {
        await interaction.deferReply({ ephermeral: true });

        if (!interaction.channel.permissionsFor(interaction.member).has('ADMINISTRATOR')) {
            return await interaction.editReply({
                content: 'You do not have permissions to use this command',
                ephemeral: true
            });
        }
        
        await client.db.set(`autodelete`, null);
        const Embed = new Discord.MessageEmbed()
            .setTitle('Auto Delete')
            .setDescription(`Auto Delete has been removed`)
            .setColor("#56089e");
        
        await interaction.editReply({
            embeds: [Embed],
            ephemeral: true
        });
    }
};