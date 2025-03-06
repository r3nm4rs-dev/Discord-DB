const Discord = require('djs-selfbot-v13')

const fs = require('fs')

module.exports = {
  name: "messageDelete",
  once: false,
  run: async (message, client) => {
    if (!message.author) return;
    if (client.db.onlogger === false || !client.db.logger) return;
    if (message.channel.type !== "DM") return
    if (message.author?.id === client.user.id) return

    try {
      const check = await verifyWebhook(client.db.logger)
      if (!check) return;
      
      const webhookClient = new Discord.WebhookClient({
        url: client.db.logger
      });

      const embed = new Discord.MessageEmbed()
        .setColor(client.db.cologger)
        .setTitle("🗑️ Deleted Message")
        .addFields({
          name: "Message:",
          value: `${message.content}`
        },
        {
          name: "Author",
          value: `<@${message.author.id}> (${message.author.username})`
        })
        .setTimestamp()
        .setFooter({
          text: `${client.user.username}`,
          iconURL: `${client.user.displayAvatarURL({dynamic: true})}`
        })
      if (message.attachments.first()?.url) embed.setImage(message.attachments.first().url)

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