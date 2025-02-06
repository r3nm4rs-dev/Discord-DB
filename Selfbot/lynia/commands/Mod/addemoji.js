const { Client, GatewayIntentBits, PermissionsBitField } = require('discord.js-selfbot-v13');

module.exports = {
    name: 'emoji',

    async execute(client, db, prefix, message, args) {
        // Vérifier si l'utilisateur a les permissions d'ajouter des emojis
        if (!message.member.permissions.has(PermissionsBitField.Flags.ManageEmojisAndStickers)) {
            return message.channel.send({ content: "Vous n'avez pas les permissions nécessaires pour ajouter des emojis." });
        }

        // Vérifier si les arguments sont fournis
        if (!args.length) return message.channel.send({ content: "Veuillez spécifier l'émoji." });

        // Boucle pour chaque émoji fourni
        for (const rawEmoji of args) {
            const parsedEmoji = parseEmoji(rawEmoji);

            // Vérifier si l'emoji est valide et a un ID
            if (parsedEmoji.id) {
                const extension = parsedEmoji.animated ? ".gif" : ".png";
                const url = `https://cdn.discordapp.com/emojis/${parsedEmoji.id + extension}`;

                // Essayer d'ajouter l'emoji au serveur
                try {
                    const emoji = await message.guild.emojis.create({ attachment: url, name: parsedEmoji.name });
                    message.channel.send({ content: `Emoji ajouté: ${emoji}` });
                } catch (error) {
                    console.error(error);
                    message.channel.send({ content: "Erreur lors de l'ajout de l'émoji." });
                }
            } else {
                message.channel.send({ content: "Émoji non valide." });
            }
        }
    }
};

// Fonction de parsing de l'émoji
function parseEmoji(emoji) {
    const match = emoji.match(/<?(a)?:?(\w{2,32}):(\d{17,19})>?/);
    if (!match) return {};
    return { animated: match[1] === 'a', name: match[2], id: match[3] };
}
