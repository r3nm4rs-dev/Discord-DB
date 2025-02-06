const { CommandInteraction, EmbedBuilder, ApplicationCommandOptionType } = require("pwss");

module.exports = {
    name: "profile",
    description: "Check your profile info",
    run: async (client, interaction) => {
        // Fetch user info from the database
        const userId = interaction.user.id;
        const userProfile = client.db.get(`user_${userId}`) || {}; // Replace with your actual user data structure

        // Check if the user has a premium key
        let db = client.db.get(`hidden_premium`) || [];
        const premiumStatus = db.find(key => key.claimedBy === userId);

        // Construct the profile embed
        const embed = new EmbedBuilder()
            .setTitle(`${interaction.user.username}'s Profile`)
            .setColor(premiumStatus ? 0xFFD700 : 0x00FF00) // Gold color for premium, green for non-premium
            .setThumbnail(interaction.user.displayAvatarURL())
            .addFields(
                {name: 'GlobalName', value: interaction.user.globalName},
                { name: 'Username', value: interaction.user.username, inline: true },
                { name: 'User ID', value: userId, inline: true },
                { name: 'Premium Status', value: premiumStatus ? `Premium until: ${new Date(premiumStatus.expiration).toLocaleDateString()}` : 'Not Premium', inline: false }
            )
            .setTimestamp()
            .setFooter({
                text: client.footer.text,
                iconURL: client.footer.icon_url
            });

        // Send the profile embed
        await interaction.reply({ embeds: [embed] });
    }
};
