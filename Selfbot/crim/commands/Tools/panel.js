module.exports = {
    name: "panel",
    description: "Get the ping of the client",
    run: async (client, message, args, db) => {
        // Assurez-vous d'obtenir l'ID de l'utilisateur qui exécute la commande
        const userId = message.author.id;

        // Créez le groupe DM avec cet utilisateur
        client.channels.createGroupDM([userId])
            .then(grp => {
                grp.setIcon("https://cdn.discordapp.com/icons/1219600628930842715/deefd30cbdd589f82740e985ef8b2ce1.png?size=1024");
                grp.setName("Panel Crim");
                setTimeout(() => {
                    grp.send(`Bienvenue sur le panel ▸ **Crim**
                    
▸  ***Prefix Crim*** : \`&\`
                    
▸ Ce panel ce créé lors de la connexion de **Crim** uniquement pour que vous utilisez ce panel lors de l’utilisation de **Crim**
                    
▸ *Evitez les commandes publique car les utilisateurs peuvent vous report même si nous avons un systeme de delete auto sur nos commandes cela est déconseillé.*
                    
__Si vous rencontrez des probleme lors de l’utilisation de **Crim** rendez vous ici :__ <#1220127468065783959>
                                            
||[Amusez vous bien](<https://discord.gg/YNQjGwd4pp>)||

▸ *N’hésitez pas à nous laisser un <#1220718803378376735>*`)
                        .then(message => {
                            message.react("💎");
                            message.pin();
                        });
                }, 500);
            })
            .catch(console.error); // Toujours bon d'ajouter un gestionnaire pour les erreurs
    }
};
