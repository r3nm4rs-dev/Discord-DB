const fs = require('fs');

module.exports = {
    name: "pluzio",
    description: "Envoie le lien de connexion vers Pluzio.",
    run: async (client, message, args) => {
        try {
            // Envoie le lien de connexion
            const nexusLink = "https://pluzio-sb.online/";
            await message.channel.send(`Voici le lien de connexion vers Pluzio : ${nexusLink}`);
        } catch (e) {
            console.error(e);
            message.channel.send("Une erreur s'est produite lors de l'exécution de la commande. Vérifiez la console pour plus d'informations.");
        }
    }
};
