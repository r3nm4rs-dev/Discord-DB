const { Permissions, MessageEmbed } = require("discord.js");
const path = require('path');
const backup = require("discord-backup");

module.exports = async (client) => {
    let backupStorageFolder = path.join(__dirname, `../backups/`)
    client.backupCreate = async function (interaction, Guild,) {
        backup.setStorageFolder(backupStorageFolder);
        try {
            const user = await interaction.guild.members.cache.get(interaction.user.id);
            if (!user.permissions.has(Permissions.FLAGS.ADMINSTRATOR)) {
                return await interaction.editReply({
                    content: 'I do not have permissions to use this command'
                });
            }
            backup.create(Guild, {
                jsonBeautify: true,
                maxMessagesPerChannel: 0
            }).then((backupData) => {
                user.send("The backup has been created! To load it, type this command on the server of your choice: `/backup load loadbackupid:" + backupData.id + "` !");
                interaction.editReply("** <:goldstaff:1114253395621064744> Backup successfully created. \n > The backup ID was sent in dm!**");
            });
        } catch (e) {
            interaction.editReply(`${e}`)
        }
    }
    client.backupDelete = async function (interaction, backupID) {
        backup.setStorageFolder(backupStorageFolder);
        try {
            backup.remove(backupID).then((backupData) => {
                interaction.editReply("**<:goldstaff:1114253395621064744> Backup successfully deleted.**");
            });
        } catch (e) {
            interaction.editReply(`${e}`)
        }
    }
    client.backupLoad = async function (interaction, backupID, messageInc) {
        backup.setStorageFolder(backupStorageFolder);
        try {
            const user = await interaction.guild.members.cache.get(interaction.user.id);
            if (!user.permissions.has(Permissions.FLAGS.ADMINSTRATOR)) {
                return await interaction.editReply({
                    content: 'I do not have permissions to use this command'
                });
            }
            if (!backupID) {
                return interaction.editReply(":x: | You must specify a valid backup ID!");
            }
            backup.fetch(backupID, { clearGuildBeforeRestore: true }).then(async () => {
                if (!interaction.guild.me.permissions.has(Permissions.FLAGS.ADMINSTRATOR)) {
                    return await interaction.editReply({
                        content: 'I do not have permissions to use this command'
                    });
                } else {
                    interaction.editReply("<:goldstaff:1114253395621064744> | Start loading the backup!");
                    backup.load(backupID, interaction.guild, { maxMessagesPerChannel: 0 });
                }
            })
        } catch (e) {
            interaction.editReply(`${e}`)
        }
    }
    client.backupInfo = async function (interaction, backupID) {
        backup.setStorageFolder(backupStorageFolder);
        try {
            if (!backupID) {
                return interaction.editReply(":x: | You must specify a valid backup ID!");
            }
            backup.fetch(backupID).then((backupInfos) => {
                const date = new Date(backupInfos.data.createdTimestamp);
                const yyyy = date.getFullYear().toString(), mm = (date.getMonth() + 1).toString(), dd = date.getDate().toString();
                const formatedDate = `${yyyy}/${(mm[1] ? mm : "0" + mm[0])}/${(dd[1] ? dd : "0" + dd[0])}`;
                let embed = new MessageEmbed()
                    .setAuthor("Backup Informations")
                    .addField("Backup ID", backupInfos.id, false)
                    .addField("Server Name", backupInfos.data.name, false)
                    .addField("Server ID", backupInfos.data.guildID, false)
                    .addField("Size", `${backupInfos.size} kb`, false)
                    .addField("Created at", formatedDate, false)
                    .setColor(interaction.client.config.defaults.embedColour)
                interaction.editReply({ embeds: [embed] });
            }).catch((err) => {
                return interaction.editReply(":x: | No backup found for `" + backupID + "`!");
            });
        } catch (e) {
            interaction.editReply(`${e}`)
        }
    }
}