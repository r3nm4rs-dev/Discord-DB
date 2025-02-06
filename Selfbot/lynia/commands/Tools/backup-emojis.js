const fs = require("fs");
const path = require("path");
const Discord = require("discord.js-selfbot-v13");

module.exports = {
    name: "backup-emojis",
    description: "Sauvegarde les emojis du serveur dans un fichier JSON.",
    run: async (client, message, args) => {
        // Créer le dossier ./backups s'il n'existe pas
        const backupDir = path.join(__dirname, 'backups');
        if (!fs.existsSync(backupDir)) {
            fs.mkdirSync(backupDir, { recursive: true });
        }

        const emojis = message.guild.emojis.cache.map(emoji => ({
            id: emoji.id,
            name: emoji.name,
            url: emoji.url,
            animated: emoji.animated
        }));

        const backupData = JSON.stringify(emojis, null, 2);
        const filePath = path.join(backupDir, `emojis-backup-${message.guild.id}.json`);

        fs.writeFileSync(filePath, backupData);

        message.edit(`\`✅\` Emojis sauvegardés avec succès dans le fichier : emojis-backup-${message.guild.id}.json`);
    }
};
