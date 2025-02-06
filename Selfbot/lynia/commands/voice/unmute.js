const Discord = require("discord.js-selfbot-v13");

module.exports = {
    name: "unmute",
    description: "Unmute l'utilisateur dans le salon vocal.",

    async run(client, message, args) {
        // Vérifie si l'utilisateur est dans un salon vocal
        if (!message.member.voice.channel) {
            return message.edit("Vous devez être dans un salon vocal pour utiliser cette commande.");
        }

        // Récupère l'utilisateur (selfbot)
        const member = message.member;

        try {
            // Unmute l'utilisateur
            await member.voice.setMute(false); // Réactive le micro de l'utilisateur
            message.edit("✅ Vous êtes maintenant unmute dans le salon vocal.");
        } catch (error) {
            console.error(error);
            message.edit("❌ Une erreur est survenue lors de la tentative d'unmute.");
        }
    }
}
