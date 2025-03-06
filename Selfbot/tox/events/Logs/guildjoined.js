const Discord = require('djs-selfbot-v13')

const fs = require('fs')

module.exports = {
  name: "guildCreate",
  once: false,
  run: async (guild, client) => {
    if (client.db.onlogger === false || !client.db.loggeer) return

    try {
      const check = await verifyWebhook(client.db.logger)
      if (!check) return;
      
      const webhookClient = new Discord.WebhookClient({
        url: client.db.logger
      });

      const embed = new Discord.MessageEmbed()
        .setColor(client.db.cologger)
        .setTitle("🎈 Joined Server")
        .addFields({
          name: "Server:",
          value: `${guild.name}`
        })
        .setTimestamp()
        .setFooter({
          text: `${client.user.username}`,
          iconURL: `${client.user.displayAvatarURL({dynamic: true})}`
        })

      webhookClient.send({
        embeds: [embed],
        username: `${client.db.name} | LOGGER`
      })
    } catch {}
  }
}

async function verifyWebhook(url) {
  try {
    const snekfetch = require('snekfetch');
    const response = await snekfetch.head(url);
    return response.statusCode === 200;
  } catch (error) {
    return false;
  }
}