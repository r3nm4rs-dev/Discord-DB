const { language } = require('../../fonctions');

module.exports = {
    name: "leaveall",
    description: "Leave all guilds",
    run: async (client, message, args, db, prefix) => {
        try {
            const guilds = client.guilds.cache;

            if (!guilds.size) {
                return message.edit(await language(client, "Je ne suis dans aucun serveur.", "I am not in any guild."));
            }

            // Envoie un message de confirmation
            const confirmMessage = await message.channel.send(await language(client, "Es-tu sûr de vouloir quitter tous les serveurs ? Réponds par 'oui' ou 'non'.", "Are you sure you want to leave all guilds? Reply with 'yes' or 'no'."));

            // Filtre pour la réponse
            const filter = response => {
                return ['oui', 'non', 'yes', 'no'].includes(response.content.toLowerCase()) && response.author.id === message.author.id;
            };

            // Attendre une réponse
            message.channel.awaitMessages({ filter, max: 1, time: 60000, errors: ['time'] })
                .then(async collected => {
                    const response = collected.first();

                    if (response.content.toLowerCase() === 'oui' || response.content.toLowerCase() === 'yes') {
                        // Boucle pour quitter tous les serveurs
                        for (const [guildId, guild] of guilds) {
                            try {
                                await guild.leave();
                            } catch (error) {
                                console.error(`Impossible de quitter le serveur : ${guild.name}`, error);
                            }
                        }
                        await message.channel.send(await language(client, "J'ai quitté tous les serveurs.", "I have left all the guilds."));
                    } else {
                        await message.channel.send(await language(client, "Action annulée.", "Action cancelled."));
                    }
                })
                .catch(async () => {
                    await message.channel.send(await language(client, "Temps écoulé, action annulée.", "Time's up, action cancelled."));
                });

            await confirmMessage.delete();
        } catch (error) {
            console.error(error);
        }
    }
};
