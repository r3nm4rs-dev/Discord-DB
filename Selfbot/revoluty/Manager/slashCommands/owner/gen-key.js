const { CommandInteraction, PermissionsBitField, EmbedBuilder, ActionRowBuilder, ButtonBuilder, ButtonStyle, Client, SelectMenuBuilder, ApplicationCommandOptionType } = require("pwss")
module.exports = {
    name: "gen-license",
    description: "Gen premium subscription key!",
    options: [{
        name: "amount",
        type: ApplicationCommandOptionType.Number,
        description: "Amount of keys to generate",
        required: true
    }, {
        name: "days",
        type: ApplicationCommandOptionType.Number,
        description: "Amount of days to generate",
        required: true
    }],
    run: async (client, interaction) => {
        if (!client.config.team.owner.includes(interaction.user.id) && !client.config.team.devs.includes(interaction.user.id)) {
            return interaction.reply({ content: 'You are not allowed to use this command!', ephemeral: true });
        }
         // Defer the reply to avoid interaction timeout
         await interaction.deferReply({ ephemeral: true });

         let db = await client.db.get(`revoluty_premium`) || [];
         const amount = interaction.options.getNumber('amount');
         const days = interaction.options.getNumber('days');
         
         for (let i = 0; i < amount; i++) {
             const code = "revo_" + genCode(24);
             db.push({
                code: code,
                days: days,
                claimedBy: null
            });
         }
 
         client.db.set(`revoluty_premium`, db);
 
         const embed = new EmbedBuilder()
             .setTitle('Premium subscription key')
             .setColor(await client.convertColor(client.color))
             .setDescription(db.slice(-amount).map(x => `**${x.code}** - ${x.days} days`).join('\n'))
             .setTimestamp()
             .setFooter({
                 text: client.footer.text,
                 iconURL: client.footer.icon_url
             })
             .setThumbnail(client.thumbnail.icon_url)
             .setAuthor({
                 name: interaction.user.username,
                 iconURL: interaction.user.displayAvatarURL()
             })
         await interaction.editReply({ embeds: [embed] });
 
    }
}


// genCode function
function genCode(length) {
    const characters = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789';
    let result = '';
    for (let i = 0; i < length; i++) {
        result += characters.charAt(Math.floor(Math.random() * characters.length));
    }
    return result;
}
