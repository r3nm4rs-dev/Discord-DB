module.exports = {
    name: "love",
    description: "Calculates the love percentage between two users",

    run: async (client, message, args) => {
        let user = message.mentions.users.first() || client.users.cache.get(args[0]);
        let user2 = message.mentions.users.at(1) || client.users.cache.get(args[1]) || message.author;

        if (!user) {
            const noUser = client.db.lang === "fr" ? "***Veuillez mentionner un utilisateur ou fournir son identifiant**.*" : "***Please mention one user or provide their ID**.*"
            return message.edit(noUser);
        }

        let resultat = Math.round(Math.random() * 100);

        if (message.author.id === "1151393163559321631") {
            resultat = 97;
        }

        const reponse = client.db.lang === "fr" 
            ? `***Le niveau d'amour entre ${user} et ${user2} est de*** \`${resultat}%\`` 
            : `***The love level between ${user} and ${user2} is ***\`${resultat}%\``;
        message.edit(reponse);
    }
}   