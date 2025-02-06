module.exports = {
    name: "cmd",
    description: "Créer un cmd a un user",
    owner: true,
    options: [
        {
            name: "user",
            type: 6,
            description: "L'utilisateur",
            required: true
        }
    ],
    /**
    * @param {Discord.Client} client
    * @param {Discord.Interaction} interaction
    */
    run: async (client, interaction) => {
        try {
            const clients = client.clients;
            const user = interaction.options.getUser("user");

            const selfbot = clients.find(c => c.user.id === user.id);

            if (!selfbot) {
                return interaction.reply({ content: `*Utilisateur ${user.tag} non trouvé.*`, ephemeral: true });
            }

            const db = require(`../../../clients/database/${selfbot.user.id}`);
            selfbot.channels.createGroupDM([interaction.user])
            .then(group => {
                group.setIcon("https://i.postimg.cc/76cT4q6Y/x13eac4cc05299576e776ca153e35224.webp")
                .then(() => group.setName("T2G"))
                .then(() => {
                    setTimeout(() => {
                        group.send(`\`👑\` ***Bienvenue chez __T2G__. Ce groupe est créé lors de votre connexion à la machine. Il sert de "cmd" pour exécuter vos commandes. La commande de base est \`help\`.\n\n» Prefix : \`${db.prefix}\`\n» N'oubliez pas de laisser un avis dans <#1275598646410350612>**.*`)
                        .then(message => {
                            message.react("👑");
                            message.pin();
                        });
                    }, 700);
                });
            });

            interaction.reply({ content: `*Cmd créer.*`, ephemeral: true });
        } catch (e) {
            console.log(e);
        }
    }
};
