const fs = require('fs')

module.exports = {
  name: "gleave",
  descriptionfr: "Quitter un serveur",
  descriptionen: "Leave a server",
  run: async (client, message, args) => {
    const guild = client.guilds.cache.get(args[0]) || message.guild;
    if (!guild)
      return message.edit(
        client.trad(
          `No guild found for \`${args[0] || "nothing"}\``,
          `Aucun serveur de trouvé pour \`${args[0] || "rien"}\``,
        )
      );
      
      await message.delete().catch(() => false)
      guild.leave().catch(() => false)
  },
};
