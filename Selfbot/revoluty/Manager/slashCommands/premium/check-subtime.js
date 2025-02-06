const { CommandInteraction, EmbedBuilder, ApplicationCommandOptionType } = require("pwss");

module.exports = {
    name: "check-subtime",
    description: "Check how much time you have left on your premium subscription",
    run: async (client, interaction) => {
        const userId = interaction.user.id;

        // Fetch premium keys from the database
        let db = client.db.get(`hidden_premium`) || [];
        const userKey = db.find(k => k.claimedBy === userId);

        if (userKey) {
            const remainingTime = userKey.expiration - Date.now();
            const daysRemaining = Math.floor(remainingTime / (24 * 60 * 60 * 1000));
            const hoursRemaining = Math.floor((remainingTime % (24 * 60 * 60 * 1000)) / (60 * 60 * 1000));
            const minutesRemaining = Math.floor((remainingTime % (60 * 60 * 1000)) / (60 * 1000));

            const embed = new EmbedBuilder()
                .setTitle('Premium Subscription Time Remaining')
                .setColor(0xFFD700) // Gold color
                .setDescription(`You have **${daysRemaining} days, ${hoursRemaining} hours, and ${minutesRemaining} minutes** of premium subscription remaining.`)
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
        } else {
            await interaction.reply({ content: 'You do not have an active premium subscription.', ephemeral: true });
        }
    }
};
