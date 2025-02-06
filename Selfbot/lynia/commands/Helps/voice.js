const { language } = require("../../fonctions");

module.exports = {
  name: "voice",
  description: "Menu voice",
  run: async (client, message, args, db, prefix) => {
    const botName = db.botname || 'NEXUS';

    message.edit(
      await language(
        client,
        `♡ **${botName} - Voice**\n
> \`${prefix}joinvc <channel_id>\` ➜ **Rejoindre un salon vocal.**\n
> \`${prefix}autovoc <channel_id>\` ➜ **Activer la connexion automatique à un salon vocal.**\n
> \`${prefix}leave\` ➜ **Quitter le salon vocal.**\n`,
        `♡ **${botName} - Voice**\n
> \`${prefix}joinvc <channel_id>\` ➜ **Join a voice channel.**\n
> \`${prefix}autovoc <channel_id>\` ➜ **Enable automatic voice channel connection.**\n
> \`${prefix}leave\` ➜ **Leave the voice channel.**\n`
      )
    );
  },
};
