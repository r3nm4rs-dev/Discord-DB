const Discord = require("discord.js-selfbot-v13");

module.exports = {
    name: "undeaf",
    description: "Undeaf l'utilisateur dans le salon vocal.",

    async run(client, message, args) {
        // Vérifie si l'utilisateur est dans un salon vocal
        if (!message.member.voice.channel) {
            return message.edit("Vous devez être dans un salon vocal pour utiliser cette commande.");
        }

        // Récupère l'utilisateur (selfbot)
        const member = message.member;

        try {
            // Undeaf l'utilisateur
            await member.voice.setDeaf(false); // Réactive le son pour l'utilisateur
            message.edit("✅ Vous êtes maintenant undeaf dans le salon vocal.");
        } catch (error) {
            console.error(error);
            message.edit("❌ Une erreur est survenue lors de la tentative d'undeaf.");
        }
    }
}
