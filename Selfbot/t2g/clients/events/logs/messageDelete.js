const { WebhookClient, MessageEmbed } = require('discord.js-selfbot-v13')
const fs = require('fs')

module.exports = {
    name: "messageDelete",
    once: false,
    run: async (message, client) => {
        try{
            const db = client.db
            if(!db.logs) return
            if(db.logs.l === false) return
            if(!db.logs.messagedeletelogs) return
            if(db.logs.messagedeletelogs === "") return
            if (message.channel.type !== "DM" && message.channel.type !== "GROUP_DM") return

            const webhookClient = new WebhookClient({ url: db.logs.messagedeletelogs });

            const embed = new MessageEmbed()
            .setColor(db.logs.color || '#ffffff')
            .setTitle("**Message deleted**")
            .setDescription(`**Author:** \`${message.author.tag}\`\n**Location:** <#${message.channel.id}>\n**Content:**\n${message.content}`)
            .setTimestamp()
            .setFooter({text: client.user.username, iconURL: `${client.user.displayAvatarURL({dynamic: true})}`})

            setTimeout(() => {
                webhookClient.send({ embeds: [embed], username: `T2G Logs`, avatarURL: `https://i.postimg.cc/76cT4q6Y/x13eac4cc05299576e776ca153e35224.webp` });
            }, 800);
        }
        catch(err){}
    }
}