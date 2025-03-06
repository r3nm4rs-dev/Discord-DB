const Discord = require('discord.js');
const ms = require('ms');

module.exports = {
    name: 'create_slot',
    description: 'Create a slot for a user with a specific amount of duration',
    options: [
        {
            name: 'user',
            description: 'The user to create a slot for',
            type: 'USER',
            required: true
        },
        {
            name: 'channel_name',
            description: 'The name of the channel',
            type: 'STRING',
            required: true
        },
        {
            name: 'duration',
            description: 'The duration of the slot',
            type: 'INTEGER',
            required: true,
            choices: [
                {
                    name: '14 Days',
                    value: '14'
                },
                {
                    name: '30 Days',
                    value: '30'
                },
                {
                    name: 'never',
                    value: '0'
                }
            ]
        }
    ],
    run: async (client, interaction) => {
        await interaction.deferReply({ ephemeral: true });

        const user = interaction.options.getUser('user');
        const duration = interaction.options.getInteger('duration');
        const channel_name = interaction.options.getString('channel_name');

        if (!interaction.channel.permissionsFor(interaction.member).has('ADMINISTRATOR')) {
            return interaction.editReply({ content: 'You do not have permissions to use this command', ephemeral: true });
        }

        const guild = interaction.guild;
        const member = guild.members.cache.get(user.id);

        const category_id = client.db.get('slots_category');
        const category = guild.channels.cache.get(category_id);

        if (!category) {
            return interaction.editReply({ content: 'The slots category does not exist' });
        }

        const member_role_id = client.db.get('member_role');
        const member_role = guild.roles.cache.get(member_role_id);
        if (!member_role) {
            return interaction.editReply({ content: 'The member role does not exist' });
        }

        const time = ms(`${duration}d`);
        const channel = await guild.channels.create(channel_name, {
            type: 'GUILD_TEXT',
            parent: category,
            permissionOverwrites: [
                {
                    id: member.id,
                    allow: ['SEND_MESSAGES', 'VIEW_CHANNEL', 'READ_MESSAGE_HISTORY', 'ADD_REACTIONS', 'ATTACH_FILES', 'USE_EXTERNAL_EMOJIS', 'EMBED_LINKS', 'MENTION_EVERYONE']
                },
                {
                    id: member_role_id,
                    allow: ['VIEW_CHANNEL', 'READ_MESSAGE_HISTORY']
                },
                {
                    id: member_role_id,
                    deny: ['SEND_MESSAGES']
                }
            ]
        });
        await channel.send(`<@${member.id}> your slot has been created`);
        if (duration !== 0) {
            if (Array.isArray(client.db.get(`slots`))) {
                client.db.push('slots', channel.id);
            } else {
                client.db.set('slots', [channel.id]);
            }

            client.db.set(`slot.${channel.id}`, {
                user_id: user.id,
                duration: time,
                created_at: Date.now()
            });
        }

        const embed = new Discord.MessageEmbed()
            .setTitle('Slot Created')
            .setDescription(`Your slot has been created in ${channel} for ${duration === 0 ? 'never' : `${duration} days`}`)
            .setColor('GREEN');

        await interaction.editReply({ embeds: [embed] });
    }
}
