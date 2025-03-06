const { MessageEmbed, MessageActionRow, MessageSelectMenu } = require('discord.js');

module.exports = {
    name: 'help',
    description: 'Help command',
    run: async (client, interaction) => {
        await interaction.deferReply({ ephemeral: true });
        const embed = new MessageEmbed()
            .setTitle(`Commands of ${client.user.username}`)
            .setColor('#56089e')
            .setDescription('**Contents : **\n\n > Select an Option from the drop down ')
            .setTimestamp()
            .setFooter({
                text: `Requested by ${interaction.user.username}`,
                iconURL: interaction.user.displayAvatarURL()
            });

        const giveaway = new MessageEmbed()
            .setTitle("Giveaway")
            .setColor('#56089e')
            .setDescription("Start, Edit, End, List, Pause, Reroll, Resume")
            .setTimestamp()
            .setFooter({
                text: `Requested by ${interaction.user.username}`,
                iconURL: interaction.user.displayAvatarURL()
            });

        const general = new MessageEmbed()
            .setTitle("General")
            .setColor('#56089e')
            .setDescription("Stats, Backup(create|load|delete|info),  Server-Stats, Set_Vouch_Channel, Restore_vouch_data, Set_Slot_Category, Embed")
            .setTimestamp()
            .setFooter({
                text: `Requested by ${interaction.user.username}`,
                iconURL: interaction.user.displayAvatarURL()
            });

        const response = new MessageEmbed()
            .setTitle("Automation")
            .setColor('#56089e')
            .setDescription("Set_react_role, Addresponse, Deleteresponse, Listresponse, Addbanword, Deletebanword, Listbanword, Add_censorfree_role, Set_Notifications, Remove_Notifications, Set_Autodelete, Remove_Autodelete, Set_Autoreaction, Remove_Autoreaction")
            .setTimestamp()
            .setFooter({
                text: `Requested by ${interaction.user.username}`,
                iconURL: interaction.user.displayAvatarURL()
            });

        const invites = new MessageEmbed()
            .setTitle("Invite")
            .setColor('#56089e')
            .setDescription("Addinvite, Deleteinvite, Listinvite")
            .setTimestamp()
            .setFooter({
                text: `Requested by ${interaction.user.username}`,
                iconURL: interaction.user.displayAvatarURL()
            });

        const rank = new MessageEmbed()
            .setTitle("Leveling System")
            .setColor('#56089e')
            .setDescription("Level, Givelevel, Resetlevel, Resetalllevel, Levellb")
            .setTimestamp()
            .setFooter({
                text: `Requested by ${interaction.user.username}`,
                iconURL: interaction.user.displayAvatarURL()
            });

        const mod = new MessageEmbed()
            .setTitle("Moderation")
            .setColor('#56089e')
            .setDescription("Kick, Ban, Purge, Antilink, Autokick, Welcome, Afk")
            .setTimestamp()
            .setFooter({
                text: `Requested by ${interaction.user.username}`,
                iconURL: interaction.user.displayAvatarURL()
            });

        const components = (state) => [
            new MessageActionRow().addComponents(
                new MessageSelectMenu()
                    .setCustomId("help-menu")
                    .setPlaceholder("Please Select a Category")
                    .setDisabled(state)
                    .addOptions([{
                        label: `Giveaways`,
                        value: `giveaway`,
                        description: `View all the giveaway based commands!`,
                        emoji: `🎉`
                    },
                    {
                        label: `General`,
                        value: `general`,
                        description: `View all the general bot commands!`,
                        emoji: `⚙`
                    },
                    {
                        label: `Automation`,
                        value: `auto`,
                        description: `View all the Custom bot commands!`,
                        emoji: `📋`
                    },
                    {
                        label: `Leveling`,
                        value: `rank`,
                        description: `View all the Leveling commands!`,
                        emoji: `📊`
                    },
                    {
                        label: `Invite`,
                        value: `invite`,
                        description: `View all the Invite bot commands!`,
                        emoji: `🎁`
                    },
                    {
                        label: `Moderation`,
                        value: `mod`,
                        description: `View all the Mod bot commands!`,
                        emoji: `👮`
                    }
                    ])
            ),
        ];

        const initialMessage = await interaction.editReply({ embeds: [embed], components: components(false) });

        const filter = (int) => int.user.id === interaction.user.id;

        const collector = interaction.channel.createMessageComponentCollector(
            {
                filter,
                componentType: "SELECT_MENU",
                idle: 300000,
                dispose: true,
            });

        collector.on('collect', (int) => {
            if (int.values[0] === "giveaway") {
                int.update({ embeds: [giveaway], components: components(false) }).catch((e) => { });
            } else if (int.values[0] === "general") {
                int.update({ embeds: [general], components: components(false) }).catch((e) => { });
            } else if (int.values[0] === "auto") {
                int.update({ embeds: [response], components: components(false) }).catch((e) => { });
            } else if (int.values[0] === "invite") {
                int.update({ embeds: [invites], components: components(false) }).catch((e) => { });
            } else if (int.values[0] === "mod") {
                int.update({ embeds: [mod], components: components(false) }).catch((e) => { });
            } else if (int.values[0] === "rank") {
                int.update({ embeds: [rank], components: components(false) }).catch((e) => { });
            }
        });
        collector.on("end", (collected, reason) => {
            if (reason == "time") {
                initialMessage.editReply({
                    content: "Collector Destroyed, Try Again!",
                    components: [],
                });
            }
        });
    }
};