module.exports = {

  name: 'messageDelete',

  run: async (message, client) => {

    // Vérifiez que le message n'est pas d'un bot

    if (message.author.bot) return;

    // Enregistrez le message supprimé

    client.snipe.set(message.channel.id, {

      content: message.content,

      author: message.author.tag,

      avatar: message.author.displayAvatarURL(),

      timestamp: message.createdTimestamp

    });

  },

};