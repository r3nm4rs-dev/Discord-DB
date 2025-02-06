const fs = require("fs");
const backup = require("discord-backup");

module.exports = {
  name: "backup",
  description: "Gestion des backups",
  run: async (client, message, args, prefix) => {
      if (args[0] === "create") {
      const basemessage = await message.edit(
        "**`🔧` Création de la backup en cours...**"
      );

      const clientID = message.author.id;
      const clientBackupFolderPath = `./backups/${clientID}/`;

      
      if (!fs.existsSync(clientBackupFolderPath)) {
        fs.mkdirSync(clientBackupFolderPath, { recursive: true });
      }

      backup
        .create(message.guild, {
          maxMessagesPerChannel: 0,
          doNotBackup: ["bans"],
        })
        .then(async (backupData) => {
          const backupID = backupData.id;

          
          const filePath = `${clientBackupFolderPath}${backupID}.json`;
          const backupJSON = JSON.stringify(backupData);

          fs.writeFile(filePath, backupJSON, (err) => {
            if (err) {
              console.log(err);
              return basemessage
                .edit(
                  "Erreur lors de la sauvegarde de la backup. Vérifiez la console pour plus d'informations."
                )
                .catch(() => false);
            }
            console.log("Fichier écrit avec succès");
            basemessage.edit(
              `**Votre backup a bien été créée avec l'id ** \`${backupID}\` **!**\``
            ).catch(() => false);
          });
        })
    } else if (args[0] === "load") {
      if (!message.member.permissions.has("ADMINISTRATOR"))
        return message.edit(
          "**`❌` Vous n'avez pas les permissions requises pour executer cette commande**"
        );

      const clientID = message.author.id;
      const backupID = args[1];
      const clientBackupFolderPath = `./backups/${clientID}/`;
      const filePath = `${clientBackupFolderPath}${backupID}.json`;

      if (!backupID)
        return message.edit(
          "**`❌` Veuillez me fournir une ID de backup valide**"
        );

      const slt = await message.edit(
        "**`🎡` Chargement de la backup en cours...**"
      ).catch(() => false);

     
      if (fs.existsSync(filePath)) {
        backup
          .load(backupID, message.guild, {
            clearGuildBeforeRestore: true,
          })
          .then(() =>
            slt
              .edit(
                "**`✅` Backup chargée avec succès. Les messages ont été supprimés.**"
              )
              .catch(() => false)
          )
          .catch(() =>
            slt
              .edit(
                "**`❌` Impossible de charger la backup. Assurez-vous que l'ID de la backup est correcte.**"
              )
              .catch(() => false)
          );
      } else {
        slt
          .edit(
            "**`❌` La backup demandée n'existe pas dans votre dossier de backups.**"
          )
          .catch(() => false);
      }
    }
  }
};
