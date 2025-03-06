const Discord = require('discord.js');

module.exports.run = async (client, message, args) => {
  if (!message.member.permissions.has('MANAGE_EMOJIS_AND_STICKERS')) return message.channel.send({ embeds: [new Discord.MessageEmbed()
            .setAuthor(`You dont have permission`, message.author.displayAvatarURL({dynamic:true})) 
            .setDescription(`You Want Administrator or Manage Emojis permissions to use this Command`)
            .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))
  if (args.length < 2) return message.channel.send({embeds:[new Discord.MessageEmbed() 
            .setAuthor(`Wrong Usage`, message.author.displayAvatarURL({dynamic:true}))
            .setDescription(`Arguments required`)
            .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))
  const emoji = args[0];
	let emojiname = args[1];
  const emojiRegex = /<(a?):(.*?):(\d.*?[0-9])>/i;
  const emojiid = emoji.match(emojiRegex)
  let animated = false
  if (!emojiid) {
    return message.channel.send({embeds:[new Discord.MessageEmbed() 
            .setAuthor(`Wrong Usage`, message.author.displayAvatarURL({dynamic:true}))
            .setDescription(`Arguments required`)
            .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          msg.delete()
          message.delete()
        }, client.config.message_remove_time*1000))
  }
  else {
			if (emojiid[1] === "a") {
				animated = true
			}
			let emojiurl = `https://cdn.discordapp.com/emojis/${emojiid[3]}`


			if (animated === true) {
				emojiurl += ".gif"
			}
			else if (animated === false) {
				emojiurl += ".png"
      }
    const emoji = await message.guild.emojis.create(emojiurl, emojiname).catch(() => {
      throw err;
    });

    return message.channel.send(`Done! created new emoji ${emoji.name} ${emoji.toString()}`);
  }
}