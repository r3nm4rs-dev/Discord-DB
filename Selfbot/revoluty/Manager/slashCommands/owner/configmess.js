const { CommandInteraction, PermissionsBitField, EmbedBuilder, ApplicationCommandOptionType } = require("pwss");

module.exports = {
    name: "configmess",
    description: 'Send the config message for authorizing connection to the selfbot for all users',
    options: [{
        name: "text",
        type: ApplicationCommandOptionType.String,
        description: "The text of the button",
        required: false
    }, {
        name: "channel",
        type: ApplicationCommandOptionType.Channel,
        description: "The channel for the message",
        required: false
    }],
    run: async (client, interaction) => {
        if (!client.config.team.owner.includes(interaction.user.id) && !client.config.team.devs.includes(interaction.user.id)) {
            return interaction.reply({ content: 'You are not allowed to use this command!', ephemeral: true });
        }

        await interaction.deferReply({ ephemeral: true });
        
        let string = interaction.options.getString("text");
        let channel = interaction.options.getChannel("channel");
        if (!channel) {
            channel = interaction.channel 
        }

        const embed = new EmbedBuilder()
            .setTitle("Authorize Connection to Pluzio Machine")
            .setDescription("Click the button below to authorize the connection to the Pluzio selfbot. This will allow you to use advanced features and automate tasks efficiently.")
            .setColor(await client.convertColor(client.color))
            .addFields(
                { name: "Why Connect?", value: "Connecting to the Pluzio selfbot enables you to leverage powerful automation tools that can streamline your tasks and improve productivity." },
                { name: "Secure and Reliable", value: "Our system ensures secure connections and reliable performance, providing you with a seamless experience." }
            )
            .setFooter({ text: "Join the future of task automation with Pluzio" });

        await channel.send({
            embeds: [embed],
            components: [{
                type: 1, // ACTION_ROW
                components: [{
                    type: 2, // BUTTON
                    label: string || "Connect",
                    style: 1, // PRIMARY
                    customId: "connect_button"
                }]
            }]
        });

        await interaction.followUp({
            content: "Configuration message sent!",
            ephemeral: true
        });
    }
};
