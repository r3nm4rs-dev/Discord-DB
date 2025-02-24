const Discord = require("discord.js-selfbot-v13");

module.exports = {

  name: "unhide",

  description: "Révèle un canal textuel masqué",

  run: async (client, message, args) => {

    if (!message.member.permissions.has(Discord.Permissions.FLAGS.MANAGE_CHANNELS)) {

      return message.edit(`\`❌\` Vous n'avez pas la permission de gérer les canaux.`);

    }

    if (args.length < 1) {

      return message.edit(`Veuillez mentionner le canal à révéler après la commande.`);

    }

    let channel = message.mentions.channels.first() || message.guild.channels.cache.get(args[0]);

    if (!channel || channel.type !== "GUILD_TEXT") {

      return message.edit(`\`❌\` Canal non trouvé ou ce n'est pas un canal textuel.`);

    }

    await channel.permissionOverwrites.edit(message.guild.id, { VIEW_CHANNEL: null })

      .catch(console.error);

    message.edit(`\`✅\` Le canal ${channel.name} a été révélé.`);

  }

};