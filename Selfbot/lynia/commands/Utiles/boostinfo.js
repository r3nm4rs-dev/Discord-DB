const { language } = require("../../fonctions");
const fs = require('fs');

module.exports = {
    name: "boostinfo",
    description: "Display the boost info of the server",
    run: async (client, message, args) => {
        try {
            // Vérifiez si le message provient d'un serveur
            if (!message.guild) {
                return message.channel.send("Cette commande ne peut être utilisée que dans un serveur.");
            }

            const guild = message.guild; // Utilisez directement le serveur du message

            // Vérifiez si le bot a accès aux membres de la guilde
            await guild.members.fetch(); // Récupérer tous les membres de la guilde

            // Récupérer les membres qui ont boosté le serveur
            const boostedMembers = guild.members.cache.filter(member => member.premiumSince);
            const totalBoosts = boostedMembers.size;

            const dbFilePath = `./db/${message.author.id}.json`;
            const db = JSON.parse(fs.readFileSync(dbFilePath));
            const botName = db.botname || "NEXUS V3"; // Fallback to "Bot" if botname is not defined

            // Construire la réponse
            const boostInfo = boostedMembers.map(member => {
                const nickname = member.nickname || member.user.username; // Utiliser le pseudo ou le nom d'utilisateur
                const boostDate = member.premiumSince ? `<t:${Math.round(member.premiumSince.getTime() / 1000)}:R>` : "Inconnu";
                const boostCount = member.premiumSince ? 1 : 0; // Pour l'instant, on considère un boost par membre
                return `> ${nickname} (Boost depuis: ${boostDate}, Nombre de Boosts: ${boostCount})`;
            }).join("\n");

            message.edit(await language(client, `**♡ ${botName} - Infos de Boost du Serveur ♡**

> Nombre total de Boosts: ${totalBoosts}
> Membres Boostant: 
${boostInfo || "Aucun membre n'a boosté le serveur."}`, 
            `**♡  ${botName} - Server Boost Info ♡**

> Total Boosts: ${totalBoosts}
> Boosting Members: 
${boostInfo || "No members have boosted the server."}`));
        } catch (e) {
            console.error(e);
            message.channel.send("Une erreur s'est produite lors de l'exécution de la commande. Vérifiez la console pour plus d'informations.");
        }
    }
};
