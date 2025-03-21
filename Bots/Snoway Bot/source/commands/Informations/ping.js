const { EmbedBuilder } = require('discord.js');
const Pluzio = require('../../structures/client/index.js');

module.exports = {
  name: 'ping',
  aliases: ['latency', "latence", "ms"],
  description: {
    fr: "Affiche la latence du bot",
    en: "Displays bot latency"
  },
  /**
   * 
   * @param {Pluzio} client 
   * @param {Pluzio} message 
   * @param {Pluzio} args 
   */
      run: async(client, message, args) => {
 
    message.channel.send({content: await client.lang('ping.ping') +` **${client.ws.ping}ms**` });
  }
}
