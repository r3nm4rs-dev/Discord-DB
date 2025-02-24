const fs = require("fs");
const backup = require("discord-backup");

module.exports = {
  name: "backup",
  description: "Gestion des backups",
  run: async (client, message, args, prefix) => {
    const clientID = message.author.id;
    const clientBackupFolderPath = `./backups/${clientID}/`;

    if (args[0] === "create") {
      const serverID = args[1]; // Récupère l'ID du serveur à sauvegarder
      if (!serverID) {
        return message.edit(
          "**`❌` Veuillez fournir l'ID du serveur à sauvegarder.**"
        );
      }

      const guild = client.guilds.cache.get(serverID);
      if (!guild) {
        return message.edit(
          "**`❌` Impossible de trouver le serveur avec l'ID fourni.**"
        );
      }

      const basemessage = await message.edit(
        "**`🔧` Création de la backup en cours pour le serveur...**"
      );

      if (!fs.existsSync(clientBackupFolderPath)) {
        fs.mkdirSync(clientBackupFolderPath, { recursive: true });
      }

      backup
        .create(guild, {
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
            basemessage
              .edit(
                `**Votre backup pour le serveur avec l'ID \`${serverID}\` a bien été créée avec l'id \`${backupID}\` !**`
              )
              .catch(() => false);
          });
        })
        .catch(() => {
          basemessage
            .edit(
              "**`❌` Une erreur est survenue lors de la création de la backup.**"
            )
            .catch(() => false);
        });
    } else if (args[0] === "load") {
      if (!message.member.permissions.has("ADMINISTRATOR"))
        return message.edit(
          "**`❌` Vous n'avez pas les permissions requises pour exécuter cette commande.**"
        );

      const backupID = args[1];
      const filePath = `${clientBackupFolderPath}${backupID}.json`;

      if (!backupID)
        return message.edit(
          "**`❌` Veuillez me fournir une ID de backup valide.**"
        );

      const slt = await message
        .edit("**`🎡` Chargement de la backup en cours...**")
        .catch(() => false);

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
    } else if (args[0] === "delete") {
      const backupID = args[1];
      const filePath = `${clientBackupFolderPath}${backupID}.json`;

      if (!backupID)
        return message.edit(
          "**`❌` Veuillez fournir l'ID de la backup à supprimer.**"
        );

      if (fs.existsSync(filePath)) {
        fs.unlinkSync(filePath);
        return message.edit(
          `**✅ La backup avec l'ID \`${backupID}\` a bien été supprimée.**`
        );
      } else {
        return message.edit(
          "**`❌` La backup demandée n'existe pas dans votre dossier de backups.**"
        );
      }
    } else if (args[0] === "purge") {
      if (!fs.existsSync(clientBackupFolderPath)) {
        return message.edit("**`❌` Vous n'avez aucune backup enregistrée.**");
      }

      const backupFiles = fs.readdirSync(clientBackupFolderPath);
      if (backupFiles.length === 0) {
        return message.edit("**`❌` Vous n'avez aucune backup enregistrée.**");
      }

      // Supprimer tous les fichiers de backup
      for (const file of backupFiles) {
        fs.unlinkSync(`${clientBackupFolderPath}${file}`);
      }

      await message.edit("**✅ Toutes vos backups ont été supprimées.**");
    } else if (args[0] === "list") {
      // Liste les backups de l'utilisateur
      if (!fs.existsSync(clientBackupFolderPath)) {
        return message.edit("**`❌` Vous n'avez aucune backup enregistrée.**");
      }

      const backupFiles = fs.readdirSync(clientBackupFolderPath);
      if (backupFiles.length === 0) {
        return message.edit("**`❌` Vous n'avez aucune backup enregistrée.**");
      }

      let backupListMessage = "**Voici la liste de vos backups :**\n";
      for (const file of backupFiles) {
        const filePath = `${clientBackupFolderPath}${file}`;
        const backupData = JSON.parse(fs.readFileSync(filePath, "utf8"));

        // Récupération du nom du serveur à partir de la sauvegarde
        const serverName = backupData.name ? backupData.name : "Nom non disponible";
        const backupID = backupData.id;

        backupListMessage += `**ID:** \`${backupID}\` | **Nom du serveur :** \`${serverName}\`\n`;
      }

      await message.edit(backupListMessage);
    }
  },
};
