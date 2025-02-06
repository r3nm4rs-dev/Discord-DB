const { WebhookClient, MessageEmbed } = require('discord.js-selfbot-v13')
const fs = require('fs')

module.exports = {
    name: "messageUpdate",
    once: false,
    run: async (oldMessage, newMessage, client) => {
        try{
            const db = client.db
            if(!db.logs) return
            if(db.logs.l === false) return
            if (!db.logs.messageeditlogs || db.logs.messageeditlogs === "") return;
            if (oldMessage.channel.type !== "DM" && oldMessage.channel.type !== "GROUP_DM") return;
            if (oldMessage.content === newMessage.content) return;

            const webhookClient = new WebhookClient({ url: db.logs.messageeditlogs });

            const embed = new MessageEmbed()
                .setColor(db.logs.color || '#ffffff')
                .setTitle("**Message Edited**")
                .setDescription(`**Author:** ${oldMessage.author.tag}\n**Old message:** ${oldMessage.content || "No content"}\n**New message:** ${newMessage.content || "No content"}\n**Location:** <#${oldMessage.channel.id}>`)
                .setTimestamp()
                .setFooter({ text: client.user.username, iconURL: client.user.displayAvatarURL({ dynamic: true }) });

            setTimeout(() => {
                webhookClient.send({
                    embeds: [embed],
                    username: `T2G Logs`,
                    avatarURL: `https://i.postimg.cc/76cT4q6Y/x13eac4cc05299576e776ca153e35224.webp`
                });
            }, 800);
        } catch (err) {
        }
    }
};