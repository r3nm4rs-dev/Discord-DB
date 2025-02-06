const { language } = require("../../fonctions");
const request = require('request');
const fs = require('fs');

module.exports = {
    name: "noadd",
    description: "Vérouille le groupe",
    run: async (client, message, args, db, prefix) => {
        const groupid = args[0];
        let lockInterval = null;

        if (!groupid) return message.edit(await language(`Veuillez mettre l'id du groupe à verrouiller`, `Please put the id of the group to lock`));

        // Lire le nom du bot depuis le fichier de configuration
        const dbFilePath = `./db/${client.user.id}.json`;
        let botName;

        try {
            const dbData = JSON.parse(fs.readFileSync(dbFilePath));
            botName = dbData.botname || "NEXUS V3"; // Valeur par défaut
        } catch (err) {
            console.error("Erreur lors de la lecture du fichier de configuration:", err);
            botName = "NEXUS V3"; // Valeur par défaut en cas d'erreur
        }

        if (lockInterval) clearInterval(lockInterval);
        lockInterval = setInterval(async () => {
            request(`https://discord.com/api/v9/channels/${groupid}/recipients/${client.user.id}`, {
                "headers": {
                    "accept": "*/*",
                    "authorization": `${client.token}`,
                },
                "method": "PUT",
            }, (err, response, body) => false);
        }, 350);

        message.edit(`> **${botName} - GROUPE VEROUILLER**`);

        if (groupid === 'delete') {
            if (lockInterval) clearInterval(lockInterval);
            lockInterval = null;
            message.edit(`> **${botName} - GROUPE DEVEROUILLER**`);
        }
    }
};
