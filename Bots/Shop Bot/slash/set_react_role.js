const Discord = require('discord.js');

module.exports = {
    name: "set_react_role",
    description: 'Set the react role',
    options: [
        {
            name: 'message_id',
            description: 'The message id of the message to react to',
            type: 'STRING',
            required: true
        },
        {
            name: 'emoji',
            description: 'The emoji to react with',
            type: 'STRING',
            required: true
        },
        {
            name: 'role',
            description: 'The role to give to the user',
            type: 'ROLE',
            required: true
        }
    ],
    run: async (client, interaction) => {
        await interaction.deferReply({ ephermeral: true });
        const MESSAGE_ID = interaction.options.getString('message_id');
        let EMOJI = interaction.options.getString('emoji');
        const ROLE = interaction.options.getRole('role');
        if (!interaction.channel.permissionsFor(interaction.member).has('ADMINISTRATOR')) {
            return await interaction.editReply({
                content: 'You do not have permissions to use this command',
                ephemeral: true
            });
        }
        const MESSAGE = await interaction.channel.messages.fetch(MESSAGE_ID);
        if (!MESSAGE)
            return await interaction.editReply({
                content: 'Message not found',
                ephemeral: true
            });
        await MESSAGE.react(EMOJI);
        EMOJI = EMOJI.replace(/<a?:[^:\s]*(?:::[^:\s]*)*:/g, '').replace('>', '');
        await client.db.set(`react_role_${EMOJI}`, {
            message_id: MESSAGE_ID,
            role: ROLE.id
        });
        const Embed = new Discord.MessageEmbed()
            .setTitle('React Role')
            .setDescription(`React role has been set to ${ROLE}`)
            .setColor("#56089e");

        await interaction.editReply({
            embeds: [Embed],
            ephemeral: true
        });
    }
};