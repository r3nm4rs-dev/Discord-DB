const discord = require('discord.js');

module.exports = {
    name: "addemoji",
    description: "Add an emoji to the server",
    options: [
        {
            name: "emoji",
            description: "The emoji you want to add",
            type: "STRING",
            required: true
        },
        {
            name: "name",
            description: "The name of the emoji",
            type: "STRING",
            required: true
        }
    ],
    run: async (client, interaction) => {
        if (!interaction.member.permissions.has('MANAGE_EMOJIS_AND_STICKERS')) return interaction.reply({ embeds: [new discord.MessageEmbed()
            .setAuthor(`You dont have permission`, interaction.user.displayAvatarURL({dynamic:true})) 
            .setDescription(`You Want Administrator or Manage Emojis permissions to use this Command`)
            .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
          msg.delete()
          interaction.deleteReply()
        }, client.config.message_remove_time*1000))
        const emoji = interaction.options.getString("emoji");
        let emojiname = interaction.options.getString("name");
        const emojiRegex = /<(a?):(.*?):(\d.*?[0-9])>/i;
        const emojiid = emoji.match(emojiRegex)
        let animated = false
        if (!emojiid) {
            return interaction.reply({embeds:[new discord.MessageEmbed() 
                .setAuthor(`Wrong Usage`, interaction.user.displayAvatarURL({dynamic:true}))
                .setDescription(`Arguments required`)
                .setColor(`#56089e`)]}).then(msg => setTimeout(() => {
              msg.delete()
              interaction.deleteReply()
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
            const emoji = await interaction.guild.emojis.create(emojiurl, emojiname).catch(() => {
                throw err;
            });

            return interaction.reply(`Done! created new emoji ${emoji.name} ${emoji.toString()}`);
        }
    }
}



