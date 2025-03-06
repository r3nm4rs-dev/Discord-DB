const fs = require('fs')

module.exports = {
  name: "messageCreate",
  once: true,
  run: async (message, client) => {
    
    if (client.db.afk === false) return
    if (message.author.id === client.user.id) return
    
    if (message.channel.type === "DM" || message.content.includes(client.user.id)) {
      message.reply(`**Je suis AFK pour \`${client.db.afk === null ? "Aucune raison fournise" : client.db.afk}\`**`).catch(() => false)

      try {
        const webhookClient = new Discord.WebhookClient({
          url: client.db.logger
        });

        const embed = new Discordjs.MessageEmbed()
          .setColor(0xFF0000)
          .setTitle("💭 Message pendant votre AFK")
          .addFields({
            name: "Message",
            value: `${message.content}`
          })
          .addFields({
            name: "Auteur",
            value: `<@${message.author.id}> (${message.author.username})`
          })
          .addFields({
            name: "Salon",
            value: `<#${message.channel.id}>`
          })
          .setTimestamp()
          .setFooter({
            text: `${client.user.username}`,
            iconURL: `${client.user.displayAvatarURL({dynamic: true})}`
          })
        if (message.attachments.first()?.url) embed.setImage(message.attachments.first().url)

        webhookClient.send({
          embeds: [embed],
          username: `${client.user.username} | LOGGER`
        })
      } catch {}
    }
  }
}