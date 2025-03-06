const { Permissions } = require('discord.js');

module.exports = {
    name: "backup",
    description: 'Create a backup, delete a backup, load a backup and find more information about a backup.',
    options: [
        {
            name: 'create',
            description: 'backup up your guild.',
            type: 'SUB_COMMAND'
        },
        {
            name: 'delete',
            description: 'delete a backup.',
            type: 'SUB_COMMAND',
            options: [
                {
                    name: 'deletebackupid',
                    description: 'the backupid you will want to use.',
                    type: 'STRING',
                    required: true
                }
            ]
        },
        {
            name: 'load',
            description: 'load a backup in your current guild.',
            type: 'SUB_COMMAND',
            options: [
                {
                    name: 'loadbackupid',
                    description: 'the backupid you will want to use.',
                    type: 'STRING',
                    required: true
                }
            ]
        },
        {
            name: 'info',
            description: 'find more information about a backup.',
            type: 'SUB_COMMAND',
            options: [
                {
                    name: 'infobackupid',
                    description: 'the backupid you will want to use.',
                    type: 'STRING',
                    required: true
                }
            ]
        }
    ],
    run: async (client, interaction) => {
        await interaction.deferReply({ ephermeral: true });
        const user = interaction.member;
        if (!user.permissions.has(Permissions.FLAGS.ADMINISTRATOR)) {
            return await interaction.editReply({
                content: 'You do not have permissions to use this command'
            });
        }

        if (interaction.options.getSubcommand() === 'create') {
                interaction.client.backupCreate(interaction, interaction.guild)
        } else if (interaction.options.getSubcommand() === 'delete') {
            let backupid = interaction.options.getString('deletebackupid')
            interaction.client.backupDelete(interaction, backupid)
        } else if (interaction.options.getSubcommand() === 'load') {
            let backupid = interaction.options.getString('loadbackupid')
            let message_included = interaction.options.getBoolean('message_included')
            interaction.client.backupLoad(interaction, backupid, message_included)
        } else if (interaction.options.getSubcommand() === 'info') {
            let backupid = interaction.options.getString('infobackupid')
            interaction.client.backupInfo(interaction, backupid)
        }
    }
}