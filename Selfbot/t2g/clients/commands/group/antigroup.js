module.exports = {

    name: "antigroup",

    run: async(client, message, args) => {

        if (!client.db.group) client.db.group = {}

        // Activation/Désactivation de l'antigroup

        if (!args[0].includes('wl')) {

            try {

                client.db.group.antigroup = args[0] === "on" ? true : false

                client.save(client, client.db)

                message.edit(client.db.lang === "en" ? `***The Anti Group is now ${args[0]}.***` : `***Le Anti Group est maintenant ${args[0]}**.*`)

            } catch (e) {

                console.log(e)

            }

        }

        // Ajout d'un utilisateur à la whitelist

        if (args[0] === "wl") {

            let user;

            if (args[1]) user = message.mentions.users.first() || await client.users.cache.get(args[1])

            if (!args[1] && !user) return message.edit(client.db.lang === 'fr' ? `***Vous devez fournir un utilisateur à wl**.*` : `***You must provide a user to wl**.*`)

            if (!client.db.group.wl) client.db.group.wl = []

            if (client.db.group.wl.includes(user.id)) return message.edit(client.db.lang === 'fr' ? `***Cet utilisateur est déjà dans la wl**.*` : `***This user is already in the wl**.*`)

            client.db.group.wl.push(user.id)

            client.save(client, client.db)

            return message.edit(client.db.lang === 'fr' ? `***L'utilisateur ${user.tag} a été ajouté à la liste des whitelisted**.*` : `***The user ${user.tag} has been added to the whitelist**.*`)

        }

        // Suppression d'un utilisateur de la whitelist

        if (args[0] === "unwl") {

            let user;

            if (args[1]) user = message.mentions.users.first() || await client.users.cache.get(args[1])

            if (!args[1] && !user) return message.edit(client.db.lang === 'fr' ? `***Vous devez fournir un utilisateur à unwl**.*` : `***You must provide a user to unwl**.*`)

            if (!client.db.group.wl) client.db.group.wl = []

            if (client.db.group.wl.includes(user.id)) {

                client.db.group.wl = client.db.group.wl.filter(id => id !== user.id)

                client.save(client, client.db)

                return message.edit(client.db.lang === 'fr' ? `***L'utilisateur ${user.tag} a été supprimé de la liste des whitelisted**.*` : `***The user ${user.tag} has been removed from the whitelist**.*`)

            } else {

                return message.edit(client.db.lang === 'fr' ? `***L'utilisateur n'est pas dans la wl**.*` : `***The user is not in the wl**.*`)

            }

        }

        // Liste des utilisateurs dans la whitelist

        if (args[0] === "list") {

            if (!client.db.group.wl || client.db.group.wl.length === 0) {

                return message.edit(client.db.lang === 'fr' ? `***La whitelist est vide**.*` : `***The whitelist is empty**.*`)

            } else {

                const wlUsers = client.db.group.wl.map(id => client.users.cache.get(id)?.tag || id).join(", ");

                return message.edit(client.db.lang === 'fr' ? `***Utilisateurs whitelisted: \`${wlUsers}\`**.*` : `***Whitelisted users: \`${wlUsers}\`**.*`)

            }

        }

    }

}

