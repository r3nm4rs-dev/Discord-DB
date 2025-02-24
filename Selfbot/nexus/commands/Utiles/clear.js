module.exports = {

    name: "clear",

    description: "Clear un nombre de messages",

    run: async (client, message, args) => {

        try {

            // Supprime le message de la commande

            await message.delete().catch(() => false);

            const nombre = parseInt(args[0]) || 9999999;

            let i = 0;

            // Récupère les messages du channel et les filtre

            message.channel.messages.fetch({ force: true }).then(messages => {

                messages.forEach(singleMessage => {

                    if (singleMessage.author.id === client.user.id) {

                        // Gère la limite de taux (rate limit)

                        client.on('rateLimit', async (timeout) => {

                            function sleep(ms) { return new Promise(resolve => setTimeout(resolve, ms)); }

                            await sleep(timeout * 10);

                        });

                        // Arrête après avoir supprimé le nombre spécifié de messages

                        if (i === nombre) return;

                        singleMessage.delete().catch(err => { });

                        i++;

                    }

                });

            });

        } catch (e) {

            console.log(e);

        }

    }

};