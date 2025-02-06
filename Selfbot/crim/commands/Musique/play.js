const { joinVoiceChannel, createAudioPlayer, createAudioResource, AudioPlayerStatus } = require('@discordjs/voice');
const play = require('play-dl');

module.exports = {
  name: "play",
  description: "Jouer de la musique dans un salon vocal.",
  run: async (client, message, args) => {
    if (args.length < 2) {
      return message.edit("Veuillez fournir l'ID du salon vocal et le nom de la musique.");
    }

    const voiceChannelId = args[0];
    const voiceChannel = client.channels.cache.get(voiceChannelId);
    if (!voiceChannel || voiceChannel.type !== 'GUILD_VOICE') {
      return message.edit("Le salon vocal spécifié n'existe pas ou n'est pas un salon vocal.");
    }

    const connection = joinVoiceChannel({
      channelId: voiceChannelId,
      guildId: voiceChannel.guild.id,
      adapterCreator: voiceChannel.guild.voiceAdapterCreator,
    });

    try {
      const musicName = args.slice(1).join(" ");
      const video = await play.search(musicName, { limit: 1 });
      if (video.length === 0) {
        return message.edit('Aucun résultat trouvé pour ' + musicName);
      }
      const stream = await play.stream(video[0].url);
      const resource = createAudioResource(stream.stream, { inputType: stream.type });

      const player = createAudioPlayer();
      player.play(resource);
      connection.subscribe(player);

      message.edit(`\`🔎\` Musique en cours de lecture dans le salon ${voiceChannel.name} : **${video[0].title}**`);

      player.on('error', error => {
        console.error('Erreur lors de la lecture de la musique:', error);
        message.edit("Une erreur est survenue lors de la lecture de la musique.");
      });

      player.on(AudioPlayerStatus.Idle, () => {
        connection.destroy();
        message.channel.send(`\`✅\` Musique terminée.`);
      });
    } catch (error) {
      console.error(error);
      message.edit("Erreur lors de la recherche ou de la lecture de la musique.");
    }
  },
};

