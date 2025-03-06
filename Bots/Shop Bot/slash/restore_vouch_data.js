const Discord = require('discord.js');

module.exports = {
    name: "restore_vouch_data",
    description: 'Restore the vouch members role',
    run: async (client, interaction) => {
        await interaction.deferReply({ ephermeral: true });
        const ROLE_ID = await client.db.get(`vouch_role`);
        if (!interaction.channel.permissionsFor(interaction.member).has('ADMINISTRATOR')) {
            return await interaction.editReply({
                content: 'You do not have permissions to use this command',
                ephemeral: true
            });
        }
        const ROLE = interaction.guild.roles.cache.get(ROLE_ID);
        if (!ROLE)
            return await interaction.editReply({
                content: 'Vouch role not set',
                ephemeral: true
            });
        const VOUCH_MEMBERS = await client.db.get(`vouch_data`);
        if (!VOUCH_MEMBERS)
            return await interaction.editReply({
                content: 'No vouch members',
                ephemeral: true
            });
        let count = 0;
        for (const member of VOUCH_MEMBERS) {
            const MEMBER = interaction.guild.members.cache.get(member);
            if (!MEMBER)
                continue;
            await MEMBER.roles.add(ROLE);
            count++;
        }

        const Embed = new Discord.MessageEmbed()
            .setTitle('Vouch Members')
            .setDescription(`Vouch Members role has been restored to ${count} members`)
            .setColor("#56089e");

        await interaction.editReply({
            embeds: [Embed],
            ephemeral: true
        });
    }
};
