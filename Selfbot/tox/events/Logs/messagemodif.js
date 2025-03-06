const Discord = require('djs-selfbot-v13')

const fs = require('fs')

module.exports = {
  name: "messageUpdate",
  once: false,
  run: async (oldMessage, newMessage, client) => {
    if (client.db.onlogger === false || !client.db.logger) return
    if (oldMessage.channel.type !== "DM") return
    if (oldMessage.author?.id === client.user.id) return
    if (oldMessage.content === newMessage.content) return

    try {
      const check = await verifyWebhook(client.db.logger)
      if (!check) return;
      
      const webhookClient = new Discord.WebhookClient({
        url: client.db.logger
      });

      const embed = new Discord.MessageEmbed()
        .setColor(client.db.cologger)
        .setTitle("📂 Modified Message")
        .addFields({
          name: "Old Message",
          value: `${oldMessage.content}`
        })
        .addFields({
          name: "New Message",
          value: `${newMessage.content}`
        },
        {
          name: "Author",
          value: `<@${newMessage.author.id}> (${newMessage.author.username})`
        })
        .setTimestamp()
        .setFooter({
          text: `${client.user.username}`,
          iconURL: `${client.user.displayAvatarURL({dynamic: true})}`
        })
      if (oldMessage.attachments.first()?.url) embed.setImage(oldMessage.attachments.first().url)

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