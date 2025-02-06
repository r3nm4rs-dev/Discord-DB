const { CommandInteraction, PermissionsBitField, EmbedBuilder, ApplicationCommandOptionType } = require("pwss");

module.exports = {
    name: "license-list",
    description: "List all generated premium subscription keys!",
    options: [],
    run: async (client, interaction) => {
        if (!client.config.team.owner.includes(interaction.user.id) && !client.config.team.devs.includes(interaction.user.id)) {
            return interaction.reply({ content: 'You are not allowed to use this command!', ephemeral: true });
        }

        // Defer the reply to avoid interaction timeout
        await interaction.deferReply({ ephemeral: true });

        let db = client.db.get(`revoluty_premium`) || [];
        if (db.length === 0) {
            return interaction.editReply({ content: 'No keys found!', ephemeral: true });
        }

        const embed = new EmbedBuilder()
            .setTitle('Premium subscription license')
            .setColor(await client.convertColor(client.color))
            .setDescription(
                db.map(x => {
                    const claimedBy = x.claimedBy ? `Claimed by: ${x.claimedBy}` : 'Not claimed';
                    return `**${x.code}** - ${x.days} days\n${claimedBy}`;
                }).join('\n')
            )
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

        await interaction.editReply({ embeds: [embed] });
    }
}
