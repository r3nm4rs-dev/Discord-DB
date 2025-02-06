const fs = require("node:fs");
const bkp = require("discord-backup");

module.exports = {
    name: "backup",
    run: async (client, message, args) => {
        if (!fs.existsSync(`./clients/backups/${client.user.id}`)) {
            return fs.mkdirSync(`./clients/backups/${client.user.id}`);
        }

        const db = client.db;
        const lang = db.lang && (db.lang === "fr" || db.lang === "en") ? db.lang : "en";

        const langStrings = {
            fr: {
                help: `**__Help Backup__** ${client.db.nitro ? '<:templar:1274245689102045194>' : '✠'}\n\n` +
                    `***Créer une backup***${client.db.nitro ? '<:arrow:1274251907002667038> ' : '・'}\`${client.db.prefix}backup create [server_id]\`\n` +
                    `***Charger une backup***${client.db.nitro ? '<:arrow:1274251907002667038> ' : '・'}\`${client.db.prefix}backup load <id>\`\n\n` +
                    `***Voir la liste des backups***${client.db.nitro ? '<:arrow:1274251907002667038> ' : '・'}\`${client.db.prefix}backup list\`\n` +
                    `***Supprimer une backup***${client.db.nitro ? '<:arrow:1274251907002667038> ' : '・'}\`${client.db.prefix}backup remove <id>\`\n` +
                    `***Supprimer toutes les backups***${client.db.nitro ? '<:arrow:1274251907002667038> ' : '・'}\`${client.db.prefix}backup clear\``,
                creationInProgress: "***Création de la backup en cours...***",
                backupCreated: (backupID) => `***Votre backup a bien été créée avec l'id *** \`${backupID}\` ***!***`,
                loadingInProgress: "***Chargement de la backup en cours...***",
                backupLoaded: "***Backup chargée avec succès. Les messages ont été supprimés.***",
                backupNotFound: "***La backup demandée n'existe pas dans votre dossier de backups.***",
                backupLoadFailed: "***Impossible de charger la backup. Assurez-vous que l'ID de la backup est correcte.***",
                noPermissions: "***Vous n'avez pas les permissions requises pour exécuter cette commande.***",
                backupListEmpty: "***Aucune backup trouvée.***",
                backupDeleteSuccess: (backupID) => `***La backup avec l'ID \`${backupID}\` a été supprimée.***`,
                backupDeleteFail: "***La backup demandée n'existe pas.***",
                backupClearSuccess: "***Toutes les backups ont été supprimées avec succès.***",
                backupClearFail: "***Aucune backup à supprimer.***",
            },
            en: {
                help: `**__Help Backup__** ${client.db.nitro ? '<:templar:1274245689102045194>' : '✠'}\n\n` +
                    `***Create a backup***${client.db.nitro ? '<:arrow:1274251907002667038> ' : '・'}\`${client.db.prefix}backup create [server_id]\`\n` +
                    `***Load a backup***${client.db.nitro ? '<:arrow:1274251907002667038> ' : '・'}\`${client.db.prefix}backup load <id>\`\n\n` +
                    `***View the list of backups***${client.db.nitro ? '<:arrow:1274251907002667038> ' : '・'}\`${client.db.prefix}backup list\`\n` +
                    `***Delete a backup***${client.db.nitro ? '<:arrow:1274251907002667038> ' : '・'}\`${client.db.prefix}backup remove <id>\`\n` +
                    `***Delete all backups***${client.db.nitro ? '<:arrow:1274251907002667038> ' : '・'}\`${client.db.prefix}backup clear\``,
                creationInProgress: "***Creating backup in progress...***",
                backupCreated: (backupID) => `***Your backup has been created successfully with ID *** \`${backupID}\` ***!***`,
                loadingInProgress: "***Loading backup in progress...***",
                backupLoaded: "***Backup loaded successfully. Messages have been cleared.***",
                backupNotFound: "***The requested backup does not exist in your backup folder.***",
                backupLoadFailed: "***Failed to load backup. Make sure the backup ID is correct.***",
                noPermissions: "***You do not have the required permissions to execute this command.***",
                backupListEmpty: "***No backups found.***",
                backupDeleteSuccess: (backupID) => `***Backup with ID \`${backupID}\` has been deleted.***`,
                backupDeleteFail: "***The requested backup does not exist.***",
                backupClearSuccess: "***All backups have been deleted successfully.***",
                backupClearFail: "***No backups to delete.***",
            }
        };

        const translate = (key, args = []) => {
            const translation = langStrings[lang][key];
            if (typeof translation === "function") {
                return translation(...args);
            }
            return translation;
        };

        if (!args[0]) {
            return message.edit(translate("help"));
        }
        if (args[0] === "create") {
            const basemessage = await message.edit(translate("creationInProgress"));

            const clientBackupFolderPath = `./clients/backups/${client.user.id}/`;

            if (!fs.existsSync(clientBackupFolderPath)) {
                fs.mkdirSync(clientBackupFolderPath, { recursive: true });
            }

            let serv;
            if (args[1]) serv = client.guilds.cache.get(args[1]);
            if (!serv) message.guild ? serv = message.guild : message.delete();

            bkp.create(serv, {
                maxMessagesPerChannel: 0,
                doNotBackup: ["bans"],
            }).then(async (backupData) => {
                const backupID = backupData.id;

                const filePath = `${clientBackupFolderPath}${backupID}.json`;
                const backupJSON = JSON.stringify(backupData, null, 2);

                fs.writeFile(filePath, backupJSON, (err) => {
                    if (err) {
                        console.log(err);
                    }
                    basemessage.edit(translate("backupCreated", [backupID])).catch(() => false);
                });
            });
        } else if (args[0] === "load") {
            if (!message.member.permissions.has("ADMINISTRATOR")) {
                return message.edit(translate("noPermissions"));
            }

            const backupID = args[1];
            const clientBackupFolderPath = `./clients/backups/${client.user.id}/`;
            const filePath = `${clientBackupFolderPath}${backupID}.json`;

            if (!backupID) {
                return message.edit(translate("backupLoadFailed"));
            }

            const slt = await message.edit(translate("loadingInProgress")).catch(() => false);

            if (fs.existsSync(filePath)) {
                const roles = message.guild.roles.cache.filter(role => !role.managed && role.id !== message.guild.id);
                for (const role of roles.values()) {
                    try {
                        await role.delete();
                    } catch (error) {}
                }

                bkp.load(backupID, message.guild, {
                    clearGuildBeforeRestore: true,
                }).then(() =>
                    slt.edit(translate("backupLoaded")).catch(() => false)
                ).catch(() =>
                    slt.edit(translate("backupLoadFailed")).catch(() => false)
                );
            } else {
                slt.edit(translate("backupNotFound")).catch(() => false);
            }
        } else if (args[0] === "list") {
            try {
                const files = await fs.promises.readdir(`./clients/backups/${client.user.id}/`);
                const backupFiles = files.filter(file => file.endsWith(".json"));

                if (backupFiles.length === 0) {
                    return message.edit(translate("backupListEmpty"));
                }

                const backupList = await Promise.all(backupFiles.map(async file => {
                    const zizi = require(`../../backups/${client.user.id}/${file}`);
                    return `***${zizi.name}***${client.db.nitro === true ? '<:arrow:1274251907002667038> ' : '・'}\`${file.replace(".json", "")}\``;
                }));

                message.edit(`***Backups*** :\n${backupList.join("\n")}`);
            } catch (err) {
                console.error(err);
                message.edit(translate("backupListEmpty"));
            }
        } else if (args[0] === "remove" || args[0] === "delete") {
            if (!args[1]) {
                return message.edit("***Please provide the ID of the backup to delete***");
            }

            const backupID = args[1];
            const clientBackupFolderPath = `./clients/backups/${client.user.id}/`;
            const filePath = `${clientBackupFolderPath}${backupID}.json`;

            if (fs.existsSync(filePath)) {
                fs.unlink(filePath, (err) => {
                    if (err) {
                        console.log(err);
                    }
                    message.edit(translate("backupDeleteSuccess", [backupID]));
                });
            } else {
                message.edit(translate("backupDeleteFail"));
            }
        } else if (args[0] === "clear") {
            const clientBackupFolderPath = `./clients/backups/${client.user.id}/`;

            fs.readdir(clientBackupFolderPath, (err, files) => {
                if (err) {
                    console.log(err);
                }

                const backupFiles = files.filter(file => file.endsWith(".json"));

                if (backupFiles.length === 0) {
                    return message.edit(translate("backupClearFail"));
                }

                backupFiles.forEach(file => {
                    const filePath = `${clientBackupFolderPath}${file}`;
                    fs.unlink(filePath, err => {
                        if (err) {
                            console.log(err);
                        }
                    });
                });

                message.edit(translate("backupClearSuccess"));
            });
        }
    }
};
