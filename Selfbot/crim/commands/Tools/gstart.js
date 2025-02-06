const Discord = require("discord.js-selfbot-v13");
const moment = require("moment");

module.exports = {
  name: "gstart",
  description: "Démarre un giveaway.",
  run: async (client, message, args) => {
    if (args.length < 3) { 
      return message.edit(`\`❌\` Veuillez fournir \`la durée\`, \`le nombre de gagnants\` et le \`prix\`.`);
    }

    const duration = args[0]; 
    const winnersCount = parseInt(args[1]);
    const prize = args.slice(2).join(" "); 

    if (isNaN(winnersCount)) {
      return message.edit(`\`❌\` Le nombre de gagnants doit être un nombre valide.`);
    }

    const durationUnit = duration.charAt(duration.length - 1);
    const durationValue = parseInt(duration.substring(0, duration.length - 1));

    if (isNaN(durationValue)) {
      return message.edit(`\`❌\` Durée invalide.`);
    }

    let endTime;
    switch (durationUnit) {
      case "d":
        endTime = moment().add(durationValue, "days").unix();
        break;
      case "h":
        endTime = moment().add(durationValue, "hours").unix();
        break;
      case "m":
        endTime = moment().add(durationValue, "minutes").unix();
        break;
      default:
        return message.edit(`\`❌\` Unité de temps invalide. Veuillez utiliser 'd' pour les jours, 'h' pour les heures et 'm' pour les minutes.`);
    }

    const giveawayMessage = await message.channel.send(`**GIVEAWAY**\n\n**Prix:** ${prize}\n\n**Fin:** <t:${endTime}:R> <t:${endTime}:T>\n\n**Organisé par:** <@${message.author.id}>\nRéagissez avec 🎉 pour participer !`);
    await giveawayMessage.react("🎉");

    setTimeout(async () => {
      const reaction = giveawayMessage.reactions.cache.get("🎉");
      if (!reaction) return message.edit("Impossible de récupérer les réactions.");

      const users = await reaction.users.fetch();
      const validEntries = users.filter(u => !u.bot);
      let winners = validEntries.random(winnersCount);

      if (winners.length > 0) {
        giveawayMessage.edit(`**GIVEAWAY TERMINÉ**\n\n**Félicitations ${winners.map(user => `<@${user.id}>`).join(", ")}! Vous avez gagné ${prize}!**`);
      } else {
        giveawayMessage.edit(`**GIVEAWAY TERMINÉ**\n\nPas assez de participants pour déterminer un gagnant.`);
      }
    }, (endTime * 1000) - Date.now());
  }
};

