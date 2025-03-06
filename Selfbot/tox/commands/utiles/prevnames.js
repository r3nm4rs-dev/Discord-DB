const fs = require('fs')

module.exports = {
  name: "prevnames",
  descriptionfr: "Affiche les anciens pseudos d'un utilisateur",
  descriptionen: "Display the olds names of a user",
  usage: "[user]",
  run: async (client, message, args) => {
    let user =
      message.mentions.users.first() || client.users.cache.get(args[0]);
    if (!user)
      try {
        user = await client.users.fetch(args[0]);
      } catch {
        user = message.author;
      }

    const data = await client.mongodb.get("prevnames") || []
    const Object = data.filter(c => c?.id === user.id)

    if (!Object || Object.length === 0) return message.edit(client.trad(`We didn't got any old username of ${user.username} in our db`, `Nous ne trouvons aucun ancien pseudo de ${user.username} dans notre base de donnée`))
    
    message.edit(
      `${client.trad(`List of old usernames of ${user.username}`, `Liste des anciens pseudos de ${user.username}`)}\n\n${
        Object.names.map(pseudo, i => `**<t:${Object.times[i]}>** - **${pseudo}**`).join("\n") || client.trad("No data found", "Aucune donnée trouvée")
      }`
    );
  },
};