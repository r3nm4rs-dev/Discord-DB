const { CommandInteraction, EmbedBuilder, ApplicationCommandOptionType } = require("pwss");

module.exports = {
    name: "reset-user",
    description: "Reset a user's premium subscription and profile",
    options: [
        {
            name: "user",
            type: ApplicationCommandOptionType.User,
            description: "The user to reset",
            required: true
        }
    ],
    run: async (client, interaction) => {
        const targetUser = interaction.options.getUser("user");

        // Check if the command issuer has the appropriate permissions
        if (!client.config.team.owner.includes(interaction.user.id) && !client.config.team.devs.includes(interaction.user.id)) {
            return interaction.reply({ content: 'You are not allowed to use this command!', ephemeral: true });
        }

        // Fetch premium keys from the database
        let db = client.db.get(`hidden_premium`) || [];
        const userIndex = db.findIndex(k => k.claimedBy === targetUser.id);

        if (userIndex > -1) {
            // Remove the user's premium status
            db[userIndex].claimedBy = null;
            db[userIndex].claimedAt = null;
            db[userIndex].expiration = null;

            client.db.set(`hidden_premium`, db);
        }

        // Optionally, remove other user-specific data here
        client.db.delete(`user_${targetUser.id}`); // Replace with your actual user data structure key

        const embed = new EmbedBuilder()
            .setTitle('User Reset Successfully')
            .setColor(0xFF0000) // Red color
            .setDescription(`User **${targetUser.username}** has been reset successfully.`)
            .setTimestamp()
            .setFooter({
                text: client.footer.text,
                iconURL: client.footer.icon_url
            })
            .setThumbnail(client.thumbnail.icon_url)
            .setAuthor({
                name: interaction.user.username,
                iconURL: interaction.user.displayAvatarURL()
            });

        await interaction.reply({ embeds: [embed], ephemeral: true });
    }
};
