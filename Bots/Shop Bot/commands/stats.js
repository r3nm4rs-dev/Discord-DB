module.exports.run = (client, message) => {
  return message.reply("See \`guildconfig.json\` And Fill It.").then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))
}