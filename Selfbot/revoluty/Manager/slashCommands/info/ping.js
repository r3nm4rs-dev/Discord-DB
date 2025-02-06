const { CommandInteraction, PermissionsBitField, EmbedBuilder, ActionRowBuilder, ButtonBuilder, ButtonStyle, Client, SelectMenuBuilder, ApplicationCommandOptionType } = require("pwss")
module.exports = {
    name: "ping",
    description: "Check api latency",
    run: async (client, interaction) => {
        const embed = new EmbedBuilder()
           .setColor(await client.convertColor(client.color))
           .setTitle('Pong!')
           .setDescription(`Latency: ${client.ws.ping}ms`)
           .setFooter({
                text: client.footer.text,
                iconURL: client.footer.icon_url
            })
        await interaction.reply({ embeds: [embed], ephemeral: true })
    }
}
























// module.exports = {
//     data: new SlashCommandBuilder()
//         .setName('ping')
//         .setDescription('Check api latency'),
//     run: async (client, interaction) => {
//         const embed = new EmbedBuilder()
//            .setColor(await client.convertColor(client.color))
//            .setTitle('Pong!')
//            .setDescription(`Latency: ${client.ws.ping}ms`)
//             .setFooter({
//                 text: client.footer.text,
//                 iconURL: client.footer.icon_url
//             })
//             .setThumbnail(client.thumbnail.icon_url)
//             .setAuthor({
//                 name: interaction.user.username,
//                 iconURL: interaction.user.displayAvatarURL()
//             })
//             .setImage('https://cdn.discordapp.com/attachments/1153422397706350764/1254486658879979572/68747470733a2f2f692e696d6775722e636f6d2f446c64366c77352e706e67.png?ex=6679ab3e&is=667859be&hm=6d882299ad73b323915d85ca103d654d604f955142d195926039fb6d5633b4a8&')
//             .setTimestamp();
//         await interaction.reply({ embeds: [embed] });
//     }
// }