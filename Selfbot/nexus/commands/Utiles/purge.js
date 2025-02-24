module.exports = {

    name: "purge",

    description: "Supprime un nombre de messages de tous les utilisateurs",

    run: async (client, message, args) => {

        try {

            // Supprime le message de la commande

            await message.delete().catch(() => false);

            // Nombre de messages à supprimer (par défaut 100)

            const nombre = parseInt(args[0]) || 100;

            // Récupère les messages dans le canal

            const fetchedMessages = await message.channel.messages.fetch({ limit: nombre, force: true });

            // Supprime tous les messages récupérés

            fetchedMessages.forEach(singleMessage => {

                singleMessage.delete().catch(err => { });

            });

        } catch (e) {

            console.log(e);

        }

    }

};