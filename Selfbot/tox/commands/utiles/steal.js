const Discord = require('discord.js');  // Ajout de l'importation de Discord
const fs = require('fs');

module.exports = {
  name: "steal",
  descriptionfr: "Vole un emoji/tous les emojis d'un serveur",
  descriptionen: "Steal an emoji/all the emojis from a server",
  usage: "<guildid>",
  run: async (client, message, args) => {
    if (args[0] === "all") {
      const guild = client.guilds.cache.get(args[1]); // Utilisation de args[1] pour récupérer l'ID du serveur
      if (!guild) return message.edit(client.trad(
        `No guild found for \`${args[1] || "nothing"}\``,
        `Aucun serveur trouvé pour \`${args[1] || "rien"}\``,
      ));

      const er = new Array();
      guild.emojis.cache.forEach(e => er.push(`${e.toString()}`)); // Correction : on ne peut pas appeler `er.emojis`

      message.edit(client.trad(
        "Emojis are being created...",
        "Les emojis sont en train de se créer...",
      ));

      // Utilisation de `forEach` de manière correcte
      await Promise.all(er.map(async emote => {
        let emoji = Discord.Util.parseEmoji(emote);
        if (emoji.id) {
          const Link = `https://cdn.discordapp.com/emojis/${emoji.id}.${emoji.animated ? 'gif' : 'png'}`;
          guild.emojis.create(Link, emoji.name).catch(() => false);
        }
      }));
    } else {
      if (!message.guild) return message.edit(client.trad(
        `Please execute this command in a server`,
        `Veuillez exécuter cette commande dans un serveur`,
      ));

      if (!message.guild.members.me.permissions.has("MANAGE_EMOJIS_AND_STICKERS")) 
        return message.edit(client.trad(
          "You do not have the permissions to run this command",
          "Vous n'avez pas les permissions pour exécuter cette commande",
        ));

      const parsedEmoji = Discord.Util.parseEmoji(args[0]);

      if (!parsedEmoji.id) return message.edit(client.trad(
        "Unable to get the emoji",
        "Impossible d'obtenir l'emoji",
      ));

      const url = `https://cdn.discordapp.com/emojis/${parsedEmoji.id}${parsedEmoji.animated ? ".gif" : ".png"}`;
      message.guild.emojis.create(url, parsedEmoji.name)
        .then(() => message.edit(client.trad("1 Emoji Added", "1 Emoji Ajouté")));
    }
  }
}
