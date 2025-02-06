const { CommandInteraction, PermissionsBitField, EmbedBuilder, ApplicationCommandOptionType } = require("pwss");

module.exports = {
    name: "get-profile",
    description: "Get user profile!",
    options: [ {
        name: "user",
        type: ApplicationCommandOptionType.User,
        description: "The user to get his profile",
        required: true
    }],
    run: async (client, interaction) => {
        if (!client.config.team.owner.includes(interaction.user.id) && !client.config.team.devs.includes(interaction.user.id)) {
            return interaction.reply({ content: 'You are not allowed to use this command!', ephemeral: true });
        }

        // Defer the reply to avoid interaction timeout
        await interaction.deferReply({ ephemeral: true });
        const targetUser = interaction.options.getUser("user");

        let db = await client.db.get(`revoluty_premium`) || [];
        const userIndex = db.findIndex(k => k.claimedBy === targetUser.id);
        const user = db[userIndex];
        const embed = new EmbedBuilder()
        if (user) {
            embed.setTitle(`${targetUser.username}'s Profile`)
        } else {
            embed.setTitle(`${targetUser.username}'s Profile`)
        }
        embed.setColor(user? 0xFFD700 : 0x00FF00) // Gold color for premium, green for non-premium
        embed.setThumbnail(targetUser.displayAvatarURL())
        embed.addFields(
            {name: 'GlobalName', value: targetUser.globalName},
            { name: 'Username', value: targetUser.username, inline: true },
            { name: 'User ID', value: targetUser.id, inline: true },
            { name: 'Premium Status', value: user? `Premium until: ${new Date(user.expiration).toLocaleDateString()}` : 'Not Premium', inline: false }
        )
        embed.setTimestamp()
        embed.setFooter({
            text: client.footer.text,
            iconURL: client.footer.icon_url
        });
        await interaction.editReply({ embeds: [embed] });
    }
}
